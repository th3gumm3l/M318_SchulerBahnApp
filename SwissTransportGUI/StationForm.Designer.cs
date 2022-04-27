﻿namespace SwissTransportGUI
{
    partial class StationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sMainSearch_btn = new System.Windows.Forms.Button();
            this.Stationsuchen_cbx = new System.Windows.Forms.ComboBox();
            this.sSuchanzeigen_gpbx = new System.Windows.Forms.GroupBox();
            this.sSuchanzeigen_dgv = new System.Windows.Forms.DataGridView();
            this.Abfahrtsort_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UhrzeitDatum_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.sSuchanzeigen_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sSuchanzeigen_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sMainSearch_btn);
            this.panel1.Controls.Add(this.Stationsuchen_cbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 358);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geben Sie ihre Station ein";
            // 
            // sMainSearch_btn
            // 
            this.sMainSearch_btn.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sMainSearch_btn.Location = new System.Drawing.Point(558, 226);
            this.sMainSearch_btn.Name = "sMainSearch_btn";
            this.sMainSearch_btn.Size = new System.Drawing.Size(186, 70);
            this.sMainSearch_btn.TabIndex = 1;
            this.sMainSearch_btn.Text = "Suchen";
            this.sMainSearch_btn.UseVisualStyleBackColor = true;
            this.sMainSearch_btn.Click += new System.EventHandler(this.sMainSearch_btn_Click);
            // 
            // Stationsuchen_cbx
            // 
            this.Stationsuchen_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Stationsuchen_cbx.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stationsuchen_cbx.FormattingEnabled = true;
            this.Stationsuchen_cbx.Location = new System.Drawing.Point(415, 140);
            this.Stationsuchen_cbx.Name = "Stationsuchen_cbx";
            this.Stationsuchen_cbx.Size = new System.Drawing.Size(486, 36);
            this.Stationsuchen_cbx.TabIndex = 0;
            this.Stationsuchen_cbx.Text = "Station eingeben";
            // 
            // sSuchanzeigen_gpbx
            // 
            this.sSuchanzeigen_gpbx.Controls.Add(this.sSuchanzeigen_dgv);
            this.sSuchanzeigen_gpbx.Location = new System.Drawing.Point(12, 364);
            this.sSuchanzeigen_gpbx.Name = "sSuchanzeigen_gpbx";
            this.sSuchanzeigen_gpbx.Size = new System.Drawing.Size(1306, 714);
            this.sSuchanzeigen_gpbx.TabIndex = 1;
            this.sSuchanzeigen_gpbx.TabStop = false;
            this.sSuchanzeigen_gpbx.Text = "Suchanzeigen";
            // 
            // sSuchanzeigen_dgv
            // 
            this.sSuchanzeigen_dgv.AllowUserToAddRows = false;
            this.sSuchanzeigen_dgv.AllowUserToDeleteRows = false;
            this.sSuchanzeigen_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sSuchanzeigen_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sSuchanzeigen_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtsort_col,
            this.Ankunftsort_col,
            this.UhrzeitDatum_col,
            this.Gleis_col});
            this.sSuchanzeigen_dgv.Location = new System.Drawing.Point(6, 38);
            this.sSuchanzeigen_dgv.Name = "sSuchanzeigen_dgv";
            this.sSuchanzeigen_dgv.ReadOnly = true;
            this.sSuchanzeigen_dgv.RowHeadersWidth = 82;
            this.sSuchanzeigen_dgv.RowTemplate.Height = 41;
            this.sSuchanzeigen_dgv.Size = new System.Drawing.Size(1285, 670);
            this.sSuchanzeigen_dgv.TabIndex = 0;
            // 
            // Abfahrtsort_col
            // 
            this.Abfahrtsort_col.HeaderText = "Abfahrtsort";
            this.Abfahrtsort_col.MinimumWidth = 10;
            this.Abfahrtsort_col.Name = "Abfahrtsort_col";
            this.Abfahrtsort_col.ReadOnly = true;
            this.Abfahrtsort_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Abfahrtsort_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Ankunftsort_col
            // 
            this.Ankunftsort_col.HeaderText = "Ankunftsort";
            this.Ankunftsort_col.MinimumWidth = 10;
            this.Ankunftsort_col.Name = "Ankunftsort_col";
            this.Ankunftsort_col.ReadOnly = true;
            this.Ankunftsort_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ankunftsort_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // UhrzeitDatum_col
            // 
            this.UhrzeitDatum_col.HeaderText = "Uhrzeit & Datum";
            this.UhrzeitDatum_col.MinimumWidth = 10;
            this.UhrzeitDatum_col.Name = "UhrzeitDatum_col";
            this.UhrzeitDatum_col.ReadOnly = true;
            this.UhrzeitDatum_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UhrzeitDatum_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Gleis_col
            // 
            this.Gleis_col.HeaderText = "Gleis";
            this.Gleis_col.MinimumWidth = 10;
            this.Gleis_col.Name = "Gleis_col";
            this.Gleis_col.ReadOnly = true;
            this.Gleis_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gleis_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 1090);
            this.Controls.Add(this.sSuchanzeigen_gpbx);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StationForm";
            this.Text = "Schuber BahnApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StationForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sSuchanzeigen_gpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sSuchanzeigen_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox Stationsuchen_cbx;
        private GroupBox sSuchanzeigen_gpbx;
        private DataGridView sSuchanzeigen_dgv;
        private DataGridViewTextBoxColumn Abfahrtsort_col;
        private DataGridViewTextBoxColumn Ankunftsort_col;
        private DataGridViewTextBoxColumn UhrzeitDatum_col;
        private DataGridViewTextBoxColumn Gleis_col;
        private Button sMainSearch_btn;
        private Label label1;
    }
}