﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
   public class PhotoUpload
    {
        [Key]
        public int PhotoID     { get; set; }

        public int Fk_PhotoGrapher_ID { get; set; }

        public DateTime Date_time { get; set; }    //current date time when Activity Post

        public string ImagePath { get; set; }      //possible null

        public string Caption { get; set; }       //possible null

        [Required]
        public string Description { get; set; }   

        public int? Likes { get; set; }           



    }
}
