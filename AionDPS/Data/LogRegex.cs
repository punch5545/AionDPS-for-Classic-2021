using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace AionDPS
{
    public struct Analyzed
    {
        public DateTime loggedTime;
        public string userName;
        public string skillName;
        public string hittedObjectName;
        public int damage;
        public bool isCritical;
        public bool isCastSpd;
    }

    class LogRegex : SingletonBase<LogRegex>
    {
        private static string loggedTimestamp = @"(?<loggedTime>[0-9]{4}.[0-9]{2}.[0-9]{2} [0-9]{2}:[0-9]{2}:[0-9]{2}) : ";
        public static Analyzed getLogResult(string log, string hittedObjectName = @"[가-힣0-9A-Za-z\s]+")
        {
            //2022.01.02 22:10:50 : 꽁떡이 신속의 주문 I을 사용해 시전속도가 변동됐습니다. 
            //2022.01.02 22:10:50 : 꽁떡이 신속의 주문 I을 사용해 버본의 시전속도를 변경했습니다. 

            Regex rx = new Regex(loggedTimestamp + @"(?<isCritical>치명타! )?((?<userName>[가-힣A-Za-z\s]+)(가|이) )?((?<skillName>[가-힣\s]+ (I)?(I)?(V)?(I)?(I)?)을 사용해 )?" + $@"(?<hittedObjectName>{hittedObjectName})" + @"에게 (?<damage>[0-9,]+)의 (치명적인 )?대미지를 ");
            Regex rx2 = new Regex(loggedTimestamp + @"((?<userName>[가-힣A-Za-z]+)(가|이) )?신속의 주문 I을 사용해 ((?<targetName>[가-힣A-Za-z]+)의 )?시전속도(가|를) (변동됐습니다|변경했습니다)");

            Analyzed analyzed = new Analyzed();

            if (rx2.IsMatch(log))
            {
                //Console.WriteLine(log);
                Match matched = rx2.Match(log);
                string userName = matched.Groups["userName"].Value;
                string targetName = matched.Groups["targetName"].Value;
                //Console.WriteLine(matched.Groups["loggedTime"].Value);

                analyzed.loggedTime = DateTime.ParseExact(matched.Groups["loggedTime"].Value, "yyyy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
                int loggedHour = analyzed.loggedTime.Hour;

                if (loggedHour == 19 || loggedHour == 22)
                {
                    analyzed.userName = userName;
                    analyzed.hittedObjectName = targetName;
                    analyzed.isCastSpd = true;
                }
                else
                {
                    analyzed.userName = null;
                    analyzed.hittedObjectName = null;
                    analyzed.isCastSpd = false;
                }

                return analyzed;
            }

            else if (rx.IsMatch(log))
            {
                Match matched = rx.Match(log);

                string userName = matched.Groups["userName"].Value;
                string skillName = matched.Groups["skillName"].Value;
                if (userName == "")
                    userName = Main.form.textBox1.Text;
                else if (userName.IndexOf("의 정령") != -1 || userName.IndexOf("의 기운") != -1)
                    userName = null;
                else if (userName.IndexOf(' ') != -1 && skillName.IndexOf(userName) != -1)
                    userName = null;
                else if (userName == "빙판" && skillName.StartsWith("빙판") && skillName.EndsWith("효과"))
                    userName = null;
                else if ((userName.IndexOf(" ")) != -1)
                    userName = null;

                analyzed.loggedTime = DateTime.ParseExact(matched.Groups["loggedTime"].Value, "yyyy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
                analyzed.userName = userName;
                analyzed.skillName = matched.Groups["skillName"].Value.Length > 0 ? matched.Groups["skillName"].Value : "";
                analyzed.hittedObjectName = matched.Groups["hittedObjectName"].Value;
                analyzed.damage = int.Parse(matched.Groups["damage"].Value, NumberStyles.AllowThousands);
                analyzed.isCritical = matched.Groups["isCritical"].Value == "치명타! " ? true : false;
            }

            return analyzed;
        }

        public static string getUserName(string log)
        {
            return getLogResult(log).userName;
        }
    }

}
