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

        public List<ApplicationLog> getAll()
        {
            String queryString = "Select * from application_logs";
            List<ApplicationLog> _applicationLogs = new List<ApplicationLog>();
            List<QueryParameter> _queryParameters = new List<QueryParameter>();

            OdbcDataReader _dataReader = ODBCConnection.query("dsn=" + ConfigurationManager.AppSettings["ODBCdsn"], queryString, _queryParameters);
            if (_dataReader.HasRows)
                while (_dataReader.Read())
                {
                    ApplicationLog applicationLog = new ApplicationLog(_dataReader);
                    _applicationLogs.Add(applicationLog);
                }
            _dataReader.Close();
            return _applicationLogs;
        }

        public List<ApplicationLog> getLasts(int minutes)
        {
            long timestamp = DateTime.Now.AddMinutes(-minutes).Ticks - new DateTime(1970, 1, 1).Ticks;
            timestamp /= TimeSpan.TicksPerSecond;

            String queryString = "Select * from application_logs where log_timestamp >= ?";
            List<ApplicationLog> _applicationLogs = new List<ApplicationLog>();
            List<QueryParameter> _queryParameters = new List<QueryParameter>();
            QueryParameter queryParameter = new QueryParameter("@log_timestamp", timestamp.ToString());
            _queryParameters.Add(queryParameter);

            OdbcDataReader _dataReader = ODBCConnection.query("dsn=" + ConfigurationManager.AppSettings["ODBCdsn"], queryString, _queryParameters);
            if (_dataReader.HasRows)
                while (_dataReader.Read())
                {
                   ApplicationLog applicationLog = new ApplicationLog(_dataReader);
                   _applicationLogs.Add(applicationLog);
                }
            _dataReader.Close();
            return _applicationLogs;
        }

        public ApplicationLog getByUuid(string uuid)
        {

                string queryString = "Select * from application_logs where uuid = ?";
                ApplicationLog applicationLog = null;
                List<QueryParameter> _queryParameters = new List<QueryParameter>();
                QueryParameter queryParameter = new QueryParameter("@uuid",uuid);
                _queryParameters.Add(queryParameter);

                OdbcDataReader _dataReader = ODBCConnection.query("dsn=" + ConfigurationManager.AppSettings["ODBCdsn"], queryString, _queryParameters);
                if(_dataReader.HasRows)
                    while (_dataReader.Read())
                    {
                        applicationLog = new ApplicationLog(_dataReader);
                    }
                _dataReader.Close();
                return applicationLog;
        }
    }
}
