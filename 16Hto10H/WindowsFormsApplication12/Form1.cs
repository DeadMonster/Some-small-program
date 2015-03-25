using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WFService.WFServiceClient wf = new WFService.WFServiceClient();
        private void button1_Click(object sender, EventArgs e)
        {
            float n = 1;
            float temp = 1;
            float sum = 0;

            do
            {
                float i = 1 / n;
                temp = i * temp;
                sum = sum + temp;
                n++;
            } while (n <= 20);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = 1;
            DateTime ll = DateTime.Now;
            string json = wf.GetPlanAndPlanRun(m,null,ll,1);
        }

        public void send_data(string duanxin_text)
        {
            string msg ="01 03 00 0B 00 01 F5 C8";
            int a = 1,b=3,c=0,d=11,e=0,f=4,g=245,h=200;
            byte[] test = new byte[8];
            test[0] =Convert.ToByte(a);
            test[1] = Convert.ToByte(b);
            test[2] = Convert.ToByte(c);
            test[3] = Convert.ToByte(d);
            test[4] = Convert.ToByte(e);
            test[5] = Convert.ToByte(f);
            test[6] = Convert.ToByte(g);
            test[7] = Convert.ToByte(h);
            byte aa =Convert.ToByte(a);
            byte[] ll =HexStringToByteArray(msg);
            string[] s = msg.Split(new char[] { ' ' });
                byte[] bmsg = System.Text.Encoding.Unicode.GetBytes(msg);
                for (int i = 0; i < bmsg.Length; i += 2)
                {
                    byte tmp = bmsg[i];
                    bmsg[i] = bmsg[i + 1];
                    bmsg[i + 1] = tmp;
                }
          
                byte[] ballmsg = new byte[1000];
              
              //  serialPort1.Write(ballmsg, 0, badd.Length + bmsg.Length);
            }

        private void button3_Click(object sender, EventArgs e)
        {
        send_data("aa");
        }

        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        private static string ByteArrayToHexString(byte[] bytes)
        {

            if (bytes == null || bytes.Length == 0)

                throw new ArgumentException("bytes [] 参数出错");

            StringBuilder hexString = new StringBuilder(2 * bytes.Length);

            for (int i = 0; i < bytes.Length; i++)
                hexString.AppendFormat("{0:X2}", bytes[i]);

            return hexString.ToString();

        }
    }
}
