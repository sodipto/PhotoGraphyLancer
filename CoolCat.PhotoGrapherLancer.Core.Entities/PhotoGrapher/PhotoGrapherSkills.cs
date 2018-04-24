using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
   public class PhotoGrapherSkills
    {
        [Key]
        public int SkillsID { get; set; }


        public int Fk_PhotoGrapher_ID { get; set; }


        public string Skills { get; set; }
    }
}
