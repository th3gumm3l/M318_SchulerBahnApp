namespace SwissTransportGUI
{
    partial class VerbindungForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerbindungForm));
            this.Suchanzeigen_gpbx = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchAbfahrtsOrt_cbx = new System.Windows.Forms.ComboBox();
            this.SearchAnkunftsOrt_cbx = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVerb = new System.Windows.Forms.DateTimePicker();
            this.MainSearch_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Suchanzeigen_gpbx
            // 
            this.Suchanzeigen_gpbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Suchanzeigen_gpbx.Location = new System.Drawing.Point(12, 376);
            this.Suchanzeigen_gpbx.Name = "Suchanzeigen_gpbx";
            this.Suchanzeigen_gpbx.Size = new System.Drawing.Size(1870, 612);
            this.Suchanzeigen_gpbx.TabIndex = 0;
            this.Suchanzeigen_gpbx.TabStop = false;
            this.Suchanzeigen_gpbx.Text = "Suchanzeigen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainSearch_btn);
            this.panel1.Controls.Add(this.dateTimePickerVerb);
            this.panel1.Controls.Add(this.SearchAnkunftsOrt_cbx);
            this.panel1.Controls.Add(this.SearchAbfahrtsOrt_cbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1894, 370);
            this.panel1.TabIndex = 1;
            // 
            // SearchAbfahrtsOrt_cbx
            // 
            this.SearchAbfahrtsOrt_cbx.FormattingEnabled = true;
            this.SearchAbfahrtsOrt_cbx.Location = new System.Drawing.Point(121, 156);
            this.SearchAbfahrtsOrt_cbx.Name = "SearchAbfahrtsOrt_cbx";
            this.SearchAbfahrtsOrt_cbx.Size = new System.Drawing.Size(360, 40);
            this.SearchAbfahrtsOrt_cbx.TabIndex = 0;
            this.SearchAbfahrtsOrt_cbx.Text = "Abfahrtsort";
            // 
            // SearchAnkunftsOrt_cbx
            // 
            this.SearchAnkunftsOrt_cbx.FormattingEnabled = true;
            this.SearchAnkunftsOrt_cbx.Location = new System.Drawing.Point(620, 156);
            this.SearchAnkunftsOrt_cbx.Name = "SearchAnkunftsOrt_cbx";
            this.SearchAnkunftsOrt_cbx.Size = new System.Drawing.Size(360, 40);
            this.SearchAnkunftsOrt_cbx.TabIndex = 1;
            this.SearchAnkunftsOrt_cbx.Text = "Ankunftsort";
            // 
            // dateTimePickerVerb
            // 
            this.dateTimePickerVerb.Location = new System.Drawing.Point(1101, 154);
            this.dateTimePickerVerb.Name = "dateTimePickerVerb";
            this.dateTimePickerVerb.Size = new System.Drawing.Size(462, 39);
            this.dateTimePickerVerb.TabIndex = 2;
            // 
            // MainSearch_btn
            // 
            this.MainSearch_btn.Location = new System.Drawing.Point(1590, 284);
            this.MainSearch_btn.Name = "MainSearch_btn";
            this.MainSearch_btn.Size = new System.Drawing.Size(292, 68);
            this.MainSearch_btn.TabIndex = 3;
            this.MainSearch_btn.Text = "Suchen";
            this.MainSearch_btn.UseVisualStyleBackColor = true;
            // 
            // VerbindungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Suchanzeigen_gpbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerbindungForm";
            this.Text = "Verbindungen suchen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerbindungForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Suchanzeigen_gpbx;
        private Panel panel1;
        private ComboBox SearchAbfahrtsOrt_cbx;
        private ComboBox SearchAnkunftsOrt_cbx;
        private Button MainSearch_btn;
        private DateTimePicker dateTimePickerVerb;
    }
}