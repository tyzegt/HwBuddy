
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.towerButton = new System.Windows.Forms.Button();
            this.dungeonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // towerButton
            // 
            this.towerButton.Location = new System.Drawing.Point(12, 27);
            this.towerButton.Name = "towerButton";
            this.towerButton.Size = new System.Drawing.Size(97, 23);
            this.towerButton.TabIndex = 1;
            this.towerButton.Text = "Башня";
            this.towerButton.UseVisualStyleBackColor = true;
            this.towerButton.Click += new System.EventHandler(this.towerButton_Click);
            // 
            // dungeonButton
            // 
            this.dungeonButton.Location = new System.Drawing.Point(115, 27);
            this.dungeonButton.Name = "dungeonButton";
            this.dungeonButton.Size = new System.Drawing.Size(97, 23);
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
            this.label1.Move += new System.EventHandler(this.label1_Move);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(939, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 56);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dungeonButton);
            this.Controls.Add(this.towerButton);
            this.Name = "MainForm";
            this.Text = "HW Buddy";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button towerButton;
        private System.Windows.Forms.Button dungeonButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

