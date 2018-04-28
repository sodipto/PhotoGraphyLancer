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

        IEnumerable<PhotoGrapher_Follower> GetAllFollowers(int id); //Thsi id PhotoGrapher Id

        //Count Total Followers
         int TotalFollowers(int id);      //Thsi id PhotoGrapher Id


        //Save Followers
        bool AddFollowers(PhotoGrapher_Follower Flw); //Check Condition 1 Client only one time Follow

        #endregion



        #region //This Region Basically Following

        //Get All Follower List By PhotoGrapher ID

        IEnumerable<PhotoGrapher_Following> GetAllFollowing(int id); //Thsi id PhotoGrapher Id

        //Count Total Followers
        int TotalFollowing(int id);      //Thsi id PhotoGrapher Id


        //Save Followers
        bool AddFollowing(PhotoGrapher_Following Flow); //Check Condition 1 Client only one time Follow

        #endregion 



    }
}
