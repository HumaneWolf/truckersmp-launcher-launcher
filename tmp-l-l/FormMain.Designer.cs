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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonAtsSP = new System.Windows.Forms.Button();
            this.buttonEtsSP = new System.Windows.Forms.Button();
            this.labelSettings = new System.Windows.Forms.Label();
            this.dataGridViewServers = new System.Windows.Forms.DataGridView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelToggleServers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelSettings.Location = new System.Drawing.Point(603, 3);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(53, 13);
            this.labelSettings.TabIndex = 3;
            this.labelSettings.Text = "Settings";
            this.labelSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // dataGridViewServers
            // 
            this.dataGridViewServers.AllowUserToAddRows = false;
            this.dataGridViewServers.AllowUserToDeleteRows = false;
            this.dataGridViewServers.AllowUserToResizeColumns = false;
            this.dataGridViewServers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewServers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewServers.Location = new System.Drawing.Point(920, 0);
            this.dataGridViewServers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewServers.MaximumSize = new System.Drawing.Size(303, 400);
            this.dataGridViewServers.Name = "dataGridViewServers";
            this.dataGridViewServers.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewServers.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewServers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewServers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewServers.ShowEditingIcon = false;
            this.dataGridViewServers.Size = new System.Drawing.Size(303, 400);
            this.dataGridViewServers.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelToggleServers
            // 
            this.labelToggleServers.AutoSize = true;
            this.labelToggleServers.BackColor = System.Drawing.Color.Transparent;
            this.labelToggleServers.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelToggleServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToggleServers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelToggleServers.Location = new System.Drawing.Point(806, 19);
            this.labelToggleServers.Name = "labelToggleServers";
            this.labelToggleServers.Size = new System.Drawing.Size(111, 13);
            this.labelToggleServers.TabIndex = 5;
            this.labelToggleServers.Text = "Toggle Server List";
            this.labelToggleServers.Click += new System.EventHandler(this.labelToggleServers_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1223, 400);
            this.Controls.Add(this.labelToggleServers);
            this.Controls.Add(this.dataGridViewServers);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.buttonEtsSP);
            this.Controls.Add(this.buttonAtsSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TruckersMP Launcher Launcher";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.FormMain_onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonAtsSP;
        private System.Windows.Forms.Button buttonEtsSP;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.DataGridView dataGridViewServers;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelToggleServers;
    }
}

