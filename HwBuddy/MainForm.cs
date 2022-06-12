using HwBuddy.Bots;
using HwBuddy.Bots.Base;
using HwBuddy.Common;
using HwBuddy.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HwBuddy
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public static Point Position;

        const int ESC_HOTKEY_ID = 1;

        BaseBot currentBot; 


        public MainForm()
        {
            InitializeComponent();
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, ESC_HOTKEY_ID, 0, (int)Keys.Escape);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            //DebugForm debugForm = new DebugForm();
            //debugForm.Show();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ESC_HOTKEY_ID)
            {
                timer1.Enabled = false;
            }
            base.WndProc(ref m);
        }

        #region Bots

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentBot == null) return;
            currentBot.Step();
        }

        private void towerButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetTowerBot();
            StartBot();
        }

        private void dungeonButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetDungeonBot();
            StartBot();
        }

        private void raidButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetRaidBot();
            currentBot.Reset();
            StartBot();
        }

        private void ToeButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetToeBot();
            StartBot();
        }
        private void campaignButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetCampaignBot();
            StartBot();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetEventsBot();
            StartBot(1000);
        }

        private void expeditionsButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetExpeditionsBot();
            StartBot();
        }
        private void zapredButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetOutlandBot();
            StartBot();
        }

        private void questsButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetQuestsBot();
            StartBot();
        }
        private void postButton_Click(object sender, EventArgs e)
        {
            currentBot = BotFactory.GetPostBot();
            StartBot();
        }

        void StartBot(int delay = 400)
        {
            timer1.Interval = delay;
            timer1.Enabled = true;
        }


        #endregion

        #region FormControls

        private void MainForm_Move(object sender, EventArgs e)
        {
            Position = new Point(Location.X, Location.Y + Height);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://vk.com/hwbuddy") { UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://hw-buddy.ru") { UseShellExecute = true });
        }






        #endregion

    }
}
