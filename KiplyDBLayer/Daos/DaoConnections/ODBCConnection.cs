using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiplyDBLayer.Daos.DaoConnections
{
    class ODBCConnection
    {
        private OdbcConnection openConnection(String connectionString)
        {
            return new OdbcConnection(connectionString);
        }

        public void query(String connectionString, List<QueryParameter> _queryParameters)
        {
            String table;
            String commandString = "Select * from " + table;
            if (_queryParameters.Count > 0 ) {
                commandString += " where";
                foreach (QueryParameter queryParameter in _queryParameters)
                {
                    commandString += " " + queryParameter.name + " >= " + queryParameter.value;
                    //if
                }
            }
           // OdbcCommand command = new OdbcCommand("SELECT * FROM Table WHERE Id = ? AND Column = ?");
           // command.Parameters.Add("@id", OdbcType.Int).Value = 2;
           // command.Parameters.Add("@text", OdbcType.VarChar).Value = "test";

            using (OdbcConnection conn = openConnection(connectionString))
            {

                /*SqlCommand dbCommand = new SqlCommand("insert into [DB].[dbo].[User] 
                    ( [Id], [AccountId], [FirstName], [LastName], [JobTitle], [PhoneNumber] )
                values ( @id, @accountid, @firstname, @lastname, @jobtitle, @phonenumber );", dbConn)*/
                using (OdbcCommand command = new OdbcCommand("select * from [DB].[TABLE]"))
                command.Connection = conn;
                conn.Open();
                command.ExecuteNonQuery();  

            }
        }
    }

}
