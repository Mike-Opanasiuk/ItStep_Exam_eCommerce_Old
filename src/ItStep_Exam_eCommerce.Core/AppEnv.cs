using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core
{
    public sealed class AppEnv
    {
        public class Roles
        {
            public const string USER = "User";
            public const string ADMIN = "Admin";
        }

        public class TokenExpiration
        {
            public static TimeSpan DEFAULT_EXPIRATION_TIME = TimeSpan.FromDays(1);
            public static TimeSpan LONG_EXPIRATION_TIME = TimeSpan.FromDays(7);
        }
    }
}
