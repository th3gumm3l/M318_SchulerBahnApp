namespace SwissTransportGUI
{
    partial class StartseiteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartseiteForm));
            this.SbbLogoPic_imgbx = new System.Windows.Forms.PictureBox();
            this.Verbindungen_btn = new System.Windows.Forms.Button();
            this.Stationen_btn = new System.Windows.Forms.Button();
            this.StationinNähe_btn = new System.Windows.Forms.Button();
            this.LetzteReisen_lbx = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.SbbLogoPic_imgbx)).BeginInit();
            this.SuspendLayout();
            // 
            // SbbLogoPic_imgbx
            // 
            this.SbbLogoPic_imgbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SbbLogoPic_imgbx.Image = ((System.Drawing.Image)(resources.GetObject("SbbLogoPic_imgbx.Image")));
            this.SbbLogoPic_imgbx.Location = new System.Drawing.Point(79, 34);
            this.SbbLogoPic_imgbx.Name = "SbbLogoPic_imgbx";
            this.SbbLogoPic_imgbx.Size = new System.Drawing.Size(800, 270);
            this.SbbLogoPic_imgbx.TabIndex = 0;
            this.SbbLogoPic_imgbx.TabStop = false;
            // 
            // Verbindungen_btn
            // 
            this.Verbindungen_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Verbindungen_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Verbindungen_btn.FlatAppearance.BorderSize = 0;
            this.Verbindungen_btn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Verbindungen_btn.Location = new System.Drawing.Point(79, 334);
            this.Verbindungen_btn.Name = "Verbindungen_btn";
            this.Verbindungen_btn.Size = new System.Drawing.Size(380, 250);
            this.Verbindungen_btn.TabIndex = 1;
            this.Verbindungen_btn.Text = "Verbindungen suchen";
            this.Verbindungen_btn.UseVisualStyleBackColor = false;
            this.Verbindungen_btn.Click += new System.EventHandler(this.Verbindungen_btn_Click);
            // 
            // Stationen_btn
            // 
            this.Stationen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stationen_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Stationen_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Stationen_btn.FlatAppearance.BorderSize = 0;
            this.Stationen_btn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stationen_btn.Location = new System.Drawing.Point(499, 334);
            this.Stationen_btn.Name = "Stationen_btn";
            this.Stationen_btn.Size = new System.Drawing.Size(380, 250);
            this.Stationen_btn.TabIndex = 2;
            this.Stationen_btn.Text = "Stationen suchen";
            this.Stationen_btn.UseVisualStyleBackColor = false;
            this.Stationen_btn.Click += new System.EventHandler(this.Stationen_btn_Click);
            // 
            // StationinNähe_btn
            // 
            this.StationinNähe_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StationinNähe_btn.BackColor = System.Drawing.SystemColors.Control;
            this.StationinNähe_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.StationinNähe_btn.FlatAppearance.BorderSize = 0;
            this.StationinNähe_btn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StationinNähe_btn.Location = new System.Drawing.Point(79, 608);
            this.StationinNähe_btn.Name = "StationinNähe_btn";
            this.StationinNähe_btn.Size = new System.Drawing.Size(380, 250);
            this.StationinNähe_btn.TabIndex = 3;
            this.StationinNähe_btn.Text = "Stationen in der Nähe";
            this.StationinNähe_btn.UseVisualStyleBackColor = false;
            // 
            // LetzteReisen_lbx
            // 
            this.LetzteReisen_lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LetzteReisen_lbx.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LetzteReisen_lbx.FormattingEnabled = true;
            this.LetzteReisen_lbx.ItemHeight = 28;
            this.LetzteReisen_lbx.Location = new System.Drawing.Point(499, 608);
            this.LetzteReisen_lbx.Name = "LetzteReisen_lbx";
            this.LetzteReisen_lbx.Size = new System.Drawing.Size(380, 508);
            this.LetzteReisen_lbx.TabIndex = 4;
            // 
            // StartseiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 1172);
            this.Controls.Add(this.LetzteReisen_lbx);
            this.Controls.Add(this.StationinNähe_btn);
            this.Controls.Add(this.Stationen_btn);
            this.Controls.Add(this.Verbindungen_btn);
            this.Controls.Add(this.SbbLogoPic_imgbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartseiteForm";
            this.Text = "Schuler BahnApp";
            ((System.ComponentModel.ISupportInitialize)(this.SbbLogoPic_imgbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox SbbLogoPic_imgbx;
        private Button Verbindungen_btn;
        private Button Stationen_btn;
        private Button StationinNähe_btn;
        private ListBox LetzteReisen_lbx;
    }
}