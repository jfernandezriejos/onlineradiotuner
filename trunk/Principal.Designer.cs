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
            this.notIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notIcon_MouseClick);
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
    }
}

