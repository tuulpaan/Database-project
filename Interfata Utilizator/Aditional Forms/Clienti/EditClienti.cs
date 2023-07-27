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
    public partial class EditClienti : Form
    {

        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        IStocareClienti stocareClienti = (IStocareClienti)new StocareFactory().GetTipStocare(typeof(Client));
        public EditClienti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
                string ID_client = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
                var client = new Client(
                    textBoxNume.Text,
                    textBoxPrenume.Text,
                    textBoxAdresa.Text,
                    textBoxNrTelefon.Text,
                    textBoxEmail.Text,
                    Convert.ToInt32(ID_client)
                );

                var rezultat = stocareClienti.UpdateClient(client);
                if (rezultat == SUCCES)
                {
                    MessageBox.Show("Client actualizat");
                    AfisareCatalog();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare client");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie: " + ex.Message);
            }

        }
        public void AfisareCatalog()
        {
            try
            {
                var clientiList = stocareClienti.GetClienti();
                if (clientiList != null && clientiList.Any())
                {
                    dataGridView1.DataSource = clientiList.Select(c => new
                    {
                        c.ID_client,
                        c.Nume,
                        c.Prenume,
                        c.Adresa,
                        c.Nr_telefon,
                        c.Email
                    }).ToList();

                    dataGridView1.Columns["ID_client"].HeaderText = "ID Client";
                    dataGridView1.Columns["Nr_Telefon"].HeaderText = "Numar Telefon";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void EditClienti_Load(object sender, EventArgs e)
        {
            AfisareCatalog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string ID_client = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            try
            {
                Client client = stocareClienti.GetClient(Int32.Parse(ID_client));

                // Load data into form controls
                if (client != null)
                {
                    textBoxNume.Text = client.Nume;
                    textBoxPrenume.Text = client.Prenume;
                    textBoxAdresa.Text = client.Adresa;
                    textBoxNrTelefon.Text = client.Nr_telefon;
                    textBoxEmail.Text = client.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
