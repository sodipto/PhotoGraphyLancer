using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher
{
    public class PhotoGrapher_Following
    {

        public int FollowingID { get; set; }      //Increment Automatic

        public int Following { get; set; }     //By Default Null Accepted

        public int Fk_PhotoGrapher_ID { get; set; }   //Foreign Key From PhotoGrapher.cs
    }
}
