using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Diagnostics;
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
            OdbcCommand command = new OdbcCommand(queryString);

            if (_queryParameters !=null  && _queryParameters.Count > 0 ) {
                foreach (QueryParameter queryParameter in _queryParameters)
                {
                    command.Parameters.AddWithValue(queryParameter.name, queryParameter.value);
                }
            }

            Console.WriteLine(command.ToString());
            using (OdbcConnection conn = openConnection(connectionString))
            {
                command.Connection = conn;
                conn.Open();
                return command.ExecuteReader();
            }
        }
    }

}
