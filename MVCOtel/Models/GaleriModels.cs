using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCOtel.Models
{
    public class GaleriModels
    {
        [Key]
        public int GaleriID { get; set; }
        public string Yazi { get; set; }
        public string ResimURL { get; set; }
    }
}
