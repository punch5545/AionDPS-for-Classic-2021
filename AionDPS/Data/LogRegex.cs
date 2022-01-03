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
    }

    class LogRegex : SingletonBase<LogRegex>
    {
        public static Analyzed getLogResult(string log, string hittedObjectName = @"(?<hittedObjectName>[가-힣0-9\s]+)")
        {
            Regex rx = new Regex(@"(?<loggedTime>[0-9]{4}.[0-9]{2}.[0-9]{2} [0-9]{2}:[0-9]{2}:[0-9]{2}) : (?<isCritical>치명타! )?((?<userName>[가-힣A-Za-z]+)(가|이) )?((?<skillName>[가-힣\s]+ (I)?(I)?(V)?(I)?(I)?)을 사용해 )?" + $@"(?<hittedObjectName>{hittedObjectName})" + @"에게 (?<damage>[0-9,]+)의 대미지를 (줬습니다.)?(주고 [가-힣\s]+ 효과가 발생)?");
            Analyzed analyzed = new Analyzed();

            if (rx.IsMatch(log))
            {
                Match matched = rx.Match(log);

                analyzed.loggedTime = DateTime.ParseExact(matched.Groups["loggedTime"].Value, "yyyy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture);
                analyzed.userName = matched.Groups["userName"].Value.Length > 0 ? matched.Groups["userName"].Value : "<당신>";
                analyzed.skillName = matched.Groups["skillName"].Value.Length > 1 ? matched.Groups["skillName"].Value : "";
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
