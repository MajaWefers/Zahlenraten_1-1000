using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Zahlenraten : Form
    {
        public Zahlenraten()
        {
            InitializeComponent();
        }

        Random Zufall = new Random();
        int Zufallszahl;

        int zaehler = 0;

        private void Erzeugen()
        {
            Zufallszahl = Zufall.Next(0, 1000);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Refresh();
            /*int zaehler_start = 1;
            zaehler_start++;
            if (zaehler_start == 1)
            {*/
                gbZahleingabe.Visible = true;
                Werte_bisher.Visible = true;
                Werte_aus_ein.Visible = true;
                lblErmittlung.Visible = true;
                Erzeugen();
                txtEingabe.Focus();
            /*}
            else
            {
                Zahlenraten neu = new Zahlenraten();
                this.Dispose();
                neu.Show();
            }*/
        }


        private void btnEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Hinzufügen einer Zeile zur ListView
        private void add_item(string versuch, string kleiner, string groesser)
        {
            //string[] row = { versuch, kleiner, groesser };
            ListViewItem row = new ListViewItem(versuch);
            row.SubItems.Add(kleiner);
            row.SubItems.Add(groesser);
            Werte_bisher.Items.Add(row);
            Werte_bisher.EnsureVisible(Werte_bisher.Items.Count -1);
        }

        private void txtEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Signalton unterdrücken
                e.SuppressKeyPress = true;

                int eingabe = 0;
                bool erfolg = false;

                //Farbfestlegung der Lable-Texte
                lblRate_groesser.ForeColor = Color.Blue;
                lblRate_kleiner.ForeColor = Color.Blue;
                lblErraten.ForeColor = Color.Green;
                lblFalsch.ForeColor = Color.Red;

                try
                {
                    eingabe = Convert.ToInt32(txtEingabe.Text);
                    erfolg = true;
                }
                catch(Exception)
                {
                    lblFalsch.Text = "Unzulässige Eingabe!";
                    lblFalsch.Visible = true;
                    txtEingabe.Clear();
                    eingabe = 0;
                    //lblEingabe.Visible = false;
                    lblRate_groesser.Visible = false;
                    lblRate_kleiner.Visible = false;
                }

                if (eingabe > 1000 || eingabe < 0)
                {
                    lblFalsch.Text = "0 < x < 1000!";
                    lblFalsch.Visible = true;
                    txtEingabe.Clear();
                    eingabe = 0;
                    //lblEingabe.Visible = false;
                    lblRate_groesser.Visible = false;
                    lblRate_kleiner.Visible = false;
                    erfolg = false;
                }

                if (erfolg == true)
                {
                    zaehler++;

                    lblFalsch.Visible = false;
                        
                    if (eingabe > Zufallszahl)
                    {
                        lblRate_groesser.Visible = false;
                        lblRate_kleiner.Text = " ist groesser als die gesuchte Zahl.";
                        lblRate_kleiner.Text = eingabe + lblRate_kleiner.Text;
                        lblRate_kleiner.Visible = true;

                        add_item(Convert.ToString(zaehler),"",Convert.ToString(eingabe));
                        txtEingabe.Clear();
                    }
                    
                    if (eingabe < Zufallszahl)
                    {
                        lblRate_kleiner.Visible = false;
                        lblRate_groesser.Text = " ist kleiner als die gesuchte Zahl.";
                        lblRate_groesser.Text = eingabe + lblRate_groesser.Text;
                        lblRate_groesser.Visible = true;
                        add_item(Convert.ToString(zaehler), Convert.ToString(eingabe),"");
                        txtEingabe.Clear();
                    }
                        
                    if (eingabe == Zufallszahl)
                    {
                        lblRate_groesser.Visible = false;
                        lblRate_kleiner.Visible = false;
                        //lblEingabe.Visible = false;
                        lblErraten.Text += Zufallszahl;
                        lblErraten.Visible = true;
                        txtEingabe.Clear();
                        lblVersuche.Text += zaehler;
                        lblVersuche.Visible = true;
                    }
                }       //erfolg == true
            }       //e.KeyCode == Keys.Enter

        }       // private void txtEingabe_KeyDown

        private void Werte_aus_ein_Click(object sender, EventArgs e)
        {
            Werte_bisher.Visible = !Werte_bisher.Visible;
        }
    }




        /*private void Name1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }*/
}
