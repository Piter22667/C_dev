using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace api.Models
{
    public class Users
    {

        public int Id { get; set; }
        public string login { get; set; } = string.Empty; //щоб не було null, а порожній рядок ""
        public string password { get; set; }
        public string name { get; set; } = string.Empty;
        public string surname { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;

    }
}

