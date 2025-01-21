using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto
{

    public class UsersDto
    {

        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string? lastName { get; set; }
    }
}