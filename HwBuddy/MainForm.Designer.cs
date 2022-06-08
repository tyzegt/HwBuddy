
namespace HwBuddy
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.towerButton = new System.Windows.Forms.Button();
            this.dungeonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.raidButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.ToeButton = new System.Windows.Forms.Button();
            this.campaignButton = new System.Windows.Forms.Button();
            this.eventsButton = new System.Windows.Forms.Button();
            this.expeditionsButton = new System.Windows.Forms.Button();
            this.zapredButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // towerButton
            // 
            this.towerButton.Location = new System.Drawing.Point(12, 27);
            this.towerButton.Name = "towerButton";
            this.towerButton.Size = new System.Drawing.Size(58, 23);
            this.towerButton.TabIndex = 1;
            this.towerButton.Text = "Башня";
            this.towerButton.UseVisualStyleBackColor = true;
            this.towerButton.Click += new System.EventHandler(this.towerButton_Click);
            // 
            // dungeonButton
            // 
            this.dungeonButton.Location = new System.Drawing.Point(76, 27);
            this.dungeonButton.Name = "dungeonButton";
            this.dungeonButton.Size = new System.Drawing.Size(83, 23);
            this.dungeonButton.TabIndex = 2;
            this.dungeonButton.Text = "Подземелье";
            this.dungeonButton.UseVisualStyleBackColor = true;
            this.dungeonButton.Click += new System.EventHandler(this.dungeonButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(908, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размести окно бота так, чтобы игра была ровно под ним. Войди в подземелье или баш" +
    "ню и нажми соответствующую кнопку. Чтобы остановить бота, нажми esc.";
            // 
            // raidButton
            // 
            this.raidButton.Location = new System.Drawing.Point(348, 27);
            this.raidButton.Name = "raidButton";
            this.raidButton.Size = new System.Drawing.Size(61, 23);
            this.raidButton.TabIndex = 5;
            this.raidButton.Text = "Рейдить";
            this.raidButton.UseVisualStyleBackColor = true;
            this.raidButton.Click += new System.EventHandler(this.raidButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(814, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(200, 15);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Обновления тут - vk.com/hwbuddy";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(941, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(73, 15);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Инструкция";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ToeButton
            // 
            this.ToeButton.Location = new System.Drawing.Point(165, 27);
            this.ToeButton.Name = "ToeButton";
            this.ToeButton.Size = new System.Drawing.Size(97, 23);
            this.ToeButton.TabIndex = 8;
            this.ToeButton.Text = "Турнир стихий";
            this.ToeButton.UseVisualStyleBackColor = true;
            this.ToeButton.Click += new System.EventHandler(this.ToeButton_Click);
            // 
            // campaignButton
            // 
            this.campaignButton.Location = new System.Drawing.Point(268, 27);
            this.campaignButton.Name = "campaignButton";
            this.campaignButton.Size = new System.Drawing.Size(74, 23);
            this.campaignButton.TabIndex = 9;
            this.campaignButton.Text = "Кампания";
            this.campaignButton.UseVisualStyleBackColor = true;
            this.campaignButton.Click += new System.EventHandler(this.campaignButton_Click);
            // 
            // eventsButton
            // 
            this.eventsButton.Location = new System.Drawing.Point(415, 27);
            this.eventsButton.Name = "eventsButton";
            this.eventsButton.Size = new System.Drawing.Size(66, 23);
            this.eventsButton.TabIndex = 10;
            this.eventsButton.Text = "События";
            this.eventsButton.UseVisualStyleBackColor = true;
            this.eventsButton.Click += new System.EventHandler(this.eventsButton_Click);
            // 
            // expeditionsButton
            // 
            this.expeditionsButton.Location = new System.Drawing.Point(487, 27);
            this.expeditionsButton.Name = "expeditionsButton";
            this.expeditionsButton.Size = new System.Drawing.Size(83, 23);
            this.expeditionsButton.TabIndex = 11;
            this.expeditionsButton.Text = "Экспедиции";
            this.expeditionsButton.UseVisualStyleBackColor = true;
            this.expeditionsButton.Click += new System.EventHandler(this.expeditionsButton_Click);
            // 
            // zapredButton
            // 
            this.zapredButton.Location = new System.Drawing.Point(576, 27);
            this.zapredButton.Name = "zapredButton";
            this.zapredButton.Size = new System.Drawing.Size(80, 23);
            this.zapredButton.TabIndex = 12;
            this.zapredButton.Text = "Запределье";
            this.zapredButton.UseVisualStyleBackColor = true;
            this.zapredButton.Click += new System.EventHandler(this.zapredButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 60);
            this.Controls.Add(this.zapredButton);
            this.Controls.Add(this.expeditionsButton);
            this.Controls.Add(this.eventsButton);
            this.Controls.Add(this.campaignButton);
            this.Controls.Add(this.ToeButton);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.raidButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dungeonButton);
            this.Controls.Add(this.towerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "HW Buddy v1.0.0.1";
            this.TopMost = true;
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button towerButton;
        private System.Windows.Forms.Button dungeonButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button raidButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button ToeButton;
        private System.Windows.Forms.Button campaignButton;
        private System.Windows.Forms.Button eventsButton;
        private System.Windows.Forms.Button expeditionsButton;
        private System.Windows.Forms.Button zapredButton;
    }
}

