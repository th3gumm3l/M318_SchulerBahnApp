﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    public partial class VerbindungForm : Form
    {
        public VerbindungForm(StartseiteForm startseiteForm)
        {
            InitializeComponent();
            StartseiteForm = startseiteForm;
        }

        ITransport transport = new Transport();
        
        public StartseiteForm StartseiteForm { get; }


        private void vMainSearch_btn_Click(object sender, EventArgs e)
        {
            vSuchanzeigen_dgv.Rows.Clear();

            //vSearchAbfahrtsOrt_cbx.AutoCompleteMode = AutoCompleteMode.Suggest;
            //vSearchAbfahrtsOrt_cbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            //vSearchAnkunftsOrt_cbx.AutoCompleteMode = AutoCompleteMode.Suggest;
            //vSearchAnkunftsOrt_cbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            var ConnectionsListe = transport.GetConnections(vSearchAbfahrtsOrt_cbx.Text, vSearchAnkunftsOrt_cbx.Text);

            foreach (Connection connectionitems in ConnectionsListe.ConnectionList)
            {
                vSuchanzeigen_dgv.Rows.Add(
                    connectionitems.From.Station.Name + "\n" + connectionitems.From.Departure,
                    connectionitems.To.Station.Name + "\n" + connectionitems.To.Arrival,
                    connectionitems.Duration,
                    connectionitems.From.Platform,
                    connectionitems.From.Delay
                    );
            }
        }


        private void VerbindungForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartseiteForm.Show();
        }

        private void vSuchanzeigen_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vSuchanzeigen_dgv.Columns[e.ColumnIndex].Name == "Teilen_colBtn")
            {
                //Mail Support
            }
        }
    }
}
