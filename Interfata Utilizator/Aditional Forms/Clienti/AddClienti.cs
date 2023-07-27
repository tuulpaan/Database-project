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

namespace Interfata_Utilizator.Aditional_Forms.Clienti
{
    public partial class AddClienti : Form
    {

        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        IStocareClienti stocareClienti = (IStocareClienti)new StocareFactory().GetTipStocare(typeof(Client));
        public AddClienti()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new Client(
                    textBoxNume.Text,
                    textBoxPrenume.Text,
                    textBoxAdresa.Text,
                    textBoxNrTelefon.Text,
                textBoxEmail.Text);

                var rezultat = stocareClienti.AddClient(client);
                if (rezultat == SUCCES)
                {
                    MessageBox.Show("Client adăugat");
                }
                else
                {
                    MessageBox.Show("Eroare la adăugare Client");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie: " + ex.Message);
            }

        }
    }
}
