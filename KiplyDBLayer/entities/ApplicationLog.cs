using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiplyDBLayer
{
    class ApplicationLog
    {
        public string uuid { get; set; }
        public string computer_username { get; set; }
        public int company_id { get; set; }
        public string ip_private_internal_1 { get; set; }
        public string ip_private_internal_2 { get; set; }
        public string ip_private_internal_3 { get; set; }
        public string ip_external { get; set; }
        public long log_timestamp { get; set; }
        public long to_timestamp { get; set; }
        public string to_timezone { get; set; }
        public long from_timestamp { get; set; }
        public string from_timezone { get; set; }
        public string machine_name { get; set; }
        public int office_id { get; set; }
        public int request_id { get; set; }
        public int user_id { get; set; }
        public int application_id { get; set; }
        public int application_version_id { get; set; }
        public int os_application_id { get; set; }
        public int os_application_version_id { get; set; }
        public float avg_cpu { get; set; }
        public float avg_mem { get; set; }
        public float max_cpu { get; set; }
        public float max_men { get; set; }
        public float min_cpu { get; set; }
        public float min_mem { get; set; }
        public string process_name { get; set; }
        public string window_title { get; set; }
        public string detail { get; set; }
        public string document { get; set; }
        public string client_version { get; set; }
        public string context { get; set; }
        public float kiply_avg_cpu { get; set; }
        public float kiply_avg_mem { get; set; }
        public float kiply_max_cpu { get; set; }
        public float kiply_max_men { get; set; }
        public float kiply_min_cpu { get; set; }
        public float kiply_min_mem { get; set; }

        public ApplicationLog() {}

    }
}
