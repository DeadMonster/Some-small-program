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

namespace UControl
{
    /// <summary>
    /// Carbine.xaml 的交互逻辑
    /// </summary>
    public partial class Carbine : UserControl
    {
        List<CarDev> devlist = new List<CarDev>();
        public Carbine()
        {
            InitializeComponent();
           
            GetU();

        }

        void GetU()
        {
            for (int i = 0; i < 42; i++)
            {
                RowDefinition qq = new RowDefinition();
                qq.Height = new GridLength(625/ 42);
                car.RowDefinitions.Add(qq);
                Label te = new Label();
                te.Tag = Convert.ToString(42 - i);
                te.Background = Brushes.DarkGray;
                //te.MouseEnter += new MouseEventHandler(te_MouseEnter);
                //te.MouseLeave += new MouseEventHandler(te_MouseLeave);
                car.Children.Add(te);
                Grid.SetRow(te, i);
                Border bor = new Border();
                Thickness borthin = new Thickness();
                borthin.Left = 1;
                borthin.Right = 1;
                borthin.Top = 1;
                bor.BorderThickness = borthin;
                bor.BorderBrush = Brushes.Black;
                car.Children.Add(bor);
                Grid.SetRow(bor, i);

                TextBlock ll = new TextBlock();
                ll.Text = (42 - i).ToString();
                ll.Foreground = Brushes.White;
                ll.FontSize = 10;
                ll.Height = 625 / 42;
                ll.Width = 20;
                ll.VerticalAlignment = VerticalAlignment.Center;
                ll.HorizontalAlignment = HorizontalAlignment.Left;
                car.Children.Add(ll);
                Grid.SetRow(ll, i);
            }
        }

     public   void setU(int num)
        {
            CarDev dev = new CarDev();
            dev.CarbineName =( num+1).ToString();
            dev.Background = Brushes.LightGray;
            dev.FontColor = Brushes.Black;
            //Thickness mar = new Thickness();
            //mar.Left = 20;
            //dev.Margin = mar;
            Grid.SetRow(dev,41-num);
            Grid.SetRowSpan(dev, 1);
            devlist.Add(dev);
            car.Children.Add(dev);
        }
     public   void DeletU(int num)
        {
            for (int i = 0; i < devlist.Count; i++)
            {
                if ((num+1).ToString() == devlist[i].CarbineName)
                {
                    car.Children.Remove(devlist[i]);
                    devlist.Remove(devlist[i]);
                }
            }
        }
    }
}
