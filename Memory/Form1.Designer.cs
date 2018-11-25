namespace Memory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.saveSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTable = new System.Windows.Forms.TableLayoutPanel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lagTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.surrenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.resizeGridToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveSettingsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem1,
            this.toolStripSeparator2,
            this.surrenderToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 22);
            this.toolStripSeparator1.Text = "Restart";
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // saveSettingsToolStripMenuItem1
            // 
            this.saveSettingsToolStripMenuItem1.Name = "saveSettingsToolStripMenuItem1";
            this.saveSettingsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveSettingsToolStripMenuItem1.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem1.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem1_Click);
            // 
            // resizeGridToolStripMenuItem
            // 
            this.resizeGridToolStripMenuItem.Name = "resizeGridToolStripMenuItem";
            this.resizeGridToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.resizeGridToolStripMenuItem.Text = "resize Grid";
            this.resizeGridToolStripMenuItem.Click += new System.EventHandler(this.resizeGridToolStripMenuItem_Click);
            // 
            // gameTable
            // 
            this.gameTable.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gameTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.gameTable.ColumnCount = 2;
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTable.Location = new System.Drawing.Point(0, 24);
            this.gameTable.Name = "gameTable";
            this.gameTable.RowCount = 2;
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.Size = new System.Drawing.Size(1187, 562);
            this.gameTable.TabIndex = 1;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lagTimer
            // 
            this.lagTimer.Interval = 750;
            this.lagTimer.Tick += new System.EventHandler(this.lagTimer_Tick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // surrenderToolStripMenuItem
            // 
            this.surrenderToolStripMenuItem.Name = "surrenderToolStripMenuItem";
            this.surrenderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.surrenderToolStripMenuItem.Text = "Surrender";
            this.surrenderToolStripMenuItem.Click += new System.EventHandler(this.surrenderToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 586);
            this.Controls.Add(this.gameTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel gameTable;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeGridToolStripMenuItem;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer lagTimer;
        private System.Windows.Forms.ToolStripMenuItem toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem surrenderToolStripMenuItem;
    }
}

