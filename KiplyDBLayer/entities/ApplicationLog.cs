using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiplyDBLayer
{
    public class ApplicationLog
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
        public float max_mem { get; set; }
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
        public float kiply_max_mem { get; set; }
        public float kiply_min_cpu { get; set; }
        public float kiply_min_mem { get; set; }

        public ApplicationLog(DbDataReader dataReader)
        {
            string uuid= dataReader.GetString(0);
            string computer_username= dataReader.GetString(1);
            int company_id= dataReader.GetInt32(2);
            string ip_private_internal_1= dataReader.GetString(3);
            string ip_private_internal_2= dataReader.GetString(4);
            string ip_private_internal_3= dataReader.GetString(5);
            string ip_external= dataReader.GetString(6);
            long log_timestamp= dataReader.GetInt32(7);
            string machine_name= dataReader.GetString(8);
            int office_id = dataReader.GetInt32(9);
            int request_id = dataReader.GetInt32(10);
            int user_id = dataReader.GetInt32(11);
            int application_id = dataReader.GetInt32(12);
            int application_version_id= dataReader.GetInt32(13);
            int os_application_id = dataReader.GetInt32(14);
            int os_application_version_id = dataReader.GetInt32(15);
            float avg_cpu= dataReader.GetFloat(16);
            float avg_mem= dataReader.GetFloat(17);
            long from_timestamp = dataReader.GetInt32(18);
            string from_timezone= dataReader.GetString(19);
            float max_cpu= dataReader.GetFloat(20);
            float max_mem= dataReader.GetFloat(21);
            float min_cpu= dataReader.GetFloat(22);
            float min_mem= dataReader.GetFloat(23);
            string process_name= dataReader.GetString(24);
            long to_timestamp = dataReader.GetInt32(25);
            string to_timezone= dataReader.GetString(27);
            string window_title= dataReader.GetString(28);
            string detail= dataReader.GetString(29);
            string document= dataReader.GetString(30);
            string client_version= dataReader.GetString(31);
            string context= dataReader.GetString(32);
            float kiply_max_cpu= dataReader.GetFloat(33);
            float kiply_max_mem= dataReader.GetFloat(34);
            float kiply_min_cpu= dataReader.GetFloat(35);
            float kiply_min_mem= dataReader.GetFloat(36);
            float kiply_avg_cpu= dataReader.GetFloat(37);
            float kiply_avg_mem= dataReader.GetFloat(38);
        }
    }
}
