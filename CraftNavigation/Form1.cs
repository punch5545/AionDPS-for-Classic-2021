using CraftNavigation.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CraftNavigation
{
    public partial class Form1 : Form
    {
        private List<Creature> creatures = new List<Creature>();
        private List<Resource> resources = new List<Resource>();
        public Form1()
        {
            InitializeComponent();

            List<KeyValuePair<int, string>> areaCode = new List<KeyValuePair<int, string>>();
            areaCode.Add(new KeyValuePair<int, string>(2, "───용　계───"));
            areaCode.Add(new KeyValuePair<int, string>(1050, "잉기스온"));
            areaCode.Add(new KeyValuePair<int, string>(1051, "겔크마로스"));
            areaCode.Add(new KeyValuePair<int, string>(0, "───천　계───"));
            areaCode.Add(new KeyValuePair<int, string>(1004, "엘리시움"));
            areaCode.Add(new KeyValuePair<int, string>(1008, "포에타"));
            areaCode.Add(new KeyValuePair<int, string>(1002, "베르테론"));
            areaCode.Add(new KeyValuePair<int, string>(1005, "엘테넨"));
            areaCode.Add(new KeyValuePair<int, string>(1012, "인테르디카"));
            areaCode.Add(new KeyValuePair<int, string>(1013, "테오보모스"));
            areaCode.Add(new KeyValuePair<int, string>(1, "───마　계───"));
            areaCode.Add(new KeyValuePair<int, string>(1007, "판데모니움"));
            areaCode.Add(new KeyValuePair<int, string>(1006, "이스할겐"));
            areaCode.Add(new KeyValuePair<int, string>(1003, "알트가르드"));
            areaCode.Add(new KeyValuePair<int, string>(1001, "모르헤임"));
            areaCode.Add(new KeyValuePair<int, string>(1014, "벨루스란"));
            areaCode.Add(new KeyValuePair<int, string>(1015, "브루스트 호닌"));
            areaCode.Add(new KeyValuePair<int, string>(3, "───어비스───"));
            areaCode.Add(new KeyValuePair<int, string>(1010, "어비스 하층"));
            areaCode.Add(new KeyValuePair<int, string>(1009, "어비스 상층"));
            areaCode.Add(new KeyValuePair<int, string>(1011, "에레슈란타의 눈"));

            comboBox1.DataSource = areaCode;
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";

            pictureBox1.Image = getBackgroundImg("1001_768m");

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)comboBox1.SelectedValue < 1000)
                return;
            else
            {
                this.creatures.Clear();
                this.resources.Clear();

                var xmlDoc = getXml((int)comboBox1.SelectedValue);

                var areaNode = xmlDoc.SelectNodes("resultdata/areas/area");
                string mapType = radioButton1.Checked ? "mmap" : "smap";

                pictureBox1.Image = getBackgroundImg(areaNode[0][mapType].InnerText);

                var creatureNode = xmlDoc.SelectNodes("resultdata/creatures/creature");
                var resourceNode = xmlDoc.SelectNodes("resultdata/resources/resource");

                foreach(XmlNode cr in creatureNode)
                {
                    var creature = new Creature();
                    creature.code = cr["code"].Value;
                    creature.areaCode = comboBox1.SelectedValue.ToString();
                    creature.name = cr["name"].Value;
                    creature.type = cr["type"].Value;
                    creature.mClass = cr["mclass"].Value;
                    creature.sClass = cr["sclass"].Value;
                    creature.monGrade = cr["mongrade"].Value;
                    creature.monGradeText = cr["mongradetext"].Value;
                    creature.level = int.Parse(cr["level"].Value);
                }
            }
        }

        private XmlDocument getXml(int areaKey)
        {
            string skillsDB = string.Empty;
            //MessageBox.Show($"CraftNavigation.Data.XML.{areaKey}.xml");
            using (Stream stream = this.GetType().Assembly.GetManifestResourceStream($"CraftNavigation.Data.XML.{areaKey}.xml"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    skillsDB = sr.ReadToEnd();
                }
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(skillsDB);

            return xmlDoc;
        }
        private Image getBackgroundImg(string areaKey)
        {
            Image image;
            string skillsDB = string.Empty;
            using (Stream stream = this.GetType().Assembly.GetManifestResourceStream($"CraftNavigation.Data.Images.{areaKey}.jpg"))
            {
                image = Image.FromStream(stream);
            }

            return image;
        }

    }
}
