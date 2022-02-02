using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace AionDPS
{
    class LogAnalyzer : SingletonBase<LogAnalyzer>
    {
        public Dictionary<string, Log> userList = new Dictionary<string, Log>();
        private XmlDocument xmlDoc = new XmlDocument();
        private bool isSkipped = false;

        public static void Initialize()
        {
            string skillsDB = string.Empty;
            using (Stream stream = Instance.GetType().Assembly.GetManifestResourceStream("AionDPS.Database.skills.xml"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    skillsDB = sr.ReadToEnd();
                }
            }

            Instance.xmlDoc.LoadXml(skillsDB);
        }


        public void Analyze(string logStr, string guardName)
        {
            Analyzed logResult = LogRegex.getLogResult(logStr, guardName);
            Log userLog;


            string userName = logResult.userName;
            string skillName = logResult.skillName;

            if (userName == null || userName == "") return;
            else if (userName.IndexOf("의 정령") != -1 || userName.IndexOf("의 기운") != -1)
                return;
            else if ((userName.IndexOf(" ")) != -1)
                return;

            if (logResult.isCastSpd)
            {
                if (logResult.hittedObjectName != "")
                    userName = logResult.hittedObjectName;
                else
                    userName = logResult.userName;
            }

            if (!userList.ContainsKey(userName))
            {
                userLog = new Log(userName);
                userList.Add(userName, userLog);
            }
            
            userLog = userList[userName];

            if (logResult.isCastSpd)
            {
                userLog.castSpeedCount++;
                userList[userName] = userLog;
                userLog.lastLog = logResult;
                return;
            }

            if (logResult.rage)
            {
                userLog.rage = true;
                userLog.rageDamage = logResult.rageDamage;
                return;
            }

            if (userName.IndexOf(' ') != -1 && skillName.IndexOf(userName) != -1)
                return;
            else if (userName == "빙판" && skillName.StartsWith("빙판") && skillName.EndsWith("효과"))
                return;

            GetNewAtk(userLog, logResult);

            userLog.accDamage += logResult.damage;
            userLog.time = GetTime(userLog, logResult.loggedTime);
            userLog.DPS = userLog.accDamage / userLog.time;
            userLog.lastLoggedTime = logResult.loggedTime;
            userLog.MaxDamage = userLog.MaxDamage < logResult.damage ? logResult.damage : userLog.MaxDamage;
            userLog.atkAccDamage += logResult.skillName == "" ? logResult.damage : 0;
            userLog.skillAccDamage += logResult.skillName != "" ? logResult.damage : 0;

            if (logResult.isCritical)
            {
                
                if(userLog.userName != Main.form.textBox1.Text)
                {
                    userLog.skillCriticalTimes++;
                }
                else
                {
                    if (logResult.skillName == "")
                        userLog.criticalTimes++;
                    else userLog.skillCriticalTimes++;
                }
            }
            if (logResult.skillName != null && userLog.userClass == "")
                userLog.userClass = getUserClass(userLog, logResult);

            userLog.skillCriticalPercentage = userLog.skillTimes != 0 ? Convert.ToInt32(userLog.skillCriticalTimes / userLog.skillTimes * 100) : 0;
            userLog.avgAtkDamage = userLog.atkTimes != 0 ? Convert.ToInt32(userLog.atkAccDamage / userLog.atkTimes) : 0;
            userLog.avgSkillDamage = userLog.skillTimes != 0 ? Convert.ToInt32(userLog.skillAccDamage / userLog.skillTimes) : 0;
            userLog.atkPercentage = userLog.accDamage != 0 ? userLog.atkAccDamage * 100 / userLog.accDamage : 0;
            userLog.skillPercentage = userLog.accDamage != 0 ? userLog.skillAccDamage * 100 / userLog.accDamage : 0;


            userList[userName] = userLog;

            userLog.lastLog = logResult;
            userLog.logStr.Add(logStr);

            if (!userLog.usedSkills.ContainsKey(skillName))
                userLog.usedSkills.Add(skillName, new Log.UsedSkill());

            userLog.usedSkills[skillName].log.Add(logStr);
            userLog.usedSkills[skillName].logDamage.Add(logResult.damage);
            userLog.usedSkills[skillName].AccDamage += logResult.damage;
         
        }

        public int GetTime(Log userLog, DateTime logTime)
        {
            int newTime = userLog.time;

            if (newTime == 0)
                newTime = 1;
            else
            {
                int tSpan = (int)(logTime - userLog.lastLoggedTime).Seconds;
                if (tSpan < 5 && tSpan >= 0)
                    newTime += tSpan;
                else
                    newTime++;
            }
            return newTime;
        }

        public void GetNewAtk(Log userLog, Analyzed logResult)
        {
            int tSpan = (int)(logResult.loggedTime - userLog.lastLoggedTime).TotalSeconds;
            userLog.totalDealCount++;
            if (userLog.newAtk == 0)
            {
                userLog.newAtk++;
                if(logResult.skillName != "") userLog.skillTimes++;
                else userLog.atkTimes++;
            }
            else
            {

                if (userLog.lastLog.skillName != "" && logResult.skillName != "")
                {
                    userLog.newAtk++;
                    userLog.skillTimes++;
                    userLog.currentAtkCancel = 0;
                }
                else if ((userLog.lastLog.skillName == "" && logResult.skillName != "") || (userLog.lastLog.skillName != "" && logResult.skillName == ""))
                {
                    userLog.newAtk++;
                    if (tSpan <= 3)
                    {
                        userLog.currentAtkCancel++;
                        userLog.totalAtkCancel++;
                    }
                    else
                    {
                        userLog.currentAtkCancel = 0;
                    }
                    if (logResult.skillName == "") userLog.atkTimes++;
                    else userLog.skillTimes++;
                }
                else if (userLog.lastLog.skillName == "" && logResult.skillName == "")
                {
                    if ((logResult.loggedTime - userLog.lastLog.loggedTime).TotalSeconds > 0)
                    {
                        userLog.newAtk++;
                        userLog.atkTimes++;
                        userLog.currentAtkCancel = 0;
                    }
                }
            }

            if (userLog.maxContinuousAtkCancel < userLog.currentAtkCancel)
                userLog.maxContinuousAtkCancel = userLog.currentAtkCancel;

            userLog.atkCancelPercentage = userLog.newAtk != 0 ? (int)((float)userLog.totalAtkCancel * 100 / (float)(userLog.newAtk - 1)) : 0;
        }

        private string getUserClass(Log userLog, Analyzed logResult)
        {
            var nodes = xmlDoc.SelectNodes("/skills/skill");
            

            foreach (XmlNode node in nodes)
            {
                if (node["name"].InnerText == logResult.skillName)
                {
                    return node["class"].InnerText;
                }
            }
            
            return userLog.userClass;
        }
    }
}
