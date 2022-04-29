using System;
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

            foreach (StationBoard stationBoarditem in stationBoard.Entries)
            {
                sSuchanzeigen_dgv.Rows.Add(

                    stationBoarditem.To,
                    stationBoarditem.Stop.Departure
                    );
            }
        }

        private void Autosuggestions(ComboBox comboBoxobjekt)
        {
            try
            {
                comboBoxobjekt.Items.Clear();
                comboBoxobjekt.SelectionStart = comboBoxobjekt.Text.Length + 1;
                var stations = transport.GetStations(comboBoxobjekt.Text);

                foreach (Station stationitem in stations.StationList)
                {
                    comboBoxobjekt.Items.Add(stationitem.Name);
                }
            }

            catch
            {
                comboBoxobjekt.Items.Clear();
                comboBoxobjekt.SelectionStart = comboBoxobjekt.Text.Length + 1;
                comboBoxobjekt.Items.Add("Keine Ergebnisse");
            }

        }

        private void sStationsuchen_cbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Autosuggestions(sStationsuchen_cbx);
            }
        }

        private void sStationsuchen_cbx_Enter(object sender, EventArgs e)
        {
            sStationsuchen_cbx.DroppedDown = true;
        }

        private void sStationsuchen_cbx_Leave(object sender, EventArgs e)
        {
            sStationsuchen_cbx.DroppedDown = false;
        }

    }
}
