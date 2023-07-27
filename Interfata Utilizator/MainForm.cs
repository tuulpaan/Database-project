
using Interfata_Utilizator.Aditional_Forms.Clienti;
using Interfata_Utilizator.Aditional_Forms.Dulciurii;
using Interfata_Utilizator.Aditional_Forms.Orders;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata_Utilizator
{
    public partial class MainForm : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnDulciuri_Click(object sender, EventArgs e)
        {
            DulciuriForm dulciuri = new DulciuriForm();
            dulciuri.Show();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            ClientiForm clienti = new ClientiForm();
            clienti.Show();
        }

        private void btnComenzi_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            order.Show();
        }
    }
}
