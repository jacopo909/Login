using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public class Utente
    {
        int id { get; set; }
        string email { get; set; }
        string username { get; set; }
        string password { get; set; }

        string info
        {
            get
            {
                return $"{email} {username} {password}";
            }
        }

    }
}
