﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    public partial class StationForm : Form
    {
        public StationForm(StartseiteForm startseiteForm)
        {
            InitializeComponent();
            StartseiteForm = startseiteForm;
        }

        ITransport transport = new Transport();

        public StartseiteForm StartseiteForm { get; }

        private void StationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartseiteForm.Show();
        }

        private void sMainSearch_btn_Click(object sender, EventArgs e)
        {
            sSuchanzeigen_dgv.Rows.Clear();
            
            var stationBoard = transport.GetStationBoard(sStationsuchen_cbx.Text, sStationsuchen_cbx.Text);

            foreach (StationBoard stationBoarditems in stationBoard.Entries)
            {
                sSuchanzeigen_dgv.Rows.Add(

                    stationBoarditems.To,
                    stationBoarditems.Stop.Departure
                    //Mehr Informationen hinzufügen

                    );
            }
        }
    }
}
