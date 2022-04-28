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

            var ConnectionsListe = transport.GetConnections(vSearchAbfahrtsOrt_cbx.Text, vSearchAnkunftsOrt_cbx.Text);

            foreach (Connection connectionitem in ConnectionsListe.ConnectionList)
            {
                vSuchanzeigen_dgv.Rows.Add(
                    connectionitem.From.Station.Name + "\n" + connectionitem.From.Departure,
                    connectionitem.To.Station.Name + "\n" + connectionitem.To.Arrival,
                    connectionitem.Duration,
                    connectionitem.From.Platform,
                    connectionitem.From.Delay
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

            string Abfahrt = row.Cells[0].Value?.ToString();
            string Ankunft = row.Cells[1].Value?.ToString();
            string Dauer = row.Cells[2].Value?.ToString();
            string Gleis = row.Cells[3].Value?.ToString();
            string Verspätung = row.Cells[4].Value?.ToString();

            Mailing mailing = new Mailing(Abfahrt, Ankunft, Dauer, Gleis, Verspätung);

            mailing.OpenMailClientandFillIn();
        }

    }
}
