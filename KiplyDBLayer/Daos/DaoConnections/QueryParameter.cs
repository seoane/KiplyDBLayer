using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiplyDBLayer.Daos.DaoConnections
{
    class QueryParameter
    {
        public String name { get; set; }
        public DbType type { get; set; }
        public String value { get; set; }
    }
}
