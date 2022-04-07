using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class ApiConst
    {
        public const string ApiLogin = "https://apipub.tcbs.com.vn/authen/v1/login";
        public static string AccessToken { get; set; }
        public static DateTime Expired { get; set; }
    }
}
