using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiplyDBLayer
{
    public interface IApplicationLogDao
    {
        //public ApplicationLog create(SqlConnection connection, ApplicationLog applicationLog);

        //public void remove (SqlConnection connection, long applicationLogUuid);

        //public void update(SqlConnection connection, ApplicationLog applicationLog);

        List<ApplicationLog> getLasts(int minutes = 60);

        List<ApplicationLog> getAll();

        ApplicationLog getByUuid(String uuid);

    }
}
