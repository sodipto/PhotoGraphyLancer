﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
    public class ProfilePicture
    {
        [Key]
        public int Pf_ID { get; set; }

        public int Fk_PhotoGrapher_ID { get; set; }

        public DateTime Date_time { get; set; }    //current date time when Activity Post

        public string ImagePath { get; set; }      //possible null

        [DefaultValue("Unset")]                     
        public string status { get; set; }          //when picture set status change to current


    }
}