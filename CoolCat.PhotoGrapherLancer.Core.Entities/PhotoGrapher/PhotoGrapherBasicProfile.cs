using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
   public class PhotoGrapherBasicProfile
    {
        [Key]
        public int ProfileID { get; set; }

        public int Fk_PhotoGrapher_ID { get; set; }

        public string Education { get; set; }

        public string Address { get; set; }

        [MinLength(11, ErrorMessage = "Minimum 11 Digit"), MaxLength(11)]
        public int?   Phone { get; set; }

        public string Notes { get; set; }








    }
}
