using Librarie_Modele;
using NivelAcces;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata_Utilizator.Aditional_Forms.Dulciurii
{
    public partial class AddDulce : Form
    {
        private const bool SUCCES = true;
        IStocareDulciuri stocareDulciuri = (IStocareDulciuri)new StocareFactory().GetTipStocare(typeof(Dulciuri));

        public AddDulce()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxWhite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLifeSpan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlaceOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGamesPlayed_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFederation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBlack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var dulciuri = new Dulciuri(
                    textBoxNume.Text,
                    textBoxCategorie.Text,
                    Convert.ToSingle(textBoxPret.Text),
                    Convert.ToSingle(textBoxNrCalorii.Text),
                textBoxProducator.Text);

                var rezultat = stocareDulciuri.AddDulciuri(dulciuri);
                if (rezultat == SUCCES)
                {
                    MessageBox.Show("Dulciuri adăugat");
                }
                else
                {
                    MessageBox.Show("Eroare la adăugare Dulciuri");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie: " + ex.Message);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
