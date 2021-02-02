using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_PP.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string login { get; set; }
        public string passwordMd5 { get; set; }
        public int idRoli { get; set; }
        public int isDeleted { get; set; }
    }
}
