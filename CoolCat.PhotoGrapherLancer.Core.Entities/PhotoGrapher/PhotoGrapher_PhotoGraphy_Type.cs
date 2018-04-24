using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
   public class PhotoGrapher_PhotoGraphy_Type
    {

        [Key]
        public int TypeID { get; set; }


        public int Fk_PhotoGrapher_ID { get; set; }


        public string PhotoGraphyTypes { get; set; }
    }
}
