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

namespace Interfata_Utilizator.Aditional_Forms.Orders
{
    public partial class OrderForm : Form
    {

        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        IStocareComenzi stocareComenzi = (IStocareComenzi)new StocareFactory().GetTipStocare(typeof(Comanda));
        public OrderForm()
        {
            InitializeComponent();
            if (stocareComenzi == null)
            {
                MessageBox.Show("Eroare la initializare");
            }

        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            AddOrder order = new AddOrder();
            order.Show();
        }

        private void btnEditOrders_Click(object sender, EventArgs e)
        {
            EditOrder order = new EditOrder();
            order.Show();
        }

        private void btnShowOrders_Click(object sender, EventArgs e)
        {
            AfisareCatalog();
        }
        public void AfisareCatalog()
        {
            Console.WriteLine("Start");
            try
            {
                var comenziList = stocareComenzi.GetComenzi();
                if (comenziList != null && comenziList.Any())
                {
                    dataGridView1.DataSource = comenziList.Select(c => new
                    {
                        c.ID_comanda,
                        c.Data,
                        c.ID_client,
                        c.ID_dulce1,
                        c.ID_dulce2,
                        c.ID_dulce3,
                        c.Detalii_comanda
                    }).ToList();

                    dataGridView1.Columns["ID_comanda"].HeaderText = "ID Comanda";
                    dataGridView1.Columns["ID_client"].HeaderText = "ID Client";
                    dataGridView1.Columns["Data"].HeaderText = "Data Comenzii";
                    dataGridView1.Columns["ID_dulce1"].HeaderText = "ID Dulce 1";
                    dataGridView1.Columns["ID_dulce2"].HeaderText = "ID Dulce 2";
                    dataGridView1.Columns["ID_dulce3"].HeaderText = "ID Dulce 3";
                    dataGridView1.Columns["Detalii_comanda"].HeaderText = "Detalii Comanda";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Console.WriteLine("Finish");
        }

        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int ID_comanda = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_comanda"].Value);

                    var rezultat = stocareComenzi.DeleteComenzi(ID_comanda);
                    if (rezultat == SUCCES)
                    {
                        MessageBox.Show("Comanda stersa cu succes");
                    }
                    else
                    {
                        MessageBox.Show("Eroare la stergere comanda");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            AfisareCatalog();
        }
    }
}
