using HwBuddy.Bots;
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

        const int ESC_HOTKEY_ID = 1;

        BaseBot currentBot; // todo: Create bot factory
        BaseBot dunBot;
        BaseBot towerBot;
        BaseBot raidBot;
        BaseBot tournamentBot;

        public static Point Position;
        //public static bool CollectPowerups;

        //Stopwatch stopwatch = new Stopwatch();

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

            dunBot = new DungeonBot();
            towerBot = new TowerBot();
            raidBot = new RaidBot();
            tournamentBot = new TournamentOfElementsBot();
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
            currentBot = towerBot;
            timer1.Enabled = true;
        }

        private void dungeonButton_Click(object sender, EventArgs e)
        {
            currentBot = dunBot;
            timer1.Enabled = true;
        }

        private void raidButton_Click(object sender, EventArgs e)
        {
            currentBot = raidBot;
            currentBot.Reset();
            timer1.Enabled = true;
        }

        private void ToeButton_Click(object sender, EventArgs e)
        {
            currentBot = tournamentBot;
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
            Process.Start(new ProcessStartInfo("https://hw-buddy.ru") { UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://hw-buddy.ru") { UseShellExecute = true });
        }

        #endregion


    }
}
