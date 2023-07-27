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
    public partial class DulciuriForm : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        
        IStocareDulciuri stocareDulciuri = (IStocareDulciuri)new StocareFactory().GetTipStocare(typeof(Dulciuri));

        public DulciuriForm()
        {
            InitializeComponent();
            if (stocareDulciuri == null)
            {
                MessageBox.Show("Eroare la initializare");
            }

        }
        private void btnAddDulciuri_Click(object sender, EventArgs e)
        {
            AddDulce addDulce = new AddDulce();
            addDulce.Show();
        }

        private void btnDeleteDulciuri_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int ID_dulce = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_dulce"].Value);

                    var rezultat = stocareDulciuri.DeleteDulciuri(ID_dulce);
                    if (rezultat == SUCCES)
                    {
                        MessageBox.Show("Produs Sters cu success");
                    }
                    else
                    {
                        MessageBox.Show("Eroare la Stergere Produs");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnShowDulciuri_Click(object sender, EventArgs e)
        {
            AfisareCatalog();
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

        private void btnEditDulciuri_Click(object sender, EventArgs e)
        {
            EditDulce editDulce = new EditDulce();
            editDulce.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DulciuriForm_Load(object sender, EventArgs e)
        {
            AfisareCatalog();
        }
    }
}
