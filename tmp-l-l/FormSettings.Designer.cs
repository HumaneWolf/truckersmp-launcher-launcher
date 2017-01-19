namespace tmp_l_l
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.skipIntro = new System.Windows.Forms.CheckBox();
            this.graphics = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.parameters = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // skipIntro
            // 
            this.skipIntro.AutoSize = true;
            this.skipIntro.Location = new System.Drawing.Point(48, 112);
            this.skipIntro.Name = "skipIntro";
            this.skipIntro.Size = new System.Drawing.Size(112, 17);
            this.skipIntro.TabIndex = 1;
            this.skipIntro.Text = "Skip Intro (nointro)";
            this.skipIntro.UseVisualStyleBackColor = true;
            // 
            // graphics
            // 
            this.graphics.FormattingEnabled = true;
            this.graphics.Location = new System.Drawing.Point(48, 160);
            this.graphics.Name = "graphics";
            this.graphics.Size = new System.Drawing.Size(211, 21);
            this.graphics.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Launch Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Graphics engine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Other parameters";
            // 
            // parameters
            // 
            this.parameters.Location = new System.Drawing.Point(48, 216);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(211, 20);
            this.parameters.TabIndex = 6;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(48, 248);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(184, 248);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 8;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "By HumaneWolf - © humanewolf.com 2017";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 302);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.Controls.Add(this.parameters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.graphics);
            this.Controls.Add(this.skipIntro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "Settings - TruckersMP Launcher Launcher";
            this.Load += new System.EventHandler(this.FormSettings_onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox skipIntro;
        private System.Windows.Forms.ComboBox graphics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parameters;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label5;
    }
}