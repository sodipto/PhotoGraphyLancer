using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
   public class PhotoGrapherActivity
    {
        [Key]
        public int ActivityID     { get; set; }

        public int PhotoGrapherId { get; set; }

        public DateTime Date_time { get; set; }    //current date time when Activity Post

        public string Description { get; set; }

        public string ImagePath   { get; set; }

        public int? Likes { get; set; }           



    }
}
