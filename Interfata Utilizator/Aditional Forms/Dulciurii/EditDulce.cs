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
    public partial class EditDulce : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        IStocareDulciuri stocareDulciuri = (IStocareDulciuri)new StocareFactory().GetTipStocare(typeof(Dulciuri));

        public EditDulce()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
                string ID_dulce = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
                var dulciuri = new Dulciuri(textBoxNume.Text,
                    textBoxCategorie.Text, Convert.ToSingle(textBoxPret.Text), Convert.ToInt32(textBoxNrCalorii.Text),
                    textBoxProducator.Text,
                    Convert.ToInt32(ID_dulce)
                    );

                var rezultat = stocareDulciuri.UpdateDulciuri(dulciuri);
                if (rezultat == SUCCES)
                {
                    MessageBox.Show("Dulciuri actualizat");
                    AfisareCatalog();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare dulciuri");
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
                var dulciuriList = stocareDulciuri.GetDulciuri();
                if (dulciuriList != null && dulciuriList.Any())
                {
                    dataGridView1.DataSource = dulciuriList.Select(d => new
                    {
                        d.ID_dulce,
                        d.Nume,
                        d.Categorie,
                        d.Pret,
                        d.Nr_calorii,
                        d.Producator
                    }).ToList();

                    dataGridView1.Columns["ID_dulce"].HeaderText = "ID Dulce";
                    dataGridView1.Columns["Nr_calorii"].HeaderText = "Nr Calorii";
                    dataGridView1.Columns["Producator"].HeaderText = "Producător";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void EditDulce_Load(object sender, EventArgs e)
        {
            AfisareCatalog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string ID_dulce = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            try
            {
                Dulciuri dulciuri = stocareDulciuri.GetDulciuri(Int32.Parse(ID_dulce));

                // Load data into form controls
                if (dulciuri != null)
                {
                    textBoxNume.Text = dulciuri.Nume;
                    textBoxCategorie.Text = dulciuri.Categorie;
                    textBoxPret.Text = dulciuri.Pret.ToString();
                    textBoxNrCalorii.Text = dulciuri.Nr_calorii.ToString();
                    textBoxProducator.Text = dulciuri.Producator;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
