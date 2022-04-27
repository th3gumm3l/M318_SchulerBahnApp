using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class StationForm : Form
    {
        public StationForm(StartseiteForm startseiteForm)
        {
            InitializeComponent();
            StartseiteForm = startseiteForm;
        }

        public StartseiteForm StartseiteForm { get; }

        private void StationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartseiteForm.Show();
        }
    }
}
