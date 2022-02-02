using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftNavigation.Data
{
    class Creature
    {
        public string code;
        public string areaCode;
        public string name;
        public string type;
        public string mClass;
        public string sClass;
        public string monGrade;
        public string monGradeText;
        public int level;
        public List<(int, int)> realCoords;
        public List<(int, int)> mapCoords;
        public string aggressive;
        public string description;

        public void addRealCoords(int x, int y)
        {
            this.realCoords.Add((x, y));
        }

        public void addMapCoords(int x, int y)
        {
            this.mapCoords.Add((x, y));
        }
    }
}
