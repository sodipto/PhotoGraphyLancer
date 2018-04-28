using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPhotoGrapherServiceInterface
{
   public interface IPhotoGrapher_Social_Service
    {

        #region //This Region Basically Follower 

        //Get All Follower List By PhotoGrapher ID

        IEnumerable<PhotoGrapher_Follower> GetAll(int id); //Thsi id PhotoGrapher Id

        //Count Total Followers
         int TotalFollowers(int id);      //Thsi id PhotoGrapher Id


        //Save Followers
        bool AddFollowers(PhotoGrapher_Follower Flw); //Check Condition 1 Client only one time Follow

        #endregion 

    }
}
