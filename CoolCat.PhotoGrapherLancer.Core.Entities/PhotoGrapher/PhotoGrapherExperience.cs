using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
    public class PhotoGrapherExperience
    {
        [Key]
        public int ExperienceID { get; set; }


        public int Fk_PhotoGrapher_ID { get; set; }


        public string Experiences { get; set; }


    }
}
