namespace KeyLocks_Simple
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.hide_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.about_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.stat_picBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stat_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "KeyBoard LED";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.DimGray;
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_Item,
            this.hide_Item,
            this.about_Item});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip.Size = new System.Drawing.Size(222, 76);
            // 
            // exit_Item
            // 
            this.exit_Item.ForeColor = System.Drawing.Color.White;
            this.exit_Item.Name = "exit_Item";
            this.exit_Item.Size = new System.Drawing.Size(221, 24);
            this.exit_Item.Text = "Exit";
            this.exit_Item.Click += new System.EventHandler(this.exit_Item_Click);
            // 
            // hide_Item
            // 
            this.hide_Item.ForeColor = System.Drawing.Color.White;
            this.hide_Item.Name = "hide_Item";
            this.hide_Item.Size = new System.Drawing.Size(221, 24);
            this.hide_Item.Text = "Hide to Tray";
            this.hide_Item.Click += new System.EventHandler(this.hide_Item_Click);
            // 
            // about_Item
            // 
            this.about_Item.ForeColor = System.Drawing.Color.White;
            this.about_Item.Name = "about_Item";
            this.about_Item.Size = new System.Drawing.Size(221, 24);
            this.about_Item.Text = "About the Program...";
            this.about_Item.Click += new System.EventHandler(this.about_Item_Click);
            // 
            // stat_picBox
            // 
            this.stat_picBox.BackgroundImage = global::KeyLocks_Simple.Properties.Resources.Bxxx;
            this.stat_picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stat_picBox.Location = new System.Drawing.Point(0, 0);
            this.stat_picBox.Name = "stat_picBox";
            this.stat_picBox.Size = new System.Drawing.Size(64, 64);
            this.stat_picBox.TabIndex = 0;
            this.stat_picBox.TabStop = false;
            this.stat_picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(64, 64);
            this.Controls.Add(this.stat_picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(64, 64);
            this.MinimumSize = new System.Drawing.Size(64, 64);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.ShowInTaskbar = false;
            this.Text = "Keyboard LED";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stat_picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox stat_picBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exit_Item;
        private System.Windows.Forms.ToolStripMenuItem hide_Item;
        private System.Windows.Forms.ToolStripMenuItem about_Item;
    }
}

