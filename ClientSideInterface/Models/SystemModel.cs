using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClientSideInterface.Models
{
    public class SystemModel
    {
        [Key]
        public int SystemID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
    }
}
