using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie_Modele
{
    public class Comanda
    {
        public int ID_comanda { get; set; }
        public DateTime Data { get; set; }
        public int ID_client { get; set; }
        public int ID_dulce1 { get; set; }
        public int ID_dulce2 { get; set; }
        public int ID_dulce3 { get; set; }
        public string Detalii_comanda { get; set; }

        public Comanda()
        { }

        public Comanda(int ID_comanda, DateTime Data, int ID_client, int ID_dulce1, int ID_dulce2, int ID_dulce3, string Detalii_comanda)
        {
            this.ID_comanda = ID_comanda;
            this.Data = Data;
            this.ID_client = ID_client;
            this.ID_dulce1 = ID_dulce1;
            this.ID_dulce2 = ID_dulce2;
            this.ID_dulce3 = ID_dulce3;
            this.Detalii_comanda = Detalii_comanda;
        }

        public Comanda(DataRow linieDB)
        {
            this.ID_comanda = Convert.ToInt32(linieDB["ID_comanda"].ToString());
            this.Data = Convert.ToDateTime(linieDB["Data"].ToString());
            this.ID_client = Convert.ToInt32(linieDB["ID_client"].ToString());
            this.ID_dulce1 = Convert.ToInt32(linieDB["ID_dulce1"].ToString());
            this.ID_dulce2 = Convert.ToInt32(linieDB["ID_dulce2"].ToString());
            this.ID_dulce3 = Convert.ToInt32(linieDB["ID_dulce3"].ToString());
            this.Detalii_comanda = linieDB["Detalii_comanda"].ToString();
        }
    }
}
