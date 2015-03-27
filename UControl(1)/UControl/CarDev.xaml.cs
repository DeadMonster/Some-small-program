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
    /// CarDev.xaml 的交互逻辑
    /// </summary>
    public partial class CarDev : UserControl
    {
        public CarDev()
        {
            InitializeComponent();
        }

        private string _CarbineName;
        public string CarbineName
        {
            get { return _CarbineName; }
            set
            {
                _CarbineName = value;
                CarName.Text = _CarbineName;
            }
        }

        private double _CarbineFontSize;
        public double CarbineFontSize
        {
            get { return _CarbineFontSize; }
            set
            {
                _CarbineFontSize = value;
                CarName.FontSize = _CarbineFontSize;

            }
        }

        private Brush _DevBackGround;
        public Brush DevBackGround
        {
            get { return _DevBackGround; }
            set
            {
                _DevBackGround = value;
                textBlock.Background = _DevBackGround;
            }
        }

        private Brush _FontColor;
        public Brush FontColor
        {
            get { return _FontColor; }
            set
            {
                _FontColor = value;
                CarName.Foreground = _FontColor;
            }
        }
    }
}
