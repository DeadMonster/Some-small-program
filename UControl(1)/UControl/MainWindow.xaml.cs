using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Configuration;
namespace UControl
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Carbine carbine;
        UDP.Client client;
        EndPoint serverEP;
        int[] state = new int[42];
        public MainWindow()
        {
            InitializeComponent();
            try
            {
              

                client = new UDP.Client(new System.Net.IPEndPoint(IPAddress.Any, 502));
                client.RecvDatagram += new UDP.NetEventArgsHandler(client_RecvDatagram);
                carbine = new Carbine();
                car.Children.Add(carbine);
                Start();
            }
            catch (Exception ee)
            {
                
                MessageBox.Show(ee.Message);
            }
        }

        void client_RecvDatagram(object sender, UDP.NetEventArgs e)
        {
            if (e.Buff.Length == 13)
            {
                EXData(e.Buff);
                for (int i = 0; i < state.Length; i++)
                {
                    if (state[i] == 1)
                    {
                        App.Current.Dispatcher.Invoke((Action)(() =>
                        {
                            carbine.setU(i);
                        }));
                     //   carbine.setU(i);
                    }
                }
            }
            else
            {
                if (Convert.ToInt32(e.Buff[14]) != 0)
                {
                    App.Current.Dispatcher.Invoke((Action)(() =>
                    {
                        carbine.setU(Convert.ToInt32(e.Buff[6])-1);
                    }));
                   
                }
                else
                {
                    App.Current.Dispatcher.Invoke((Action)(() =>
                    {

                        carbine.DeletU(Convert.ToInt32(e.Buff[6])-1);
                    }));
                }
            }
        }

        #region MyRegion
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.serverEP == null)
                {
                    serverEP = new System.Net.IPEndPoint(IPAddress.Parse("192.168.0.160"), 502);
                }
                byte[] aa = HexStringToByteArray("01 03 00 0B 00 04 35 CB");
                client.SendTo(aa, serverEP);
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        } 
        #endregion
        void Start()
        {
            try
            {
                if (this.serverEP == null)
                {
                    string ip = ConfigurationManager.ConnectionStrings["ip"].ToString();
                    string port=ConfigurationManager.ConnectionStrings["port"].ToString();
                    serverEP = new System.Net.IPEndPoint(IPAddress.Parse(ip), int.Parse(port));
                }
                byte[] aa = HexStringToByteArray("01 03 00 0B 00 04 35 CB");
                client.SendTo(aa, serverEP);
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
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
                int result = nieToSixteen & index[i];
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
            for (int i = 0; i < 2; i++)
            {
                int result = fortyoneToForTytwo & index[i];
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
        }
    }
}
