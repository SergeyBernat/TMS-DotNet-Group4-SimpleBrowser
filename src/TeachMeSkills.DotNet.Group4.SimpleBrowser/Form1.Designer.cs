
namespace TeachMeSkills.DotNet.Group4.SimpleBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Back = new System.Windows.Forms.ToolStripButton();
            this.Forward = new System.Windows.Forms.ToolStripButton();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.Search = new System.Windows.Forms.ToolStripTextBox();
            this.GO = new System.Windows.Forms.ToolStripButton();
            this.CreateTab = new System.Windows.Forms.ToolStripButton();
            this.RemoveTab = new System.Windows.Forms.ToolStripButton();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.getIpv4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.day1 = new System.Windows.Forms.Label();
            this.currentT = new System.Windows.Forms.Label();
            this.dayofweek = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.Label();
            this.Tmin2 = new System.Windows.Forms.Label();
            this.Tmax2 = new System.Windows.Forms.Label();
            this.Tmax3 = new System.Windows.Forms.Label();
            this.Tmin3 = new System.Windows.Forms.Label();
            this.day3 = new System.Windows.Forms.Label();
            this.Tmin4 = new System.Windows.Forms.Label();
            this.Tmax4 = new System.Windows.Forms.Label();
            this.day4 = new System.Windows.Forms.Label();
            this.Tmax5 = new System.Windows.Forms.Label();
            this.Tmin5 = new System.Windows.Forms.Label();
            this.day5 = new System.Windows.Forms.Label();
            this.Tmax6 = new System.Windows.Forms.Label();
            this.Tmin6 = new System.Windows.Forms.Label();
            this.day6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ApiOut = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Forward,
            this.Refresh,
            this.Search,
            this.GO,
            this.CreateTab,
            this.RemoveTab,
            this.Home});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Stretch = true;
            // 
            // Back
            // 
            this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Back, "Back");
            this.Back.Name = "Back";
            this.Back.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Forward
            // 
            this.Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Forward, "Forward");
            this.Forward.Name = "Forward";
            this.Forward.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Refresh
            // 
            this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Refresh, "Refresh");
            this.Refresh.Name = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Search
            // 
            resources.ApplyResources(this.Search, "Search");
            this.Search.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.Search.Name = "Search";
            this.Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyUp);
            // 
            // GO
            // 
            this.GO.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.GO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.GO, "GO");
            this.GO.Name = "GO";
            this.GO.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // CreateTab
            // 
            this.CreateTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CreateTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.CreateTab, "CreateTab");
            this.CreateTab.Name = "CreateTab";
            this.CreateTab.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // RemoveTab
            // 
            this.RemoveTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RemoveTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.RemoveTab, "RemoveTab");
            this.RemoveTab.Name = "RemoveTab";
            this.RemoveTab.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Home
            // 
            this.Home.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Home, "Home");
            this.Home.Name = "Home";
            this.Home.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.toolStripSplitButton1,
            this.ApiOut});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getIpv4ToolStripMenuItem});
            resources.ApplyResources(this.toolStripSplitButton1, "toolStripSplitButton1");
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            // 
            // getIpv4ToolStripMenuItem
            // 
            this.getIpv4ToolStripMenuItem.Name = "getIpv4ToolStripMenuItem";
            resources.ApplyResources(this.getIpv4ToolStripMenuItem, "getIpv4ToolStripMenuItem");
            this.getIpv4ToolStripMenuItem.Click += new System.EventHandler(this.getIpv4ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // day1
            // 
            resources.ApplyResources(this.day1, "day1");
            this.day1.BackColor = System.Drawing.Color.Transparent;
            this.day1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.day1.Name = "day1";
            // 
            // currentT
            // 
            resources.ApplyResources(this.currentT, "currentT");
            this.currentT.BackColor = System.Drawing.Color.Transparent;
            this.currentT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentT.Name = "currentT";
            // 
            // dayofweek
            // 
            resources.ApplyResources(this.dayofweek, "dayofweek");
            this.dayofweek.BackColor = System.Drawing.Color.Transparent;
            this.dayofweek.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dayofweek.Name = "dayofweek";
            // 
            // day2
            // 
            resources.ApplyResources(this.day2, "day2");
            this.day2.BackColor = System.Drawing.Color.Transparent;
            this.day2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.day2.Name = "day2";
            // 
            // Tmin2
            // 
            resources.ApplyResources(this.Tmin2, "Tmin2");
            this.Tmin2.BackColor = System.Drawing.Color.Transparent;
            this.Tmin2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmin2.Name = "Tmin2";
            // 
            // Tmax2
            // 
            resources.ApplyResources(this.Tmax2, "Tmax2");
            this.Tmax2.BackColor = System.Drawing.Color.Transparent;
            this.Tmax2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmax2.Name = "Tmax2";
            // 
            // Tmax3
            // 
            resources.ApplyResources(this.Tmax3, "Tmax3");
            this.Tmax3.BackColor = System.Drawing.Color.Transparent;
            this.Tmax3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmax3.Name = "Tmax3";
            // 
            // Tmin3
            // 
            resources.ApplyResources(this.Tmin3, "Tmin3");
            this.Tmin3.BackColor = System.Drawing.Color.Transparent;
            this.Tmin3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmin3.Name = "Tmin3";
            // 
            // day3
            // 
            resources.ApplyResources(this.day3, "day3");
            this.day3.BackColor = System.Drawing.Color.Transparent;
            this.day3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.day3.Name = "day3";
            // 
            // Tmin4
            // 
            resources.ApplyResources(this.Tmin4, "Tmin4");
            this.Tmin4.BackColor = System.Drawing.Color.Transparent;
            this.Tmin4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmin4.Name = "Tmin4";
            // 
            // Tmax4
            // 
            resources.ApplyResources(this.Tmax4, "Tmax4");
            this.Tmax4.BackColor = System.Drawing.Color.Transparent;
            this.Tmax4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmax4.Name = "Tmax4";
            // 
            // day4
            // 
            resources.ApplyResources(this.day4, "day4");
            this.day4.BackColor = System.Drawing.Color.Transparent;
            this.day4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.day4.Name = "day4";
            // 
            // Tmax5
            // 
            resources.ApplyResources(this.Tmax5, "Tmax5");
            this.Tmax5.BackColor = System.Drawing.Color.Transparent;
            this.Tmax5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmax5.Name = "Tmax5";
            // 
            // Tmin5
            // 
            resources.ApplyResources(this.Tmin5, "Tmin5");
            this.Tmin5.BackColor = System.Drawing.Color.Transparent;
            this.Tmin5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmin5.Name = "Tmin5";
            // 
            // day5
            // 
            resources.ApplyResources(this.day5, "day5");
            this.day5.BackColor = System.Drawing.Color.Transparent;
            this.day5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.day5.Name = "day5";
            // 
            // Tmax6
            // 
            resources.ApplyResources(this.Tmax6, "Tmax6");
            this.Tmax6.BackColor = System.Drawing.Color.Transparent;
            this.Tmax6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmax6.Name = "Tmax6";
            // 
            // Tmin6
            // 
            resources.ApplyResources(this.Tmin6, "Tmin6");
            this.Tmin6.BackColor = System.Drawing.Color.Transparent;
            this.Tmin6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tmin6.Name = "Tmin6";
            // 
            // day6
            // 
            resources.ApplyResources(this.day6, "day6");
            this.day6.BackColor = System.Drawing.Color.Transparent;
            this.day6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.day6.Name = "day6";
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            // 
            // ApiOut
            // 
            this.ApiOut.Name = "ApiOut";
            resources.ApplyResources(this.ApiOut, "ApiOut");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeachMeSkills.DotNet.Group4.SimpleBrowser.Properties.Resources.sky_690293_960_720;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.day1);
            this.Controls.Add(this.currentT);
            this.Controls.Add(this.dayofweek);
            this.Controls.Add(this.Tmax6);
            this.Controls.Add(this.Tmin6);
            this.Controls.Add(this.day6);
            this.Controls.Add(this.Tmax5);
            this.Controls.Add(this.Tmin5);
            this.Controls.Add(this.day5);
            this.Controls.Add(this.Tmin4);
            this.Controls.Add(this.Tmax4);
            this.Controls.Add(this.day4);
            this.Controls.Add(this.Tmax3);
            this.Controls.Add(this.Tmin3);
            this.Controls.Add(this.day3);
            this.Controls.Add(this.Tmax2);
            this.Controls.Add(this.Tmin2);
            this.Controls.Add(this.day2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Back;
        private System.Windows.Forms.ToolStripButton Forward;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ToolStripButton GO;
        private System.Windows.Forms.ToolStripButton CreateTab;
        private System.Windows.Forms.ToolStripButton RemoveTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripTextBox Search;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.Label currentT;
        private System.Windows.Forms.Label dayofweek;
        private System.Windows.Forms.Label day2;
        private System.Windows.Forms.Label Tmin2;
        private System.Windows.Forms.Label Tmax2;
        private System.Windows.Forms.Label Tmax3;
        private System.Windows.Forms.Label Tmin3;
        private System.Windows.Forms.Label day3;
        private System.Windows.Forms.Label Tmin4;
        private System.Windows.Forms.Label Tmax4;
        private System.Windows.Forms.Label day4;
        private System.Windows.Forms.Label Tmax5;
        private System.Windows.Forms.Label Tmin5;
        private System.Windows.Forms.Label day5;
        private System.Windows.Forms.Label Tmax6;
        private System.Windows.Forms.Label Tmin6;
        private System.Windows.Forms.Label day6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem getIpv4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ApiOut;
    }
}