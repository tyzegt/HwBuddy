using HwBuddy.Bots;
using HwBuddy.Common;
using HwBuddy.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        BotType botType;
        BotStep step = BotStep.Tower;
        DungeonBot dunBot = new DungeonBot();
        TowerBot towerBot = new TowerBot();

        public static Point Position;

        public MainForm()
        {
            InitializeComponent();
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, ESC_HOTKEY_ID, 0, (int)Keys.Escape);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ESC_HOTKEY_ID)
            {
                timer1.Enabled = false;
            }
            base.WndProc(ref m);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            
        }

        

        private void towerButton_Click(object sender, EventArgs e)
        {
            botType = BotType.Tower;
            timer1.Enabled = true;
        }

        private void dungeonButton_Click(object sender, EventArgs e)
        {
            botType = BotType.Dungeon;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (botType == BotType.Dungeon)
                dunBot.Step();
            if (botType == BotType.Tower)
                towerBot.Step();
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
            ImageService.CheckImagePresent(Images.DUNGEON_TO_BATTLE);
        }
    }

    public enum BotStep
    {
        Tower,
        CheckFloor,
        TowerDoor,
        TowerChest,
        TowerRaid,
        SelectPower,
        NextFloor,
        ChestSelect,
        TowerChestMoveon,
        TowerShrine,
        TowerChestOpen
    }

    public enum BotType
    {
        Tower,
        Dungeon
    }
}
