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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Abfahrt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumUhrzeit_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainSearch_btn = new System.Windows.Forms.Button();
            this.dateTimePickerVerb = new System.Windows.Forms.DateTimePicker();
            this.SearchAnkunftsOrt_cbx = new System.Windows.Forms.ComboBox();
            this.SearchAbfahrtsOrt_cbx = new System.Windows.Forms.ComboBox();
            this.Suchanzeigen_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Suchanzeigen_gpbx
            // 
            this.Suchanzeigen_gpbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Suchanzeigen_gpbx.Controls.Add(this.dataGridView1);
            this.Suchanzeigen_gpbx.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Suchanzeigen_gpbx.Location = new System.Drawing.Point(12, 376);
            this.Suchanzeigen_gpbx.Name = "Suchanzeigen_gpbx";
            this.Suchanzeigen_gpbx.Size = new System.Drawing.Size(1870, 612);
            this.Suchanzeigen_gpbx.TabIndex = 0;
            this.Suchanzeigen_gpbx.TabStop = false;
            this.Suchanzeigen_gpbx.Text = "Suchanzeigen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt_col,
            this.Ankunft_col,
            this.DatumUhrzeit_col,
            this.Gleis_col});
            this.dataGridView1.Location = new System.Drawing.Point(8, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1842, 552);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            // 
            // Abfahrt_col
            // 
            this.Abfahrt_col.HeaderText = "Abfahrtsort";
            this.Abfahrt_col.MinimumWidth = 10;
            this.Abfahrt_col.Name = "Abfahrt_col";
            this.Abfahrt_col.ReadOnly = true;
            // 
            // Ankunft_col
            // 
            this.Ankunft_col.HeaderText = "Ankuftsort";
            this.Ankunft_col.MinimumWidth = 10;
            this.Ankunft_col.Name = "Ankunft_col";
            this.Ankunft_col.ReadOnly = true;
            // 
            // DatumUhrzeit_col
            // 
            this.DatumUhrzeit_col.HeaderText = "Datum & Uhrzeit";
            this.DatumUhrzeit_col.MinimumWidth = 10;
            this.DatumUhrzeit_col.Name = "DatumUhrzeit_col";
            this.DatumUhrzeit_col.ReadOnly = true;
            // 
            // Gleis_col
            // 
            this.Gleis_col.HeaderText = "Gleis";
            this.Gleis_col.MinimumWidth = 10;
            this.Gleis_col.Name = "Gleis_col";
            this.Gleis_col.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MainSearch_btn);
            this.panel1.Controls.Add(this.dateTimePickerVerb);
            this.panel1.Controls.Add(this.SearchAnkunftsOrt_cbx);
            this.panel1.Controls.Add(this.SearchAbfahrtsOrt_cbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1894, 370);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Geben Sie ihre gewünschte Verbindung ein";
            // 
            // MainSearch_btn
            // 
            this.MainSearch_btn.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainSearch_btn.Location = new System.Drawing.Point(1590, 284);
            this.MainSearch_btn.Name = "MainSearch_btn";
            this.MainSearch_btn.Size = new System.Drawing.Size(292, 68);
            this.MainSearch_btn.TabIndex = 3;
            this.MainSearch_btn.Text = "Suchen";
            this.MainSearch_btn.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerVerb
            // 
            this.dateTimePickerVerb.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerVerb.Location = new System.Drawing.Point(1101, 154);
            this.dateTimePickerVerb.Name = "dateTimePickerVerb";
            this.dateTimePickerVerb.Size = new System.Drawing.Size(462, 39);
            this.dateTimePickerVerb.TabIndex = 2;
            // 
            // SearchAnkunftsOrt_cbx
            // 
            this.SearchAnkunftsOrt_cbx.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchAnkunftsOrt_cbx.FormattingEnabled = true;
            this.SearchAnkunftsOrt_cbx.Location = new System.Drawing.Point(620, 156);
            this.SearchAnkunftsOrt_cbx.Name = "SearchAnkunftsOrt_cbx";
            this.SearchAnkunftsOrt_cbx.Size = new System.Drawing.Size(360, 36);
            this.SearchAnkunftsOrt_cbx.TabIndex = 1;
            this.SearchAnkunftsOrt_cbx.Text = "Ankunftsort";
            // 
            // SearchAbfahrtsOrt_cbx
            // 
            this.SearchAbfahrtsOrt_cbx.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchAbfahrtsOrt_cbx.FormattingEnabled = true;
            this.SearchAbfahrtsOrt_cbx.Location = new System.Drawing.Point(121, 156);
            this.SearchAbfahrtsOrt_cbx.Name = "SearchAbfahrtsOrt_cbx";
            this.SearchAbfahrtsOrt_cbx.Size = new System.Drawing.Size(360, 36);
            this.SearchAbfahrtsOrt_cbx.TabIndex = 0;
            this.SearchAbfahrtsOrt_cbx.Text = "Abfahrtsort";
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
            this.Text = "Schuler BahnApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerbindungForm_FormClosing);
            this.Suchanzeigen_gpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Suchanzeigen_gpbx;
        private Panel panel1;
        private ComboBox SearchAbfahrtsOrt_cbx;
        private ComboBox SearchAnkunftsOrt_cbx;
        private Button MainSearch_btn;
        private DateTimePicker dateTimePickerVerb;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Abfahrt_col;
        private DataGridViewTextBoxColumn Ankunft_col;
        private DataGridViewTextBoxColumn DatumUhrzeit_col;
        private DataGridViewTextBoxColumn Gleis_col;
        private Label label1;
    }
}