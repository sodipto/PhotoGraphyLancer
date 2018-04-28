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
        //Thsi id PhotoGrapher Id

        IEnumerable<PhotoGrapher_Follower> GetAllFollowers(int id);

        //Count Total Followers
        //Thsi id PhotoGrapher Id
        int TotalFollowers(int id);     


        //Save Followers
        //Check Condition 1 Client only one time Follow
        bool AddFollowers(PhotoGrapher_Follower Flw); 

        #endregion



        #region //This Region Basically Following

        //Get All Follower List By PhotoGrapher ID
        //Thsi id PhotoGrapher Id
        IEnumerable<PhotoGrapher_Following> GetAllFollowing(int id);

        //Count Total Followers
        //Thsi id PhotoGrapher Id
        int TotalFollowing(int id);    


        //Save Following
        //Check Condition 1 Client only one time Follow
        bool AddFollowing(PhotoGrapher_Following Flow);

        #endregion


        #region //This Region Basically Ratting

        //count All The People Which Is Rating this PhotoGrapher
        int Total_People_Ratting(int id);


        //Count Total Followers
        //Sum All Rating Point And Calculation And Return Value
        //Thsi id PhotoGrapher Id
        Double TotalRatting(int id);


        //Save Ratting
        //Check Condition 1 Client only one time Ratting Next Time Update
        bool AddRatting(PhotoGrapher_Following Rat);

        #endregion 




    }
}
