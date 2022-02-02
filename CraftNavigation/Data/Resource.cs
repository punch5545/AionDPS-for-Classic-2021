using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftNavigation.Data
{
    class Resource
    {
        public int code;
        public int areaCode;
        public string name;
        public string type;
        public string mClass;
        public int level;
        public List<(int, int)> realCoords;
        public List<(int, int)> mapCoords;
        public int count;
        public List<KeyValuePair<int, string>> harvests;

        public void addRealCoords(int x, int y)
        {
            this.realCoords.Add((x, y));
        }

        public void addMapCoords(int x, int y)
        {
            this.mapCoords.Add((x, y));
        }

        public void addHarvests(int code, string name)
        {
            harvests.Add(new KeyValuePair<int, string>(code, name));
        }
    }
}
