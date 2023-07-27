using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie_Modele
{
    public class Dulciuri
    {
        public int ID_dulce { get; set; }
        public string Nume { get; set; }
        public string Categorie { get; set; }
        public float Pret { get; set; }
        public float Nr_calorii { get; set; }
        public string Producator { get; set; }

        public  Dulciuri()
        { }
        public virtual Dulciuri Dulce { get; set; }

        public Dulciuri(string Nume, string Categorie, float Pret, float Nr_calorii, string Producator, int ID_dulce = 0)
        {
            this.ID_dulce = ID_dulce;
            this.Nume = Nume;
            this.Categorie = Categorie;
            this.Pret = Pret;
            this.Nr_calorii = Nr_calorii;
            this.Producator = Producator;
        }

        public Dulciuri(DataRow linieDB)
        {
            this.ID_dulce = Convert.ToInt32(linieDB["ID_dulce"].ToString());
            this.Nume = linieDB["Nume"].ToString();
            this.Categorie = linieDB["Categorie"].ToString();
            this.Pret = Convert.ToSingle(linieDB["Pret"].ToString());
            this.Nr_calorii = Convert.ToSingle(linieDB["Nr_calorii"].ToString());
            this.Producator = linieDB["Producator"].ToString();
        }
    }
}
