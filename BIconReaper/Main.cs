using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;
using BIconReaper.Model;
using System.Net;
using BIconReaper.Util;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace BIconReaper
{
    public partial class Main : Form
    {
        string path = Directory.GetCurrentDirectory();

        public Main()
        {
            InitializeComponent();
        }

        private void btnReaper_Click(object sender, EventArgs e)
        {
            btnReaper.Enabled = false;
            Task reaper = new Task(Reaper);
            reaper.Start();
        }

        private void Reaper()
        {
            string json = @"http://www.bilibili.com/index/index-icon.json";

            try
            {
                HttpWebRequest myHttpWebRequest = WebRequest.Create(json) as HttpWebRequest;
                myHttpWebRequest.KeepAlive = false;
                myHttpWebRequest.AllowAutoRedirect = false;
                myHttpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 4.0.30319)";
                myHttpWebRequest.Timeout = 3000;
                myHttpWebRequest.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

                using (HttpWebResponse res = (HttpWebResponse)myHttpWebRequest.GetResponse())
                {
                    using (MemoryStream ms = gzip.DecompressStream(res.GetResponseStream()))
                    {
                        using (StreamReader sr = new StreamReader(ms, Encoding.UTF8))
                        {
                            json = sr.ReadToEnd();
                            sr.Close();
                            ms.Close();
                            res.Close();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                this.Invoke((EventHandler)delegate
                {
                    loglistBox.Items.Add("错误：" + e.Message); //跨线程
                    loglistBox.SelectedIndex = loglistBox.Items.Count - 1;
                    loglistBox.SelectedIndex = -1;
                    btnReaper.Enabled = true;
                });
                return;
            }

            JObject jsonarr = (JObject)JsonConvert.DeserializeObject(json);

            var fixlist = jsonarr["fix"].ToString();
            List<span> spanlist = JsonConvert.DeserializeObject<List<span>>(fixlist);

            if (Directory.Exists(path + "\\icons") == false)
            {
                Directory.CreateDirectory(path + "\\icons");
            }

            this.Invoke((EventHandler)delegate
            {
                progressBar.Maximum = spanlist.Count;  //跨线程
                loglistBox.Items.Add("提示：获取到" + spanlist.Count + "可下载的GIF图片");  //跨线程
                loglistBox.SelectedIndex = loglistBox.Items.Count - 1;
                loglistBox.SelectedIndex = -1;
            });

            try
            {
                foreach (var item in spanlist)
                {
                    WebClient client = new WebClient();
                    string filename = Path.GetFileName(item.Title) + ".gif";
                    string filepath = path + "//icons//" + filename;
                    int i = 2;
                    while (File.Exists(filepath))
                    {
                        filename = Path.GetFileName(item.Title) + i + ".gif";
                        filepath = path + "//icons//" + filename;
                        ++i;
                    }

                    client.DownloadFile(item.Icon, filepath);

                    this.Invoke((EventHandler)delegate
                    {
                        ++progressBar.Value;  //跨线程
                        loglistBox.Items.Add("已下载：" + item.Title + ".gif");  //跨线程
                        loglistBox.SelectedIndex = loglistBox.Items.Count - 1;
                        loglistBox.SelectedIndex = -1;
                    });
                }
            }
            catch (Exception e)
            {
                this.Invoke((EventHandler)delegate
                {
                    loglistBox.Items.Add("错误：" + e.Message); //跨线程
                    loglistBox.SelectedIndex = loglistBox.Items.Count - 1;
                    loglistBox.SelectedIndex = -1;
                });
            }

            this.Invoke((EventHandler)delegate
            {
                loglistBox.Items.Add("提示：下载完成，已成功下载" + spanlist.Count + "个GIF图片"); //跨线程
                loglistBox.SelectedIndex = loglistBox.Items.Count - 1;
                loglistBox.SelectedIndex = -1;
                btnReaper.Enabled = true;
            });
        }
    }
}
