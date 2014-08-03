using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QVN
{
    public partial class Form1 : Form
    {
        List<RssInfo> rssInfos = new List<RssInfo>();
        List<Label> labels = new List<Label>();
        private List<RSS> rsss = new List<RSS>();
        RSSRead rssRead = new RSSRead();
        List<Label> DeafaulLabels = new List<Label>();
        List<NumericUpDown> DeafaulNumerics = new List<NumericUpDown>();
        private int lastIndex = 0;
        private int rssIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DeafaulLabels.Add(lblName);
            DeafaulLabels.Add(lblCategory);
            DeafaulLabels.Add(lbl1);
            DeafaulLabels.Add(lbl2);
            DeafaulLabels.Add(lblSize);
            DeafaulLabels.Add(lblS1);
            DeafaulLabels.Add(lblSpeed);
            DeafaulLabels.Add(lblS2);
            DeafaulLabels.Add(lblOpacity);

            DeafaulNumerics.Add(nmrSize);
            DeafaulNumerics.Add(nmrSpeed);
            DeafaulNumerics.Add(nmrOpacity);

            SetLabelNumeric();

            SetForm(this);

            rsss = SetRssNews();

            //demo();

            tmrRun.Start();
        }

        public void demo()
        {
            RSS rss = new RSS
                          {
                              Link = "123",
                              NewspaperName = "123",
                              Category = "asd"
                          };
            rsss.Add(rss);

            RssInfo rssInfo = new RssInfo
            {
                Title = "Bản tin   ",
                Description = "Bản tin này",
                Image = "http",
                Link = "http",
                News = "ád",
                PubDate = "20/08/2014"
            };
            for (int i = 0; i < 3; i++)
            {
                rssInfos.Add(rssInfo);
            }
        }

        public List<RSS> SetRssNews()
        {
            List<RSS> rssTemps = new List<RSS>();
            string[] lines = System.IO.File.ReadAllLines(CONST.PATHRSSFILE);
            foreach (string line in lines)
            {
                string link = "";
                string name = "";
                string cat = "";
                string[] col = line.Split('/');
                link = line.Trim();
                name = col[2].Replace("www.", "");
                cat = col[col.Length - 1].Replace(".rss", "");
                RSS rss = new RSS
                {
                    Link = link,
                    NewspaperName = name,
                    Category = cat
                };
                rssTemps.Add(rss);
            }
            return rssTemps;
        }

        public Label SetLabel(RssInfo rssInfo, int index)
        {
            Label labelTemp = new Label();
            labelTemp.Font = new Font(CONST.FONTNAME, CONST.FONTSIZE);
            labelTemp.Text = " ● " + rssInfo.Title;
            toolTip1.SetToolTip(labelTemp, ContentOfOneTitle(index));
            //labelTemp.BackColor = Color.Blue;
            labelTemp.Tag = index;
            labelTemp.AutoSize = true;
            pnlMain.Controls.Add(labelTemp);
            //Gọi sự kiện click label
            labelTemp.Click += new EventHandler(Label_Click);
            //Gọi sự kiện để chuột vào label
            labelTemp.MouseHover += new EventHandler(Label_MouseHover);
            //Gọi sự kiện chuột ra khỏi label
            labelTemp.MouseLeave += new EventHandler(Label_MouseLeave);
            return labelTemp;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            // Lấy id của label
            int id = (int)((Label)sender).Tag;
            var wbf = new WebBrowserForm(rssInfos[id].Link, rsss[rssIndex].NewspaperName, rsss[rssIndex].Category);
            //Kiểm tra xem form web đã được mở hay chưa
            if ((Application.OpenForms["WebBrowserForm"] as WebBrowserForm) != null)
            {
                //Vào được đây tức là có một form đang mở. Cần đóng nó lại để mở ra
                //Close form web hiện thời lại
                (Application.OpenForms["WebBrowserForm"] as WebBrowserForm).Close();
            }
            wbf.Show();
        }
        private void Label_MouseHover(object sender, EventArgs e)
        {
            //Với mỗi label được gọi, ta có thể làm gì tùy thích
            int id = (int)((Label)sender).Tag;
            int i = 0;
            while ((int)labels[i].Tag != id)
            {
                i++;
            }
            labels[i].BackColor = Color.Red;
            labels[i].ForeColor = Color.Yellow;
            tmrRun.Enabled = false;
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            //Với mỗi label được gọi, ta có thể làm gì tùy thích
            int id = (int)((Label)sender).Tag;
            int i = 0;
            while ((int)labels[i].Tag != id)
            {
                i++;
            }
            labels[i].BackColor = SystemColors.Control;
            labels[i].ForeColor = Color.Gray;
            tmrRun.Enabled = true;
        }

        public void RunNews()
        {
            if (labels.Count > 0)
            {
                //Dịch chuyển tất cả label trong labels dịch tới
                foreach (var label in labels)
                {
                    label.Location = new Point(label.Left - CONST.STEPPIXEL, label.Top);
                }
                //Phần tử cuối cùng trong đám labels
                Label labe1 = labels[labels.Count - 1];
                //Nếu labels cuối xuất hiện hoàn toàn trên panel
                if (labe1.Left + labe1.Width <= pnlMain.Left + pnlMain.Width)
                {
                    //Nếu nguồn cấp tin vẫn còn tin để hiện
                    if (lastIndex < rssInfos.Count - 1)
                    {
                        lastIndex++;
                        labels.Add(SetLabel(rssInfos[lastIndex], lastIndex));
                        Label label2 = labels[labels.Count - 2];
                        labels[labels.Count - 1].Location = new Point(label2.Left + label2.Width, label2.Top);
                    }
                }
                //Nếu đuôi label đi tới hết lbl2.
                if (labels[0].Left + labels[0].Width < lbl2.Left + lbl2.Width)
                {
                    labels[0].Dispose();
                    labels.RemoveAt(0);
                }
            }
            else
            {
                tmrRun.Enabled = false;
                lastIndex = 0;
                rssIndex++;
                if (rssIndex == rsss.Count)
                {
                    rssIndex = 0;
                }
                //Chuyển sang rssinfo khác, trong list rsss
                rssInfos = rssRead.GetListRSS(rsss[rssIndex].Link);
                if (rssInfos == null)
                {
                    RssInfo rssInfo = new RssInfo
                                          {
                                              Title = "Không tải được tin tức. Kiểm tra lại đường truyền mạng.",
                                              Description = "Có thể mạng nhà bạn có vấn đề hoặc Server của trang tin tức đang có sự cố",
                                              Link = "",
                                              Image = "",
                                              PubDate = DateTime.Now.ToShortDateString(),
                                          };
                    rssInfos = new List<RssInfo>();
                    rssInfos.Add(rssInfo);
                }
                //Set giá trị ban đầu cho label
                labels = new List<Label>();
                labels.Add(SetLabel(rssInfos[0], 0));
                labels[0].Location = new Point(pnlMain.Left + pnlMain.Width, lblName.Top);
                lblName.Text = rsss[rssIndex].NewspaperName;
                lblCategory.Text = rsss[rssIndex].Category;
                tmrRun.Enabled = true;
            }
        }

        private void tmrRun_Tick(object sender, EventArgs e)
        {
            RunNews();
        }

        public void SetForm(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;

            int nTaskBarHeight = Screen.PrimaryScreen.Bounds.Bottom -
                                             Screen.PrimaryScreen.WorkingArea.Bottom;

            Rectangle workingArea = Screen.GetWorkingArea(frm);
            //Full man hinh, voi chieu cao
            frm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, lblName.Height);
            frm.Location = new Point(0, workingArea.Bottom - frm.Size.Height);
            frm.TopMost = true;
            frm.Opacity = (double)CONST.OPACITY / 100;

            pnlSetting.Size = new Size(pnlMain.Width, pnlMain.Height);
        }





        /// <summary>
        /// Tạo nội dung cho một tooltip dựa vào tiêu để để gắn vào trong tooltip
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string ContentOfOneTitle(int index)
        {
            string content = "";
            string title = rssInfos[index].Title;

            string descrition = HtmlRemoval.StripTagsCharArray(rssInfos[index].Description);
            string pubDate = rssInfos[index].PubDate;
            string link = rssInfos[index].Link;
            string image = rssInfos[index].Image;
            content = title + "\n\n" + descrition + "\n\n" + pubDate;
            return content;
        }


        private void btnSettingShow_Click(object sender, EventArgs e)
        {
            pnlSetting.Left = pnlMain.Left;
            pnlSetting.Top = pnlMain.Top;
            pnlSetting.Size = new Size(pnlMain.Width, pnlMain.Height);
            tmrRun.Enabled = false;
            pnlSetting.Visible = true;
        }

        private void btnSettingHide_Click(object sender, EventArgs e)
        {
            tmrRun.Enabled = true;
            pnlSetting.Visible = false;
        }

        //Set đống label mặc định
        public void SetLabelNumeric()
        {
            foreach (var DeafaulLabel in DeafaulLabels)
            {
                DeafaulLabel.Font = new Font(CONST.FONTNAME, CONST.FONTSIZE);
            }
            foreach (var DeafaulNumeric in DeafaulNumerics)
            {
                DeafaulNumeric.Font = new Font(CONST.FONTNAME, CONST.FONTSIZE);
            }
        }

        private void nmrSize_ValueChanged(object sender, EventArgs e)
        {
            CONST.FONTSIZE = (int)nmrSize.Value;
            SetLabelNumeric();
            SetForm(this);

            foreach (var lalel in labels)
            {
                lalel.Font = new Font(CONST.FONTNAME, CONST.FONTSIZE);
            }
        }

        private void nmrSpeed_ValueChanged(object sender, EventArgs e)
        {
            CONST.STEPPIXEL = (int)nmrSpeed.Value;
        }

        private void nmrOpacity_ValueChanged(object sender, EventArgs e)
        {
            CONST.OPACITY = (int)nmrOpacity.Value;
            SetForm(this);
        }
    }
}
