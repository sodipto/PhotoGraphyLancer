using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
   public class PhotoGrapher_Followers
    {

        public int FollowID { get; set; }      //Increment Automatic

        public int Followers { get; set; }     //By Default Null Accepted

        public int Fk_PhotoGrapher_ID { get; set; }   //Foreign Key From PhotoGrapher.cs





    }
}
