using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiplyDBLayer
{
    class ODBCConnection
    {
        private static OdbcConnection openConnection(String connectionString)
        {
            return new OdbcConnection(connectionString);
        }

        public static OdbcDataReader query(String connectionString,String queryString, List<QueryParameter> _queryParameters)
        {
            //String table;
            //String commandString = "Select * from " + table;
            //bool firstParameter = true;
            OdbcCommand command = new OdbcCommand(queryString);

            if (_queryParameters.Count > 0 ) {
                //commandString += " where ";
                foreach (QueryParameter queryParameter in _queryParameters)
                {
                    //if (!firstParameter) commandString+= " AND ";
                    //else firstParameter = false;
                    //commandString += queryParameter.name + queryParameter.getComparation() + "?";
                    command.Parameters.Add("@" + queryParameter.name, queryParameter.GetType()).Value = queryParameter.value;
                }
            }

            using (OdbcConnection conn = openConnection(connectionString))
            {
                command.Connection = conn;
                conn.Open();
                return command.ExecuteReader();
            }
        }
    }

}
