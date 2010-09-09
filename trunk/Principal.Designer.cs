namespace OnlineRadioTunner
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.wMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.notIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.wMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // wMediaPlayer
            // 
            this.wMediaPlayer.Enabled = true;
            this.wMediaPlayer.Location = new System.Drawing.Point(22, 146);
            this.wMediaPlayer.Name = "wMediaPlayer";
            this.wMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wMediaPlayer.OcxState")));
            this.wMediaPlayer.Size = new System.Drawing.Size(280, 133);
            this.wMediaPlayer.TabIndex = 0;
            this.wMediaPlayer.StatusChange += new System.EventHandler(this.wMediaPlayer_StatusChange);
            // 
            // notIcon
            // 
            this.notIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notIcon.Icon")));
            this.notIcon.Text = "OnLineRadioTunner";
            this.notIcon.Visible = true;
            // 
            // ctxMenu
            // 
            this.ctxMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "Radio Marca";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Sevilla";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.menuItem3.Text = "Onda Cero";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Sevilla";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 346);
            this.Controls.Add(this.wMediaPlayer);
            this.Name = "Principal";
            this.ShowInTaskbar = false;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.wMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wMediaPlayer;
        private System.Windows.Forms.NotifyIcon notIcon;
        private System.Windows.Forms.ContextMenu ctxMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
    }
}

