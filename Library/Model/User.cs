using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string First_And_Second_Name { get; set; }
        public string Telephone_No { get; set; }
        public string Mail{ get; set; }
        public string Password{ get; set; }
    }
}
