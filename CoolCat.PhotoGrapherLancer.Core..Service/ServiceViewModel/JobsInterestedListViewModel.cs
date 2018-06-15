using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Service.ServiceViewModel
{
   public class JobsInterestedListViewModel

    {
        public PhotoGrapher photographer { get; set;}
        public JobsInterested jobinterest { get; set; }

        public ProfilePicture profilepicture { get; set; }

        public int follower { get; set; }

        public double ratting { get; set; }


    }
}
