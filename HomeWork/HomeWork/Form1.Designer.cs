﻿namespace HomeWork
{
    partial class fmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelLastMove = new System.Windows.Forms.ToolStripMenuItem();
            lblCount = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            lblTurns = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            lblValue = new System.Windows.Forms.Label();
            lblLast_Action = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlay,
            this.tsmiRestart,
            this.tsmiExit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // tsmiPlay
            // 
            this.tsmiPlay.Name = "tsmiPlay";
            this.tsmiPlay.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiPlay.Size = new System.Drawing.Size(152, 22);
            this.tsmiPlay.Text = "Play";
            this.tsmiPlay.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // tsmiRestart
            // 
            this.tsmiRestart.Name = "tsmiRestart";
            this.tsmiRestart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmiRestart.Size = new System.Drawing.Size(152, 22);
            this.tsmiRestart.Text = "Restart";
            this.tsmiRestart.Click += new System.EventHandler(this.tsmiRestart_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancelLastMove});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tsmiCancelLastMove
            // 
            this.tsmiCancelLastMove.Name = "tsmiCancelLastMove";
            this.tsmiCancelLastMove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiCancelLastMove.Size = new System.Drawing.Size(208, 22);
            this.tsmiCancelLastMove.Text = "Cancel Last Move";
            this.tsmiCancelLastMove.Click += new System.EventHandler(this.tsmiCancelLastMove_Click);
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblCount.Location = new System.Drawing.Point(125, 68);
            lblCount.Name = "lblCount";
            lblCount.Size = new System.Drawing.Size(27, 29);
            lblCount.TabIndex = 1;
            lblCount.Text = "1";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(10, 141);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 39);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMult.Location = new System.Drawing.Point(105, 140);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 39);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "*2";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(197, 141);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 39);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(204, 37);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(53, 20);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Turns:";
            // 
            // lblTurns
            // 
            lblTurns.AutoSize = true;
            lblTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblTurns.Location = new System.Drawing.Point(257, 37);
            lblTurns.Name = "lblTurns";
            lblTurns.Size = new System.Drawing.Size(18, 20);
            lblTurns.TabIndex = 6;
            lblTurns.Text = "0";
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText1.Location = new System.Drawing.Point(13, 37);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(54, 20);
            this.lblText1.TabIndex = 7;
            this.lblText1.Text = "Value:";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblValue.Location = new System.Drawing.Point(62, 37);
            lblValue.Name = "lblValue";
            lblValue.Size = new System.Drawing.Size(36, 20);
            lblValue.TabIndex = 8;
            lblValue.Text = "100";
            // 
            // lblLast_Action
            // 
            lblLast_Action.AutoSize = true;
            lblLast_Action.Location = new System.Drawing.Point(17, 104);
            lblLast_Action.Name = "lblLast_Action";
            lblLast_Action.Size = new System.Drawing.Size(23, 13);
            lblLast_Action.TabIndex = 9;
            lblLast_Action.Text = "null";
            lblLast_Action.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruleToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ruleToolStripMenuItem
            // 
            this.ruleToolStripMenuItem.Name = "ruleToolStripMenuItem";
            this.ruleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ruleToolStripMenuItem.Text = "Rule";
            this.ruleToolStripMenuItem.Click += new System.EventHandler(this.ruleToolStripMenuItem_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(lblLast_Action);
            this.Controls.Add(lblValue);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(lblTurns);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(lblCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.Text = "Doubler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlay;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestart;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelLastMove;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruleToolStripMenuItem;
        public static System.Windows.Forms.Label lblCount;
        public static System.Windows.Forms.Label lblTurns;
        public static System.Windows.Forms.Label lblValue;
        public static System.Windows.Forms.Label lblLast_Action;
    }
}

