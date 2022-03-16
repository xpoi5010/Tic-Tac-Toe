namespace OOXX_New
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.開始遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.簡單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.困難ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.超困難ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameGrid1 = new System.Windows.Forms.Label();
            this.gameGrid2 = new System.Windows.Forms.Label();
            this.gameGrid3 = new System.Windows.Forms.Label();
            this.gameGrid6 = new System.Windows.Forms.Label();
            this.gameGrid5 = new System.Windows.Forms.Label();
            this.gameGrid4 = new System.Windows.Forms.Label();
            this.gameGrid9 = new System.Windows.Forms.Label();
            this.gameGrid8 = new System.Windows.Forms.Label();
            this.gameGrid7 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.currentPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開始遊戲ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 開始遊戲ToolStripMenuItem
            // 
            this.開始遊戲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.簡單ToolStripMenuItem,
            this.普通ToolStripMenuItem,
            this.困難ToolStripMenuItem,
            this.超困難ToolStripMenuItem});
            this.開始遊戲ToolStripMenuItem.Name = "開始遊戲ToolStripMenuItem";
            this.開始遊戲ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.開始遊戲ToolStripMenuItem.Text = "遊戲";
            // 
            // 簡單ToolStripMenuItem
            // 
            this.簡單ToolStripMenuItem.Name = "簡單ToolStripMenuItem";
            this.簡單ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.簡單ToolStripMenuItem.Text = "簡單";
            this.簡單ToolStripMenuItem.Click += new System.EventHandler(this.簡單ToolStripMenuItem_Click);
            // 
            // 普通ToolStripMenuItem
            // 
            this.普通ToolStripMenuItem.Name = "普通ToolStripMenuItem";
            this.普通ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.普通ToolStripMenuItem.Text = "普通";
            this.普通ToolStripMenuItem.Click += new System.EventHandler(this.普通ToolStripMenuItem_Click);
            // 
            // 困難ToolStripMenuItem
            // 
            this.困難ToolStripMenuItem.Name = "困難ToolStripMenuItem";
            this.困難ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.困難ToolStripMenuItem.Text = "困難";
            this.困難ToolStripMenuItem.Click += new System.EventHandler(this.困難ToolStripMenuItem_Click);
            // 
            // 超困難ToolStripMenuItem
            // 
            this.超困難ToolStripMenuItem.Name = "超困難ToolStripMenuItem";
            this.超困難ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.超困難ToolStripMenuItem.Text = "超困難";
            this.超困難ToolStripMenuItem.Click += new System.EventHandler(this.超困難ToolStripMenuItem_Click);
            // 
            // gameGrid1
            // 
            this.gameGrid1.BackColor = System.Drawing.SystemColors.Control;
            this.gameGrid1.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameGrid1.Location = new System.Drawing.Point(12, 33);
            this.gameGrid1.Name = "gameGrid1";
            this.gameGrid1.Size = new System.Drawing.Size(142, 154);
            this.gameGrid1.TabIndex = 2;
            this.gameGrid1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameGrid1.Click += new System.EventHandler(this.gameGrid_Click);
            // 
            // gameGrid2
            // 
            this.gameGrid2.BackColor = System.Drawing.SystemColors.Control;
            this.gameGrid2.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameGrid2.Location = new System.Drawing.Point(160, 33);
            this.gameGrid2.Name = "gameGrid2";
            this.gameGrid2.Size = new System.Drawing.Size(142, 154);
            this.gameGrid2.TabIndex = 3;
            this.gameGrid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameGrid2.Click += new System.EventHandler(this.gameGrid_Click);
            // 
            // gameGrid3
            // 
            this.gameGrid3.BackColor = System.Drawing.SystemColors.Control;
            this.gameGrid3.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameGrid3.Location = new System.Drawing.Point(308, 33);
            this.gameGrid3.Name = "gameGrid3";
            this.gameGrid3.Size = new System.Drawing.Size(142, 154);
            this.gameGrid3.TabIndex = 4;
            this.gameGrid3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameGrid3.Click += new System.EventHandler(this.gameGrid_Click);
            // 
            // gameGrid6
            // 
            this.gameGrid6.BackColor = System.Drawing.SystemColors.Control;
            this.gameGrid6.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameGrid6.Location = new System.Drawing.Point(308, 193);
            this.gameGrid6.Name = "gameGrid6";
            this.gameGrid6.Size = new System.Drawing.Size(142, 154);
            this.gameGrid6.TabIndex = 7;
            this.gameGrid6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameGrid6.Click += new System.EventHandler(this.gameGrid_Click);
            // 
            // gameGrid5
            // 
            this.gameGrid5.BackColor = System.Drawing.SystemColors.Control;
            this.gameGrid5.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameGrid5.Location = new System.Drawing.Point(160, 193);
            this.gameGrid5.Name = "gameGrid5";
            this.gameGrid5.Size = new System.Drawing.Size(142, 154);
            this.gameGrid5.TabIndex = 6;
            this.gameGrid5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameGrid5.Click += new System.EventHandler(this.gameGrid_Click);
            // 
            // gameGrid4
            // 
            this.gameGrid4.BackColor = System.Drawing.SystemColors.Control;
            this.gameGrid4.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameGrid4.Location = new System.Drawing.Point(12, 193);
            this.gameGrid4.Name = "gameGrid4";
            this.gameGrid4.Size = new System.Drawing.Size(142, 154);
            this.gameGrid4.TabIndex = 5;
            this.gameGrid4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameGrid4.Click += new System.EventHandler(this.gameGrid_Click);
            // 
            // gameGrid9
            // 
            this.gameGrid9.BackColor = System.Drawing.SystemColors.Control;
            this.gameGrid9.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameGrid9.Location = new System.Drawing.Point(308, 353);
            this.gameGrid9.Name = "gameGrid9";
            this.gameGrid9.Size = new System.Drawing.Size(142, 154);
            this.gameGrid9.TabIndex = 10;
            this.gameGrid9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameGrid9.Click += new System.EventHandler(this.gameGrid_Click);
            // 
            // gameGrid8
            // 
            this.gameGrid8.BackColor = System.Drawing.SystemColors.Control;
            this.gameGrid8.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameGrid8.Location = new System.Drawing.Point(160, 353);
            this.gameGrid8.Name = "gameGrid8";
            this.gameGrid8.Size = new System.Drawing.Size(142, 154);
            this.gameGrid8.TabIndex = 9;
            this.gameGrid8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameGrid8.Click += new System.EventHandler(this.gameGrid_Click);
            // 
            // gameGrid7
            // 
            this.gameGrid7.BackColor = System.Drawing.SystemColors.Control;
            this.gameGrid7.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameGrid7.Location = new System.Drawing.Point(12, 353);
            this.gameGrid7.Name = "gameGrid7";
            this.gameGrid7.Size = new System.Drawing.Size(142, 154);
            this.gameGrid7.TabIndex = 8;
            this.gameGrid7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameGrid7.Click += new System.EventHandler(this.gameGrid_Click);
            // 
            // statusText
            // 
            this.statusText.Font = new System.Drawing.Font("Microsoft JhengHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusText.Location = new System.Drawing.Point(457, 33);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(331, 154);
            this.statusText.TabIndex = 11;
            this.statusText.Text = "等待中";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPlayer
            // 
            this.currentPlayer.Font = new System.Drawing.Font("Microsoft JhengHei", 144F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPlayer.Location = new System.Drawing.Point(457, 264);
            this.currentPlayer.Name = "currentPlayer";
            this.currentPlayer.Size = new System.Drawing.Size(331, 243);
            this.currentPlayer.TabIndex = 12;
            this.currentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(457, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 71);
            this.label1.TabIndex = 13;
            this.label1.Text = "現在輪到";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentPlayer);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.gameGrid9);
            this.Controls.Add(this.gameGrid8);
            this.Controls.Add(this.gameGrid7);
            this.Controls.Add(this.gameGrid6);
            this.Controls.Add(this.gameGrid5);
            this.Controls.Add(this.gameGrid4);
            this.Controls.Add(this.gameGrid3);
            this.Controls.Add(this.gameGrid2);
            this.Controls.Add(this.gameGrid1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "井字遊戲";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 開始遊戲ToolStripMenuItem;
        private ToolStripMenuItem 簡單ToolStripMenuItem;
        private ToolStripMenuItem 普通ToolStripMenuItem;
        private ToolStripMenuItem 困難ToolStripMenuItem;
        private Label gameGrid1;
        private Label gameGrid2;
        private Label gameGrid3;
        private Label gameGrid6;
        private Label gameGrid5;
        private Label gameGrid4;
        private Label gameGrid9;
        private Label gameGrid8;
        private Label gameGrid7;
        private Label statusText;
        private Label currentPlayer;
        private ToolStripMenuItem 超困難ToolStripMenuItem;
        private Label label1;
    }
}