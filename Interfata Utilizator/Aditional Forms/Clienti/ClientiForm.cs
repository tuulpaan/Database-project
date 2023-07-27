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
    public partial class ClientiForm : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        IStocareClienti stocareClienti = (IStocareClienti)new StocareFactory().GetTipStocare(typeof(Client));
        public ClientiForm()
        {
            InitializeComponent();
            if (stocareClienti == null)
            {
                MessageBox.Show("Eroare la initializare");
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddClienti_Click(object sender, EventArgs e)
        {
            AddClienti addClienti = new AddClienti();
            addClienti.Show();
        }

        private void btnEditClienti_Click(object sender, EventArgs e)
        {
            EditClienti editClienti = new EditClienti();
            editClienti.Show();
        }

        private void btnDeleteClienti_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int ID_client = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_client"].Value);

                    var rezultat = stocareClienti.DeleteClient(ID_client);
                    if (rezultat == SUCCES)
                    {
                        MessageBox.Show("Client sters cu succes");
                    }
                    else
                    {
                        MessageBox.Show("Eroare la stergere client");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnShowClienti_Click(object sender, EventArgs e)
        {
            AfisareCatalog();
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

        private void ClientiForm_Load(object sender, EventArgs e)
        {
            AfisareCatalog();
        }
    }
}
