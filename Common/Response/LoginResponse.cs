using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Response
{
    public class LoginResponse
    {
        public string email { get; set; }
        public string first_name { get; set; }
        public string ichats_token { get; set; }
        public string last_name { get; set; }
        public string tcbsid { get; set; }
        public string token { get; set; }
        public string username { get; set; }
    }
}
