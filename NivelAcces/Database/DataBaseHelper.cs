﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace NivelAcces
{
    internal class DataBaseHelper
    {
        private const int EROARE_LA_EXECUTIE = 0;

        private static string _connectionString = null;
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = ConfigurationManager.AppSettings.Get("StringConectareBD");
                }
                return _connectionString;

            }
        }

        /// <summary>
        /// executa o instructiune de tip SELECT
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns>returneaza valorile primite ca un obiect generic de tip 'DataSet'</returns>
        /// 

        public static DataSet ExecuteDataSet(string sql, CommandType cmdType, params OracleParameter[] parameters)
        {
            using (DataSet ds = new DataSet())
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {
                        new OracleDataAdapter(cmd).Fill(ds);
                    }
                    catch (OracleException ex)
                    {
                        //salveaza exceptii in fisiere log
                    }
                    return ds;
                }
            }
        }

        /// <summary>
        /// executa instructiuni INSERT/UPDATE/DELETE 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns> returneaza 'true' daca instructiunea a fost executata cu success</returns>
        public static bool ExecuteNonQuery(string sql, CommandType cmdType, params OracleParameter[] parameters)
        {
            int rezult = EROARE_LA_EXECUTIE;
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {
                        cmd.Connection.Open();
                        rezult = cmd.ExecuteNonQuery();
                    }
                    catch (OracleException ex)
                    {
                        //salveaza exceptii in fisiere log
                    }
                }
            }
            return Convert.ToBoolean(rezult);
        }
    }
}
