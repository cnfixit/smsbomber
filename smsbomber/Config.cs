using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace smsbomber
{
    public partial class Config : Form
    {

        private string file = Application.StartupPath + @"\config.xml";

        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {

            this.cbMethod.SelectedIndex = 0;
            this.loadconfig();
           
        }

        private void loadconfig()
        {
            XmlDocument xml = new XmlDocument();

            xml.Load(file);

            XmlNodeList xnl = xml.SelectNodes(@"/resource/target");

            if (xnl == null)
                return;

            this.LVResource.Items.Clear();

            foreach (XmlNode xn in xnl)
            {
                string[] items = { xn.ChildNodes[0].InnerText, xn.ChildNodes[1].InnerText, xn.ChildNodes[2].InnerText, xn.ChildNodes[3].InnerText };
                this.LVResource.Items.Add(new ListViewItem(items));
            }       
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.tbxURL.Text.Length == 0 || this.tbxInterval.Text.Length == 0)
            {
                MessageBox.Show("输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int i = 0;
            if (!int.TryParse(this.tbxInterval.Text.Trim(), out i))
            {
                MessageBox.Show("输入错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            XmlDocument xml = new XmlDocument();
            xml.Load(file);

            XmlNode xn = xml.SelectSingleNode(@"/resource");

            XmlNodeList xnl = xml.SelectNodes(@"/resource/target");

            foreach (XmlNode xntmp in xnl)
            {
                if (xntmp.FirstChild.InnerText == this.tbxURL.Text.Trim())
                    return;
            }

            
            if (xn != null)
            {
                
                XmlElement xe = xml.CreateElement("target");
                xn.AppendChild(xe);

                XmlElement xe1 = xml.CreateElement("url");
                xe1.InnerText = this.tbxURL.Text.Trim();
                xe.AppendChild(xe1);

                XmlElement xe2 = xml.CreateElement("interval");
                xe2.InnerText = this.tbxInterval.Text.Trim();
                xe.AppendChild(xe2);

                XmlElement xe3= xml.CreateElement("method");
                xe3.InnerText = this.cbMethod.SelectedItem.ToString();
                xe.AppendChild(xe3);

                if (this.cbMethod.SelectedIndex == 0)
                {
                    XmlElement xe4 = xml.CreateElement("formname");
                    xe4.InnerText = "N/A";
                    xe.AppendChild(xe4);
                }
                else
                {
                    XmlElement xe4 = xml.CreateElement("formname");
                    xe4.InnerText = this.tbxform.Text.Trim();
                    xe.AppendChild(xe4);
                }
                xml.Save(file);
            }

            this.loadconfig();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.LVResource.SelectedItems.Count == 0)
                return;

            XmlDocument xml = new XmlDocument();

            xml.Load(file);

            XmlNode xn = xml.SelectSingleNode("/resource");
            XmlNodeList xnl = null;

            foreach (ListViewItem lvi in this.LVResource.SelectedItems)
            {
                this.LVResource.Items.Remove(lvi);
                xnl = xml.SelectNodes(@"/resource/target");
                foreach (XmlNode xntmp in xnl)
                {
                    if (xntmp.FirstChild.InnerText == lvi.SubItems[0].Text)
                        xn.RemoveChild(xntmp);
                }
            }

            xml.Save(file);
        }

        private void cbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMethod.SelectedIndex == 0)
            {
                this.label5.Visible = false;
                this.tbxform.Visible = false;
            }
            else
            {
                this.label5.Visible = true;
                this.tbxform.Visible = true;
            }
        }
    }
}
