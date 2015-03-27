using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.ObjectModel;
using DMISService.View;
using System.Resources;

namespace DMISService.View
{
    /*-------------------------------------------------------------------------------
     *类说明：为了实现WPF能和winform一样具有右下角notifyico功能而定义的界面类（View）
     *功能：（1）实现右下角图标功能
     *      （2）实现对应的接口，因为主窗口是逻辑处理窗口，数据要
     *           流向显示窗口，必须借助于中介NotifyIconView
     *作者：hds
     *时间：2013年12月2日
     *--------------------------------------------------------------------------------*/

    /// <summary>
    /// 右下角图标显示类
    /// </summary>
    public class NotifyIconView:IDisposable
    {
        #region fileds

        private NotifyIcon notifyIcon;//winform控件


        #endregion

        #region constructor methods

        /// <summary>
        /// 构造函数
        /// </summary>
        public NotifyIconView()
        {
            //右下角图标定义
            notifyIcon = new NotifyIcon();
            notifyIcon.Text = "设置";
            notifyIcon.BalloonTipText = "正在启动";
            notifyIcon.ShowBalloonTip(3000);
           // notifyIcon.Icon = Resource1.Gear_1;
            notifyIcon.Visible = true;

            //快捷菜单
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Name = "ContextMenuStrip";

            //用户

            ToolStripMenuItem tsmiManage = new ToolStripMenuItem();
        //    tsmiManage.Image = DMISService.Resource1.用户;
            tsmiManage.Click += new EventHandler(tsmiManage_Click);
            tsmiManage.Text = "连接设置";
            cms.Items.Add(tsmiManage);

            //退出
            ToolStripMenuItem tsmiExit = new ToolStripMenuItem();
           // tsmiExit.Image = DMISService.Resource1.退出;
            tsmiExit.Click += new EventHandler(tsmiExit_Click);
            tsmiExit.Text = "退出(E)";
            cms.Items.Add(tsmiExit);

            //快捷菜单关联
            notifyIcon.ContextMenuStrip = cms;
        }

        void tsmiManage_Click(object sender, EventArgs e)
        {
            //if(manageView==null||!manageView.IsVisible)
            //{
            //    manageView = new Manage();
            //}
            //manageView.Show();
        }

        #endregion

        #region event handling methods

        /// <summary>
        /// 单击退出快捷菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("您确定要退出？", "U位检测", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Application.Current.MainWindow.Close();
                //System.Windows.Application.Current.Shutdown();
            }
        }

        #endregion

        #region IDisposable methods

        public void Dispose()
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
        }

        #endregion


    }
}
