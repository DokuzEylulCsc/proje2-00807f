using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Proje2
{
     abstract class Kullanici
    {
        String username;
        String pass_hash;
        String id;

        public string Username { get => username; set => username = value; }
        public string Pass_hash { get => pass_hash; set => pass_hash = value; }
        public string Id { get => id; set => id = value; }
    }
}
