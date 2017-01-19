namespace tmp_l_l
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAtsSP = new System.Windows.Forms.Button();
            this.buttonEtsSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonSettings.Location = new System.Drawing.Point(600, -2);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(64, 23);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonAtsSP
            // 
            this.buttonAtsSP.Location = new System.Drawing.Point(115, 357);
            this.buttonAtsSP.Name = "buttonAtsSP";
            this.buttonAtsSP.Size = new System.Drawing.Size(31, 31);
            this.buttonAtsSP.TabIndex = 1;
            this.buttonAtsSP.Text = "SP";
            this.buttonAtsSP.UseVisualStyleBackColor = true;
            this.buttonAtsSP.Click += new System.EventHandler(this.buttonAtsSP_Click);
            // 
            // buttonEtsSP
            // 
            this.buttonEtsSP.Location = new System.Drawing.Point(774, 357);
            this.buttonEtsSP.Name = "buttonEtsSP";
            this.buttonEtsSP.Size = new System.Drawing.Size(31, 31);
            this.buttonEtsSP.TabIndex = 2;
            this.buttonEtsSP.Text = "SP";
            this.buttonEtsSP.UseVisualStyleBackColor = true;
            this.buttonEtsSP.Click += new System.EventHandler(this.buttonEtsSP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(920, 400);
            this.Controls.Add(this.buttonEtsSP);
            this.Controls.Add(this.buttonAtsSP);
            this.Controls.Add(this.buttonSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TruckersMP Launcher Launcher";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.FormMain_onLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAtsSP;
        private System.Windows.Forms.Button buttonEtsSP;
    }
}

