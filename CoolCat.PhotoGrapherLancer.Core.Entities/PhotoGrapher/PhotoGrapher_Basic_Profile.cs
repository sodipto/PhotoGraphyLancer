﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
   public class PhotoGrapher_Basic_Profile
    {

        public int ProfileID { get; set; }

        public int Fk_PhotoGrapher_ID { get; set; }

        public string Education { get; set; }

        public string Address { get; set; }

        public int?   Phone { get; set; }

        public string Notes { get; set; }








    }
}
