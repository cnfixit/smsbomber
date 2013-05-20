using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.Net;
using System.IO;

namespace smsbomber
{
    public partial class Main : Form
    {
        private bool flag= false;
        private List<target> list = new List<target>();
        private string file = Application.StartupPath + @"\config.xml";

        ManualResetEvent stop = new ManualResetEvent(false);

        public Main()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void ResourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.ShowDialog();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if(this.tbxPhone.Text.Length == 0)
            {
                MessageBox.Show("输入不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!flag)
            {
                //start
                stop.Reset();
                this.start();
                this.btngo.Text = "停止";
            }
            else
            {
                //stop
                stop.Set();
                this.btngo.Text = "开始";
            }
            flag = !flag;
        }

        private void start()
        {
            for(int i = 0;i < this.list.Count;i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(procedure));
                t.Start(list[i]);
            }
        }


        private void procedure(object obj)
        {


            target tar = obj as target;

            int success = 0;
            int fail = 0;
            int cnt = tar.Interval;
            int last = tar.Interval;

            HttpWebResponse response = null; ;
            StreamReader reader = null;
            Uri uri = null;
            while (!stop.WaitOne(1000,true))
            {

                if(cnt--  ==  tar.Interval)
                {
                    try
                    {
                        //if(tar.Method.Equals("GET"))
                        //{
                        //    uri = new Uri(tar.Url.AbsoluteUri.Replace("%25mobile%25", this.tbxPhone.Text.Trim()));
                        //    tar.Url = uri;
                        //}
                        //HttpWebRequest req = (HttpWebRequest)WebRequest.Create(tar.Url);
                        //req.Accept = "*/*";
                        //req.Referer = tar.Url.Host;
                        //req.Method = tar.Method;
                        //if(tar.Method.Equals("POST"))
                        //{
                        //    req.ContentType = "application/x-www-form-urlencoded";
                        //    byte[] buffer = Encoding.UTF8.GetBytes(tar.FormName + "=" + this.tbxPhone.Text.Trim());
                        //    req.ContentLength = buffer.Length;
                        //    System.IO.Stream stream = null;
                        //    try
                        //    {
                        //        stream = req.GetRequestStream();
                        //        stream.Write(buffer, 0, buffer.Length);
                        //    }
                        //    catch (Exception e)
                        //    {
                        //        Log.LogError(e, "");
                        //    }
                        //    finally
                        //    {
                        //        if (stream != null) { stream.Close(); }
                        //    }
                        //}


                        //response = (HttpWebResponse)req.GetResponse();

                        //reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

                        //reader.ReadToEnd();


                    }
                    catch (Exception e)
                    {
                        Log.LogError(e, "");
                    }
                    finally
                    {
                        if (reader != null) { reader.Close(); }
                        int i = new Random().Next(1, 10);
                        System.Diagnostics.Debug.Print(i.ToString());
                        if (i == 5)//response.StatusCode == HttpStatusCode.OK
                        {
                            this.LVReort.Items[tar.Index].SubItems[3].Text = (++success).ToString();

                        }
                        else
                            this.LVReort.Items[tar.Index].SubItems[4].Text = (++fail).ToString();
                    }
                  
                }
                else
                {
                    this.LVReort.Items[tar.Index].SubItems[2].Text = (--last).ToString();
                    if(last == 0)
                    {
                        cnt = tar.Interval;
                        last = tar.Interval;
                        this.LVReort.Items[tar.Index].SubItems[2].Text = (last).ToString();
                    }
                }
                
                
               
            }
         

        }



 


        private void Main_Load(object sender, EventArgs e)
        {
            this.loadconfig();
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
                this.LVReort.Items.Clear();

                foreach (XmlNode xn in xnl)
                {
                    string[] items = { xn.ChildNodes[0].InnerText, xn.ChildNodes[1].InnerText, xn.ChildNodes[1].InnerText, "0", "0" };
                    this.LVReort.Items.Add(new ListViewItem(items));

                    this.list.Add(new target(new Uri(xn.ChildNodes[0].InnerText), Convert.ToInt32(xn.ChildNodes[1].InnerText),xn.ChildNodes[2].InnerText,xn.ChildNodes[3].InnerText,this.LVReort.Items.Count - 1));
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

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop.Set();
        }

    }

    public class target
    {
        public target()
        { }

        public target(Uri url, int interval,string method,string formname,int index)
        {
            this._Url = url;
            this._Interval = interval;
            this._Method = method;
            this._FormName = formname;
            this._Index = index;
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

        int _Index;

        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }
    }
}
