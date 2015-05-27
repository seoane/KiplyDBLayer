using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace KiplyDBLayer
{
    class ApplicationLogDaoODBC:IApplicationLogDao
    {
        public ApplicationLogDaoODBC ()
        {
            
        }

       /* public List<ApplicationLog> getAll() {
            String queryString = "Select * from ApplicationLogs where timestamp >= @log_timestamp";
            List<QueryParameter> _queryParameters = new List<QueryParameter>;
            _queryParameters.Add(new QueryParameter("log_timestamp",DbType.inte));
            ODBCConnection.query(connectionString,String queryString, List<QueryParameter> _queryParameters)
            return null;
        }*/

        public List<ApplicationLog> getLasts(int time) {
            DateTime timestamp = new DateTime().AddMinutes(time);
            String queryString = "Select * from ApplicationLogs where timestamp >= @log_timestamp";
            List<QueryParameter> _queryParameters = new List<QueryParameter>();
            _queryParameters.Add(new QueryParameter("log_timestamp",DbType.Int32,timestamp.Millisecond.ToString));
            ODBCConnection.query(connectionString,String queryString, List<QueryParameter> _queryParameters)
            return null;
        }

    }
}
