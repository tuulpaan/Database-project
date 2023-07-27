using Librarie_Modele;

using Oracle.DataAccess.Client;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAcces
{
    public class AdministrareDulciuri : IStocareDulciuri
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddDulciuri(Dulciuri dulce)
        {
            return DataBaseHelper.ExecuteNonQuery(
                "INSERT INTO Dulciuri_LK VALUES (SEQ_DULCIURI_LK.nextval, :NUME, :CATEGORIE, :PRET, :NR_CALORII, :PRODUCATOR)", CommandType.Text,
                new OracleParameter(":NUME", OracleDbType.Varchar2, dulce.Nume, ParameterDirection.Input),
                new OracleParameter(":CATEGORIE", OracleDbType.Varchar2, dulce.Categorie, ParameterDirection.Input),
                new OracleParameter(":PRET", OracleDbType.Double, dulce.Pret, ParameterDirection.Input),
                new OracleParameter(":NR_CALORII", OracleDbType.Double, dulce.Nr_calorii, ParameterDirection.Input),
                new OracleParameter(":PRODUCATOR", OracleDbType.Varchar2, dulce.Producator, ParameterDirection.Input)
            );
        }

        public bool DeleteDulciuri(int ID_dulce)
        {
            return DataBaseHelper.ExecuteNonQuery(
                "DELETE FROM Dulciuri_LK WHERE ID_dulce = :ID_dulce", CommandType.Text,
                new OracleParameter(":ID_dulce", OracleDbType.Int32, ID_dulce, ParameterDirection.Input)
            );
        }

        public Dulciuri GetDulciuri(int ID_dulce)
        {
            Dulciuri result = null;
            var dsDulciuri = DataBaseHelper.ExecuteDataSet("SELECT * FROM Dulciuri_LK WHERE ID_dulce = :ID_dulce", CommandType.Text,
                new OracleParameter(":ID_dulce", OracleDbType.Int32, ID_dulce, ParameterDirection.Input));

            if (dsDulciuri.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsDulciuri.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Dulciuri(linieDB);
            }
            return result;
        }

        public List<Dulciuri> GetDulciuri()
        {
            var result = new List<Dulciuri>();
            var dsDulciuri = DataBaseHelper.ExecuteDataSet("SELECT * FROM Dulciuri_LK", CommandType.Text);

            foreach (DataRow linieDB in dsDulciuri.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Dulciuri(linieDB));
            }
            return result;
        }

        public bool UpdateDulciuri(Dulciuri dulce)
        {
            return DataBaseHelper.ExecuteNonQuery(
                "UPDATE Dulciuri_LK SET NUME = :NUME, CATEGORIE = :CATEGORIE, PRET = :PRET, NR_CALORII = :NR_CALORII, PRODUCATOR = :PRODUCATOR WHERE ID_dulce = :ID_dulce",
                CommandType.Text,
                new OracleParameter(":NUME", OracleDbType.Varchar2, dulce.Nume, ParameterDirection.Input),
                new OracleParameter(":CATEGORIE", OracleDbType.Varchar2, dulce.Categorie, ParameterDirection.Input),
                new OracleParameter(":PRET", OracleDbType.Double, dulce.Pret, ParameterDirection.Input),
                new OracleParameter(":NR_CALORII", OracleDbType.Double, dulce.Nr_calorii, ParameterDirection.Input),
                new OracleParameter(":PRODUCATOR", OracleDbType.Varchar2, dulce.Producator, ParameterDirection.Input),
                new OracleParameter(":ID_dulce", OracleDbType.Int32, dulce.ID_dulce, ParameterDirection.Input)
            );
        }
    }
}
