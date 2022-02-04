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
        public bool rage;
        public int rageDamage;
    }

    class LogRegex : SingletonBase<LogRegex>
    {
        private static string loggedTimestamp = @"(?<loggedTime>[0-9]{4}.[0-9]{2}.[0-9]{2} [0-9]{2}:[0-9]{2}:[0-9]{2}) : ";
        public static Analyzed getLogResult(string log, string hittedObjectName = @"[가-힣0-9A-Za-z\s]+")
        {
            Regex rx = new Regex(loggedTimestamp + @"(?<isCritical>치명타! )?((?<userName>[가-힣A-Za-z\s]+)(가|이) )?((?<skillName>[가-힣\s]+ (I)?(I)?(V)?(I)?(I)?)을 사용해 )?" + $@"(?<hittedObjectName>{hittedObjectName})" + @"(에게|이) (?<damage>[0-9,]+)의 (치명적인 )?대미지를 (받고|받았|줬습|주고)");
            Regex rx2 = new Regex(loggedTimestamp + @"((?<userName>[가-힣A-Za-z]+)(가|이) )?(사용한 )?신속의 주문 I(을 사용해|의 영향으로) ((?<targetName>[가-힣A-Za-z]+)의 )?시전속도(가|를) (변동됐습니다|변경했습니다)");
            Regex rx3 = new Regex(loggedTimestamp + $@"{hittedObjectName}이 신장의 격노를 사용해 ((?<targetName>[가-힣A-Za-z]+)에게) (?<damage>[0-9,]+)의 대미지를 줬습니다.");

            Analyzed analyzed = new Analyzed();

            if(rx3.IsMatch(log) && Main.form.checkBox2.Checked)
            {
                Match matched = rx3.Match(log);

                string userName = matched.Groups["targetName"].Value;
                string damage = matched.Groups["damage"].Value;
                analyzed.userName = userName;
                analyzed.rage = true;
                analyzed.rageDamage = int.Parse(damage, NumberStyles.AllowThousands);

                analyzed.loggedTime = DateTime.ParseExact(matched.Groups["loggedTime"].Value, "yyyy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
            }
            else if (rx2.IsMatch(log) && Main.form.checkBox1.Checked)
            {
                Match matched = rx2.Match(log);
                string userName = matched.Groups["userName"].Value;
                string targetName = matched.Groups["targetName"].Value;

                analyzed.loggedTime = DateTime.ParseExact(matched.Groups["loggedTime"].Value, "yyyy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
                int loggedHour = analyzed.loggedTime.Hour;

                if (targetName == "")
                {
                    targetName = log.Contains("사용한") ? Main.form.textBox1.Text : "";
                }

                if ((Main.form.fortressComboBox.Text == "어비스 상층" && loggedHour == 19) || 
                    (Main.form.fortressComboBox.Text != "어비스 상층" && loggedHour == 22))
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
                analyzed.rage = false;
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
                analyzed.isCritical = matched.Groups["isCritical"].Value.Contains("치명타!");
                analyzed.rage = false;

            }

            return analyzed;
        }

        public static string getUserName(string log)
        {
            return getLogResult(log).userName;
        }
    }

}
