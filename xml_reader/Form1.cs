using System.Windows.Forms;
using System.Xml;

namespace xml_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("xmltext.xml");

            foreach (XmlNode xmlNode in xmlDocument.DocumentElement)
            {
                string name = xmlNode.Attributes[0].Value;
                int age = int.Parse(xmlNode["Age"].InnerText);
                bool programmist = bool.Parse(xmlNode["Programmist"].InnerText);
                listBox.Items.Add(new Employee(name, age, programmist));
            }
        }

        private void listBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
                propertyGrid.SelectedObject = listBox.SelectedItem;
        }
    }
}