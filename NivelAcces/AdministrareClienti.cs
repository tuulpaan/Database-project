using Librarie_Modele;

using Oracle.DataAccess.Client;

using System;
using System.Collections.Generic;
using System.Data;

namespace NivelAcces
{
    public class AdministrareClienti : IStocareClienti
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddClient(Client client)
        {
            return DataBaseHelper.ExecuteNonQuery(
                "INSERT INTO Clienti2 VALUES (SEQ_Clienti_LK2.nextval, :NUME, :PRENUME, :ADRESA, :NR_TELEFON, :EMAIL)", CommandType.Text,
                new OracleParameter(":NUME", OracleDbType.Varchar2, client.Nume, ParameterDirection.Input),
                new OracleParameter(":PRENUME", OracleDbType.Varchar2, client.Prenume, ParameterDirection.Input),
                new OracleParameter(":ADRESA", OracleDbType.Varchar2, client.Adresa, ParameterDirection.Input),
                new OracleParameter(":NR_TELEFON", OracleDbType.Varchar2, client.Nr_telefon, ParameterDirection.Input),
                new OracleParameter(":EMAIL", OracleDbType.Varchar2, client.Email, ParameterDirection.Input)
            );
        }

        public bool DeleteClient(int ID_client)
        {
            return DataBaseHelper.ExecuteNonQuery(
                "DELETE FROM Clienti2 WHERE ID_client = :ID_client", CommandType.Text,
                new OracleParameter(":ID_client", OracleDbType.Int32, ID_client, ParameterDirection.Input)
            );
        }

        public Client GetClient(int ID_client)
        {
            Client result = null;
            var dsClienti = DataBaseHelper.ExecuteDataSet("SELECT * FROM Clienti2 WHERE ID_client = :ID_client", CommandType.Text,
                new OracleParameter(":ID_client", OracleDbType.Int32, ID_client, ParameterDirection.Input));

            if (dsClienti.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsClienti.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Client(linieDB);
            }
            return result;
        }

        public List<Client> GetClienti()
        {
            var result = new List<Client>();
            var dsClienti = DataBaseHelper.ExecuteDataSet("SELECT * FROM Clienti2", CommandType.Text);

            foreach (DataRow linieDB in dsClienti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Client(linieDB));
            }
            return result;
        }

        public bool UpdateClient(Client client)
        {
            return DataBaseHelper.ExecuteNonQuery(
                "UPDATE Clienti2 SET NUME = :NUME, PRENUME = :PRENUME, ADRESA = :ADRESA, NR_TELEFON = :NR_TELEFON, EMAIL = :EMAIL WHERE ID_client = :ID_client",
                CommandType.Text,
                new OracleParameter(":NUME", OracleDbType.Varchar2, client.Nume, ParameterDirection.Input),
                new OracleParameter(":PRENUME", OracleDbType.Varchar2, client.Prenume, ParameterDirection.Input),
                new OracleParameter(":ADRESA", OracleDbType.Varchar2, client.Adresa, ParameterDirection.Input),
                new OracleParameter(":NR_TELEFON", OracleDbType.Varchar2, client.Nr_telefon, ParameterDirection.Input),
                new OracleParameter(":EMAIL", OracleDbType.Varchar2, client.Email, ParameterDirection.Input),
                new OracleParameter(":ID_client", OracleDbType.Int32, client.ID_client, ParameterDirection.Input)
            );
        }
    }
}
