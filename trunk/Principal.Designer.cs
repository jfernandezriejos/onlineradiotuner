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
            this.flsh_player = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.wMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flsh_player)).BeginInit();
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
            this.notIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notIcon_MouseClick);
            // 
            // flsh_player
            // 
            this.flsh_player.Enabled = true;
            this.flsh_player.Location = new System.Drawing.Point(315, 12);
            this.flsh_player.Name = "flsh_player";
            this.flsh_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flsh_player.OcxState")));
            this.flsh_player.Size = new System.Drawing.Size(560, 370);
            this.flsh_player.TabIndex = 1;
            this.flsh_player.OnReadyStateChange += new AxShockwaveFlashObjects._IShockwaveFlashEvents_OnReadyStateChangeEventHandler(this.flsh_player_OnReadyStateChange);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 447);
            this.Controls.Add(this.flsh_player);
            this.Controls.Add(this.wMediaPlayer);
            this.Name = "Principal";
            this.ShowInTaskbar = false;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.wMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flsh_player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wMediaPlayer;
        private System.Windows.Forms.NotifyIcon notIcon;
        private AxShockwaveFlashObjects.AxShockwaveFlash flsh_player;
    }
}

