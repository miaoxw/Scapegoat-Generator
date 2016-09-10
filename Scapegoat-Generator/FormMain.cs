using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Scapegoat_Generator
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void textBoxQQ_TextChanged(object sender,EventArgs e)
        {
            if(!textBoxQQ.Text.Equals(""))
            {
                long temp;
                if(!long.TryParse(textBoxQQ.Text,out temp))
                {
                    errorProvider.SetError(textBoxQQ,"QQ号不正确");
                    buttonGenerate.Enabled = false;
                }
                else
                {
                    errorProvider.Clear();
                    buttonGenerate.Enabled = true;
                }
            }
            else
            {
                errorProvider.Clear();
                buttonGenerate.Enabled = false;
            }
        }

        private async void buttonGenerate_Click(object sender,EventArgs e)
        {
            labelHint.Text = "背锅中……";
            labelHint.Visible = true;

            long QQNumber = long.Parse(textBoxQQ.Text);

            pictureBoxResult.Image = Properties.Resources.background.Clone() as Bitmap;
            Graphics newGraphic = Graphics.FromImage(pictureBoxResult.Image);

            long currentTimestamp = DateTime.UtcNow.ToLocalTime().Ticks - new DateTime(1970,1,1,0,0,0).Ticks;
            String url = "http://q2.qlogo.cn/headimg_dl?bs=qq&dst_uin=" + QQNumber.ToString() + "&spec=100&times=" + currentTimestamp / 1000;
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Timeout = 20000;
            HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;
            Stream headerStream = response.GetResponseStream();

            Brush backgroundBrush = new SolidBrush(Color.White);
            newGraphic.FillRectangle(backgroundBrush,new Rectangle(0,120,244,155));
            Brush textBrush = new SolidBrush(Color.Black);
            newGraphic.DrawString(textBoxContent.Text,new Font("微软雅黑",20),textBrush,0,120);
            newGraphic.DrawImage(Image.FromStream(headerStream),141,0,100,100);
            newGraphic.Dispose();
            pictureBoxResult.Refresh();

            labelHint.Text = "背锅成功！";
        }

        private void buttonCopyToClipboard_Click(object sender,EventArgs e)
        {
            Bitmap bitmapToClipboard = new Bitmap(pictureBoxResult.Width,pictureBoxResult.Height);
            pictureBoxResult.DrawToBitmap(bitmapToClipboard,pictureBoxResult.ClientRectangle);
            System.Windows.Forms.Clipboard.SetImage(bitmapToClipboard);
        }
    }
}
