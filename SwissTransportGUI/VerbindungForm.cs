using System;
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
using System.Net.Mail;

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

            var ConnectionsListe = transport.GetConnections(vSearchAbfahrtsOrt_cbx.Text, vSearchAnkunftsOrt_cbx.Text, datePicker.Value, timePicker.Value);

            foreach (Connection connectionitem in ConnectionsListe.ConnectionList)
            {
                vSuchanzeigen_dgv.Rows.Add(
                    connectionitem.From.Station.Name + "\n" + connectionitem.From.Departure,
                    connectionitem.To.Station.Name + "\n" + connectionitem.To.Arrival,
                    connectionitem.Duration,
                    connectionitem.From.Platform
                    );
            }
        }

        private void VerbindungForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartseiteForm.Show();
        }

        private void vSuchanzeigen_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vSuchanzeigen_dgv.Columns[e.ColumnIndex].Name != "Teilen_colBtn")
            {
                return;
            }

            var row = vSuchanzeigen_dgv.Rows[e.RowIndex];

            string? Abfahrt = row.Cells[0].Value?.ToString();
            string? Ankunft = row.Cells[1].Value?.ToString();
            string? Dauer = row.Cells[2].Value?.ToString();
            string? Gleis = row.Cells[3].Value?.ToString();
            string? Verspätung = row.Cells[4].Value?.ToString();

            Mailing mailing = new Mailing(Abfahrt, Ankunft, Dauer, Gleis, Verspätung);

            mailing.OpenMailClientandFillIn();
        }

        private void Autosuggestions(ComboBox comboBox)
        {
            try
            {
                comboBox.Items.Clear();
                comboBox.SelectionStart = comboBox.Text.Length + 1;
                var stations = transport.GetStations(comboBox.Text);

                foreach (Station stationitem in stations.StationList)
                {
                    comboBox.Items.Add(stationitem.Name);
                }
            }

            catch
            {
                comboBox.Items.Clear();
                comboBox.SelectionStart = comboBox.Text.Length + 1;
                comboBox.Items.Add("Du bisch en Löli");
            }

        }

        private void vSearchAbfahrtsOrt_cbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Autosuggestions(vSearchAbfahrtsOrt_cbx);
            }
        }

        private void vSearchAnkunftsOrt_cbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Autosuggestions(vSearchAnkunftsOrt_cbx);
            }
        }

        private void vSearchAbfahrtsOrt_cbx_Enter(object sender, EventArgs e)
        {
            vSearchAbfahrtsOrt_cbx.DroppedDown = true;
        }

        private void vSearchAnkunftsOrt_cbx_Enter(object sender, EventArgs e)
        {
            vSearchAnkunftsOrt_cbx.DroppedDown = true;
        }

        private void vSearchAbfahrtsOrt_cbx_Leave(object sender, EventArgs e)
        {
            vSearchAbfahrtsOrt_cbx.DroppedDown = false;
        }

        private void vSearchAnkunftsOrt_cbx_Leave(object sender, EventArgs e)
        {
            vSearchAnkunftsOrt_cbx.DroppedDown = false;
        }
    }
}
