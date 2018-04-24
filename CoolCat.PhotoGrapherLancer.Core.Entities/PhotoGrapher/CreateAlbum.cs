using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
    public class CreateAlbum
    {

        public int AlbamID { get; set; }

        public int Fk_PhotoGrapher_ID { get; set; }

        public DateTime Date_time { get; set; }    //current date time when Activity Post

        public string Caption { get; set; }

        public string ImagePath { get; set; }      //possible null

     



    }
}
