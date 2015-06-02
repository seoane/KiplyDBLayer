using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Configuration;

namespace KiplyDBLayer
{
    public class ApplicationLogDaoODBC:IApplicationLogDao
    {
        public ApplicationLogDaoODBC ()
        {
            
        }

        public List<ApplicationLog> getAll() {
            String queryString = "Select * from Application_Logs";
            List<QueryParameter> _queryParameters = null;
            OdbcDataReader _dataReader = ODBCConnection.query("dsn=" + ConfigurationManager.AppSettings["ODBCdsn"], 
                queryString, _queryParameters);
            return null;
        }

        public List<ApplicationLog> getLasts(int minutes = 60) {
            DateTime timestamp = new DateTime().AddMinutes(-minutes);
            String queryString = "Select * from ApplicationLogs where timestamp >= @log_timestamp";
            List<QueryParameter> _queryParameters = new List<QueryParameter>();
            _queryParameters.Add(new QueryParameter("log_timestamp", timestamp.ToString()));
            OdbcDataReader _dataReader = ODBCConnection.query("dsn=" + ConfigurationManager.AppSettings["ODBCdsn"], 
                queryString, _queryParameters);
            return null;
        }

        public ApplicationLog getByUuid(string uuid)
        {
            String queryString = "Select * from application_logs where uuid like '@uuid'";
            List<QueryParameter> _queryParameters = new List<QueryParameter>();
            _queryParameters.Add(new QueryParameter("uuid", uuid));
            OdbcDataReader _dataReader = ODBCConnection.query("dsn=" + ConfigurationManager.AppSettings["ODBCdsn"],
                queryString, _queryParameters);

            ApplicationLog applicationLog = null;
            while (_dataReader.Read())
            {
                applicationLog = new ApplicationLog(_dataReader);
            }
            _dataReader.Close();
            return applicationLog;
        }

    }
}
