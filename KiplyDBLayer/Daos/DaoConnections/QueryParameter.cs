using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiplyDBLayer
{
    class QueryParameter
    {
        public QueryParameter(String name, DbType type, String value)
        {
            this.name = name;
            this.type = type;
            this.value = value;
        }
        public String name { get; set; }
        public DbType type { get; set; }
        public String value { get; set; }
        public String getComparation() {
            switch (type)
            {
                default:
                    return "";
            }
        }
     }
}
