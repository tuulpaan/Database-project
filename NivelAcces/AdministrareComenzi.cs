using Librarie_Modele;

using Oracle.DataAccess.Client;

using System;
using System.Collections.Generic;
using System.Data;

namespace NivelAcces
{
    public class AdministrareComenzi : IStocareComenzi
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddComenzi(Comanda comanda)
        {
            return DataBaseHelper.ExecuteNonQuery(
                "INSERT INTO Comenzi2 VALUES (SEQ_Comenzi_ID2.nextval, :DATA, :ID_CLIENT, :ID_DULCE1, :ID_DULCE2, :ID_DULCE3, :DETALII_COMANDA)",
                CommandType.Text,
                new OracleParameter(":DATA", OracleDbType.Date, comanda.Data, ParameterDirection.Input),
                new OracleParameter(":ID_CLIENT", OracleDbType.Int32, comanda.ID_client, ParameterDirection.Input),
                new OracleParameter(":ID_DULCE1", OracleDbType.Int32, comanda.ID_dulce1, ParameterDirection.Input),
                new OracleParameter(":ID_DULCE2", OracleDbType.Int32, comanda.ID_dulce2, ParameterDirection.Input),
                new OracleParameter(":ID_DULCE3", OracleDbType.Int32, comanda.ID_dulce3, ParameterDirection.Input),
                new OracleParameter(":DETALII_COMANDA", OracleDbType.Varchar2, comanda.Detalii_comanda, ParameterDirection.Input)
            );
        }

        public bool DeleteComenzi(int ID_comanda)
        {
            return DataBaseHelper.ExecuteNonQuery(
                "DELETE FROM Comenzi2 WHERE ID_comanda = :ID_comanda", CommandType.Text,
                new OracleParameter(":ID_comanda", OracleDbType.Int32, ID_comanda, ParameterDirection.Input)
            );
        }

        public Comanda GetComenzi(int ID_comanda)
        {
            Comanda result = null;
            var dsComenzi = DataBaseHelper.ExecuteDataSet("SELECT * FROM Comenzi2 WHERE ID_comanda = :ID_comanda", CommandType.Text,
                new OracleParameter(":ID_comanda", OracleDbType.Int32, ID_comanda, ParameterDirection.Input));

            if (dsComenzi.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsComenzi.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Comanda(linieDB);
            }
            return result;
        }

        public List<Comanda> GetComenzi()
        {
            var result = new List<Comanda>();
            var dsComenzi = DataBaseHelper.ExecuteDataSet("SELECT * FROM Comenzi2", CommandType.Text);

            foreach (DataRow linieDB in dsComenzi.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Comanda(linieDB));
            }
            return result;
        }

        public bool UpdateComenzi(Comanda comanda)
        {
            return DataBaseHelper.ExecuteNonQuery(
                "UPDATE Comenzi2 SET DATA = :DATA, ID_CLIENT = :ID_CLIENT, ID_DULCE1 = :ID_DULCE1, ID_DULCE2 = :ID_DULCE2, ID_DULCE3 = :ID_DULCE3, DETALII_COMANDA = :DETALII_COMANDA WHERE ID_comanda = :ID_comanda",
                CommandType.Text,
                new OracleParameter(":DATA", OracleDbType.Date, comanda.Data, ParameterDirection.Input),
                new OracleParameter(":ID_CLIENT", OracleDbType.Int32, comanda.ID_client, ParameterDirection.Input),
                new OracleParameter(":ID_DULCE1", OracleDbType.Int32, comanda.ID_dulce1, ParameterDirection.Input),
                new OracleParameter(":ID_DULCE2", OracleDbType.Int32, comanda.ID_dulce2, ParameterDirection.Input),
                new OracleParameter(":ID_DULCE3", OracleDbType.Int32, comanda.ID_dulce3, ParameterDirection.Input),
                new OracleParameter(":DETALII_COMANDA", OracleDbType.Varchar2, comanda.Detalii_comanda, ParameterDirection.Input),
                new OracleParameter(":ID_comanda", OracleDbType.Int32, comanda.ID_comanda, ParameterDirection.Input)
            );
        }
    }
}
