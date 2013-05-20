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
    public partial class Main : Form
    {
        private bool flag= false;
        private List<target> list = new List<target>();
        private string file = Application.StartupPath + @"\config.xml";

        public Main()
        {
            InitializeComponent();
        }

        private void ResourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.ShowDialog();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if(
            if (!flag)
            {
                //start
                this.start();
                this.btngo.Text = "停止";
            }
            else
            {
                //stop
                this.btngo.Text = "开始";
            }
            flag = !flag;
        }

        private void start()
        {
            this.loadconfig();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void loadconfig()
        {
            try
            {
                XmlDocument xml = new XmlDocument();

                xml.Load(file);

                XmlNodeList xnl = xml.SelectNodes(@"/resource/target");

                if (xnl == null)
                    return;

                this.list.Clear();
                foreach (XmlNode xn in xnl)
                {
                    this.list.Add(new target(new Uri(xn.ChildNodes[0].InnerText), Convert.ToInt32(xn.ChildNodes[1].InnerText),xn.ChildNodes[2].InnerText,xn.ChildNodes[3].InnerText));
                }
            }
            catch (UriFormatException)
            {
                MessageBox.Show("配置文件中包含不规范的url，需要重新设置", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }

    public class target
    {
        public target()
        { }

        public target(Uri url, int interval,string method,string formname)
        {
            this._Url = url;
            this._Interval = interval;
            this._Method = method;
            this._FormName = formname;
        }


        Uri _Url;

        public Uri Url
        {
            get { return _Url; }
            set { _Url = value; }
        }
        int _Interval;

        public int Interval
        {
            get { return _Interval; }
            set { _Interval = value; }
        }

        string _Method;

        public string Method
        {
            get { return _Method; }
            set { _Method = value; }
        }

        string _FormName;

        public string FormName
        {
            get { return _FormName; }
            set { _FormName = value; }
        }
    }
}
