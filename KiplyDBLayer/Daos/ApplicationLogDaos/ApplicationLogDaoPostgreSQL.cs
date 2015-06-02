using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiplyDBLayer
{
    class ApplicationLogDaoPostgreSQL:IApplicationLogDao
    {
        public ApplicationLogDaoPostgreSQL ()
        {
        }

        public List<ApplicationLog> getLasts(int minutes = 60)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationLog> getAll()
        {
            throw new NotImplementedException();
        }


        public ApplicationLog getByUuid(string uuid)
        {
            throw new NotImplementedException();
        }
    }
}
