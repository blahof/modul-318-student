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


namespace SwissTransport_Gui
{
    

    public partial class Form1 : Form
    {
        /// <summary>
        /// Konstruktor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            lbAusgabe.Items.Clear();
            Transport t = new Transport();
            Connections connections = t.GetConnections(cboxStart.Text, cboxZiel.Text);

            string kopfzeile = "Von: \t";
            kopfzeile += "Abfahrt: \t\t" ;
            kopfzeile += "Nach:" + "   ";
            kopfzeile += "Ankunft:";
            lbAusgabe.Items.Add(kopfzeile);
            lbAusgabe.Items.Add(" ");

            for (int i = 0; i < connections.ConnectionList.Count; i++)
            {
                Connection c = connections.ConnectionList[i];

                DateTime abfahrt = DateTime.Parse(c.From.Departure);
                DateTime ankunft = DateTime.Parse(c.To.Arrival);
               

                string output = c.From.Station.Name + "\t"
                    + abfahrt + "\t"
                    + c.To.Station.Name + "\t"
                    + ankunft  +"\t";


                lbAusgabe.Items.Add(output);

            }

        }

        private void cboxStart_DropDown(object sender, EventArgs e)
        {

            SearchAndFillComboBox(cboxStart);


        }

        private void cboxZiel_DropDown(Object sender, EventArgs e)
        {

            SearchAndFillComboBox(cboxZiel);

        }


        private void SearchAndFillComboBox(ComboBox cbo)
        {
            cbo.Items.Clear();
            Transport t = new Transport();

            string searchCrit = cbo.Text + ",";

            Stations stations = t.GetStations(searchCrit);

            for (int i = 0; i < stations.StationList.Count; i++)
            {
                Station station = stations.StationList[i];
                string stationName = station.Name;
                cbo.Items.Add(stationName);
            }

        }

       private void btnVerbindungenAnzeigen_Click(object sender, EventArgs e)
        { Transport t = new Transport(); 
            Station station = t.GetStations(cboxStart.Text).StationList.First();
            StationBoardRoot departures = t.GetStationBoard(station.Name, station.Id);

            lbAusgabe.Items.Clear();

            string kopfzeile = "Nr\t\t";
            kopfzeile += "Zielort\t\t\t"+"  ";
            kopfzeile += "Datum & Zeit\t"+"     ";
            kopfzeile += "Ges.";
            lbAusgabe.Items.Add(kopfzeile);
            lbAusgabe.Items.Add(" ");


                foreach (StationBoard sta in departures.Entries)
                {
                    string zeile = Verbreitern(sta.Name, 15, " ");


                    zeile += Verbreitern (sta.To, 25, " ");
                    zeile +=Verbreitern( sta.Stop.Departure.ToShortDateString() + " " + sta.Stop.Departure.ToShortTimeString(), 18," ") ;
                    zeile += sta.Operator;

                    lbAusgabe.Items.Add(zeile);
                }
                
                
            
        }

        
        private string Verbreitern(string s, int weite, string mit)
        {
            string resultat = s;
            for (int i = s.Length; i <= weite; i++)
            {
                resultat += mit;
            }

            return resultat;

        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
