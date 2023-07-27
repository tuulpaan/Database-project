using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie_Modele
{
    public class Client
    {
        public int ID_client { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string Nr_telefon { get; set; }
        public string Email { get; set; }

        public Client()
        { }

        public Client(string Nume, string Prenume, string Adresa, string Nr_telefon, string Email, int ID_client = 0)
        {
            this.ID_client = ID_client;
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Adresa = Adresa;
            this.Nr_telefon = Nr_telefon;
            this.Email = Email;
        }

        public Client(DataRow linieDB)
        {
            this.ID_client = Convert.ToInt32(linieDB["ID_client"].ToString());
            this.Nume = linieDB["Nume"].ToString();
            this.Prenume = linieDB["Prenume"].ToString();
            this.Adresa = linieDB["Adresa"].ToString();
            this.Nr_telefon = linieDB["Nr_telefon"].ToString();
            this.Email = linieDB["Email"].ToString();
        }
    }
}
