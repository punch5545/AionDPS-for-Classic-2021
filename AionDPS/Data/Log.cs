using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AionDPS
{
    class Log
    {
        public string userName = "";
        public string userClass = "";
        public int DPS = 0;
        public int accDamage = 0;
        public int time = 0;
        public int atkCancelPercentage = 0;
        public int skillCriticalPercentage = 0;
        public int newAtk = 0;
        public int avgAtkDamage = 0;
        public int avgSkillDamage = 0;
        public int MaxDamage = 0;
        public int atkTimes = 0;
        public int skillTimes = 0;
        public int continuousAtkCancel = 0;
        public int atkPercentage = 0;
        public int skillPercentage = 0;
        public int atkAccDamage = 0;
        public int skillAccDamage = 0;
        public int tryDetectClass = 0;

        public DateTime lastLoggedTime;

        public Analyzed lastLog = new Analyzed();

        public struct UsedSkill
        {
            public string SkillName;
            public string Log;
            public int Damage;
        }

        public List<string> logs = new List<string>();
        public List<UsedSkill> usedSkills = new List<UsedSkill>();

        public Log(string name)
        {
            this.userName = name;
        }

        public List<string> getLogs(string skillName = "")
        {
            if(skillName == "")
            {
                return logs;
            }
            else
            {
                return logs.FindAll(str => str.Contains(skillName));
            }
        }
    }
}
