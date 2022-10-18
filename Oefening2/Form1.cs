using System;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsEveritingDigit(String text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }

        Stappel1<int> integers = new Stappel1<int>();
        Stappel1<string> strings = new Stappel1<string>();
        Stappel1<Meubel> meubels = new Stappel1<Meubel>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StapelintToevoegen_Click(object sender, EventArgs e)
        {
            if (IsEveritingDigit(StapelIntBox.Text))
            {
                integers.DeStapel(int.Parse(StapelIntBox.Text));

            }
            else
            {
                MessageBox.Show("enkel int toegelaten ! ");
                StapelIntBox.Text = null;
            }

            StapelIntBox.Text = null;
        }

        private void StapelIntVerwijderen_Click(object sender, EventArgs e)
        {
            if (integers.ToString() != string.Empty)
            {
                strings.Delete();
            }
            else
            {
                MessageBox.Show(" De stappel is leeg ! ");
            }
        }

        private void LeegmakenStapelint_Click(object sender, EventArgs e)
        {
            integers.Stapelleegmaken();
        }

        private void ShowListStapelInt_Click(object sender, EventArgs e)
        {
            label1.Text="Integers: " + integers.ToString();
        }

        private void CopyStapelInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" old list : " + integers.ToString() + "\n de nieuwe lijst is : " + " " +
              String.Join(",", integers.lijstCopy()));
        }

        private void toevoegenStapelVanString_Click(object sender, EventArgs e)
        {

            strings.DeStapel(StapelVanStringBox.Text);

            StapelVanStringBox.Text = null;
        }

        private void SearchStapelInt_Click(object sender, EventArgs e)
        {
            if (integers.Aanwezig(int.Parse(StapelIntBox.Text)))
            {

                MessageBox.Show(StapelIntBox.Text + " " + "is aanwezig op de stapel van integers");
            }
            else
            {
                MessageBox.Show("sorry maar " + StapelIntBox.Text + " bestaat niet op de stapel");
            }

            StapelIntBox.Text = null;

        }

        private void CopyStapelVanString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(strings.ToString() + "\n nieuwe lijst is : " + " " +
                String.Join(",", strings.lijstCopy()));
        }

        private void MeubelToevoegen_Click(object sender, EventArgs e)
        {

            if (MeubelBox.Text == string.Empty || TypeMeubel.Text == string.Empty)
            {

                MessageBox.Show("beide velden moeten ingevuld worden ! ");

            }
            else if (IsEveritingDigit(TypeMeubel.Text) == false)
            {
                MessageBox.Show(" leeftijd moet enkel getallen bevatten");
            }

            else
            {
                meubels.DeStapel(new Meubel(MeubelBox.Text, int.Parse(TypeMeubel.Text)));
            }

            MeubelBox.Text = null;
            TypeMeubel.Text = null;
        }

        private void MeubelVerwijderen_Click(object sender, EventArgs e)
        {

            if (meubels.ToString() != string.Empty)
            {
                meubels.Delete();
            }
            else
            {
                MessageBox.Show("sorry maar de stappel is leeg !");
            }
        }

        private void MeubelLeegmaken_Click(object sender, EventArgs e)
        {
            meubels.Stapelleegmaken();
        }

        private void MeubelShowList_Click(object sender, EventArgs e)
        {
            label3.Text = meubels.ToString();
        }

        private void MeubelSearch_Click(object sender, EventArgs e)
        {
            if (meubels.Aanwezig(new Meubel(MeubelBox.Text, int.Parse(PrijsBox.Text))))
            {
                MessageBox.Show(" de persoon met naam : " + " " + MeubelBox.Text + " en met leeftijd : " + " " + PrijsBox.Text + " " + "is aanwezig in de lijst van personen");
            }
            else
            {
                MessageBox.Show("de persoon met naam : " + " " + MeubelBox.Text + " " + "bestaat niet in de lijst");
            }
        }

        private void MeubelCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" oude lijste : " + meubels.ToString() + "\n nieuwe lijst is : " + " " +
              String.Join(":", meubels.lijstCopy()));
        }
    }
}