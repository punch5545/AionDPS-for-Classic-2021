﻿using System;
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
            Analyzed lastDeal = new Analyzed();

            string userName = logResult.userName;
            if (userName == "" | userName == string.Empty | userName == null)
                return;

            Log userLog;

            if (!userList.ContainsKey(userName))
            {
                userLog = new Log(userName);
                userList.Add(userName, userLog);
            }
            
            userLog = userList[userName];

            if(userLog.lastLog.userName == "" || userLog.lastLog.userName == null || userLog.lastLog.userName == string.Empty)
            {
                userLog.lastLog.userName = userName;
                userLog.lastLog.skillName = "";
            }

            GetNewAtk(userLog, logResult);

            userLog.accDamage = userLog.accDamage + logResult.damage;
            userLog.time = GetTime(userLog, logResult.loggedTime);
            userLog.DPS = userLog.accDamage / userLog.time;
            userLog.lastLoggedTime = logResult.loggedTime;
            userLog.userClass = getUserClass(userLog, logResult);

            userList[userName] = userLog;

            userLog.lastLog = logResult;
        }

        public int GetTime(Log userLog, DateTime logTime)
        {
            int newTime = userLog.time;

            if (newTime == 0)
                newTime = 1;
            else
            {
                if ((int)(logTime - userLog.lastLoggedTime).Seconds < 5)
                    newTime += (int)(logTime - userLog.lastLoggedTime).Seconds;
                else
                    newTime += 1;
            }

            
            return newTime;
        }

        public void GetNewAtk(Log userLog, Analyzed logResult)
        {
            if(userLog.newAtk == 0)
            {
                userLog.newAtk++;
                if(logResult.skillName != "") userLog.skillTimes++;
                else userLog.atkTimes++;
            }
            else
            {
                if ((int)(userLog.lastLog.damage / 10) != logResult.damage && userLog.lastLog.damage != logResult.damage)
                {
                    if (userLog.lastLog.skillName != "" && logResult.skillName != "")
                    {
                        userLog.newAtk++;
                        userLog.skillTimes++;
                    }
                    else if ((userLog.lastLog.skillName == "" && logResult.skillName != "") || (userLog.lastLog.skillName != "" && logResult.skillName == ""))
                    {
                        userLog.newAtk++;
                        if (logResult.skillName != "") userLog.skillTimes++;
                        else userLog.atkTimes++;
                    }
                    else if (userLog.lastLog.skillName == "" && logResult.skillName == "")
                    {
                        if ((logResult.loggedTime - userLog.lastLog.loggedTime).TotalSeconds > 0)
                        {
                            userLog.newAtk++;
                            userLog.atkTimes++;
                        }
                    }
                }
            }
        }

        private string getUserClass(Log userLog, Analyzed logResult)
        {
            var nodes = xmlDoc.SelectNodes("/skills/skill");
            
            if(logResult.skillName != null && userLog.tryDetectClass < 3)
            {
                foreach (XmlNode node in nodes)
                {
                    if (node["name"].InnerText == logResult.skillName)
                    {
                        userLog.tryDetectClass += 1;
                        return node["class"].InnerText;
                    }
                }
            }

            return userLog.userClass;

        }
    }
}