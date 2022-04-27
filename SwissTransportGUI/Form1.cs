namespace SwissTransportGUI
{
    public partial class StartseiteForm : Form
    {
        public StartseiteForm()
        {
            InitializeComponent();
        }

        private void Verbindungen_btn_Click(object sender, EventArgs e)
        {
            var verbindungForm = new VerbindungForm(this);
            verbindungForm.Show();

            this.Hide();
        }
    }
}