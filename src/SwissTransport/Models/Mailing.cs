namespace SwissTransport.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mailing
    {
        private string _Abfahrtsort;
        private string _Ankunftsort;
        private string _Dauer;
        private string _Gleis;
        private string _Verspaetung;

        public Mailing(string Abfahrtsort, string Ankunftsort, string Dauer, string Gleis, string Verspaetung)
        {
            this._Abfahrtsort = Abfahrtsort;
            this._Ankunftsort = Ankunftsort;
            this._Dauer = Dauer;
            this._Gleis = Gleis;
            this._Verspaetung = Verspaetung;
        }

        public string Url
        {
            get
            {
                return $"mailto:{"mail@domain.com"}?subject={"Informationen für die Verbindung"}" +
                    $"&body=Abfahrtsort ={this._Abfahrtsort} \n Ankunftsort ={this._Ankunftsort} \n " +
                    $"Dauer ={this._Dauer} \n Gleis ={this._Gleis}\n Verspätung ={this._Verspaetung}";
            }
        }

        public void OpenMailClientandFillIn()
        {
            Process.Start(new ProcessStartInfo(this.Url) { UseShellExecute = true });
        }
    }
}
