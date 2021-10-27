using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClientSideInterface.Models
{
    public class GamesModel
    {
        [Key]
        public int ID { get; set; }

        public int SystemID { get; set; }
        public string Title { get; set; }
        public string Genere { get; set; }
        public string Rating { get; set; }
        public SystemModel systemModel { get; set; }
    }
}
