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
        public List<string> logStr = new List<string>();
        public int DPS = 0;
        public int accDamage = 0;
        public int time = 0;
        public int atkCancelPercentage = 0;
        public int skillCriticalPercentage = 0;
        public int skillCriticalTimes = 0;
        public int criticalTimes = 0;
        public int newAtk = 0;
        public int avgAtkDamage = 0;
        public int avgSkillDamage = 0;
        public int MaxDamage = 0;
        public int atkTimes = 0;
        public int skillTimes = 0;
        public int maxContinuousAtkCancel = 0;
        public int currentAtkCancel = 0;
        public int totalAtkCancel = 0;
        public int atkPercentage = 0;
        public int skillPercentage = 0;
        public int atkAccDamage = 0;
        public int skillAccDamage = 0;
        public int tryDetectClass = 0;
        public int totalDealCount = 0;
        public int castSpeedCount = 0;
        public bool rage = false;
        public int rageDamage = 0;

        public DateTime lastLoggedTime;

        public Analyzed lastLog = new Analyzed();

        public class UsedSkill
        {
            public List<string> log = new List<string>();
            public List<int> logDamage = new List<int>();
            public int AccDamage = 0;
        }

        public Dictionary<string, UsedSkill> usedSkills = new Dictionary<string, UsedSkill>();

        public Log(string name)
        {
            this.userName = name;
        }
    }
}
