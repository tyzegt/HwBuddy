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

        BaseBot currentBot;
        BaseBot dunBot;
        BaseBot towerBot;
        BaseBot raidBot;

        public static Point Position;
        public static bool CollectPowerups;

        Stopwatch stopwatch = new Stopwatch();

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

            dunBot = new DungeonBot(this);
            towerBot = new TowerBot(this);
            raidBot = new RaidBot(this);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ESC_HOTKEY_ID)
            {
                timer1.Enabled = false;
                //timer1.Interval = 700;
            }
            base.WndProc(ref m);
        }


        #region Bots

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentBot == null) return;
            stopwatch.Restart();
            currentBot.Step();
            stopwatch.Stop();

            Log(stopwatch.Elapsed.ToString());
        }

        void Log(string message)
        {
            var lines = textBoxLog.Lines.ToList();
            lines.Reverse();
            if (lines.Count > 100) lines.RemoveAt(0);
            lines.Add(message);
            lines.Reverse();
            textBoxLog.Lines = lines.ToArray();
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

        #endregion

        #region FormControls


        private void testButton_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Move(object sender, EventArgs e)
        {

        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            Position = new Point(Location.X, Location.Y + Height);
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ImageService.CheckImagePresent(Images.DUNGEON_TO_BATTLE);
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://hw-buddy.ru") { UseShellExecute = true });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CollectPowerups = checkBox1.Checked;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://hw-buddy.ru") { UseShellExecute = true });
        }

        #endregion
    }
}
