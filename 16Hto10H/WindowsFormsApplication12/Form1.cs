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
            int m = 10;
            int ll = ToErJin(10);
            byte[] index = { 1, 3, 8, 12, 16, 32, 255, 22,32,12,42,55,55 };
            EXData(index);
            //DateTime ll = DateTime.Now;
            //string json = wf.GetPlanAndPlanRun(m,null,ll,1);
            string j = Convert.ToString(m, 2);
        }
        int[] state = new int[42];
        int num;
        void EXData(byte[] msg)
        {
            num = 0;
            int[] index = { 1, 2, 4, 8, 16, 32, 64, 128 };
            int oneToEight = Convert.ToInt32(msg[4]);
            int nieToSixteen = Convert.ToInt32(msg[3]);
            int seventeenToTwinteenFor = Convert.ToInt32(msg[6]);
            int TwinteenFiveTothirtyTwo = Convert.ToInt32(msg[5]);
            int thirtythreeToForTy = Convert.ToInt32(msg[8]);
            int fortyoneToForTytwo = Convert.ToInt32(msg[7]);
            for (int i = 0; i < 8; i++)
            {
                int result = oneToEight & index[i];
                if (result !=0)
                {
                    state[num] = 1;
                }
                else
                {
                    state[num] = 0;
                }
                num++;
            }
            for (int i = 0; i < 8; i++)
            {
                int result = nieToSixteen & index[i];
                if (result !=0)
                {
                    state[num] = 1;
                }
                else
                {
                    state[num] = 0;
                }
                num++;
            }
            for (int i = 0; i < 8; i++)
            {
                int result = seventeenToTwinteenFor & index[i];
                if (result != 0)
                {
                    state[num] = 1;
                }
                else
                {
                    state[num] = 0;
                }
                num++;
            }
            for (int i = 0; i < 8; i++)
            {
                int result = TwinteenFiveTothirtyTwo & index[i];
                if (result != 0)
                {
                    state[num] = 1;
                }
                else
                {
                    state[num] = 0;
                }
                num++;
            }
            for (int i = 0; i < 8; i++)
            {
                int result = thirtythreeToForTy & index[i];
                if (result != 0)
                {
                    state[num] = 1;
                }
                else
                {
                    state[num] = 0;
                }
                num++;
            }
            for (int i = 6; i < 8; i++)
            {
                int result = fortyoneToForTytwo & index[i];
                if (result != 0)
                {
                    state[num] = 1;
                }
                else
                {
                    state[num] = 0;
                }
                num++;
            }
        }
        public static int ToErJin(int value)
        {
            int temp = 0;
            int shang = 1;
            int yushu;
            while (shang != 0)
            {
                shang = (int)value / 2;
                yushu = value % 2;
                value = shang;
                temp += yushu;
                if (shang != 0)
                {
                    temp = temp * 10;
                }
            }
            //最后将 temp 倒序
            string tempStr = temp.ToString();
            int tempLength = tempStr.Length;
            string resultStr = string.Empty;
            for (int i = 0; i < tempLength; i++)
            {
                resultStr = tempStr[i] + resultStr;
            }
            return int.Parse(resultStr);
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
