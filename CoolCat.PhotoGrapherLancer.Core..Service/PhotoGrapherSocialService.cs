using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPhotoGrapherServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using System.Data.Entity;

namespace CoolCat.PhotoGrapherLancer.Core.Service
{
    public class PhotoGrapherSocialService : IPhotoGrapher_Social_Service
    {


        DbContext Db;

        public PhotoGrapherSocialService(DbContext context)
        {

            Db = context;

        }

        #region //Follwers Region

        public IEnumerable<PhotoGrapherFollower> GetAllFollowers(int id)
        {
            return Db.Set<PhotoGrapherFollower>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
        }

        public int TotalFollowers(int id)
        {
            // int ratting=0;

            var followers_list = Db.Set<PhotoGrapherFollower>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();

            var follower = followers_list.Sum(x => x.Followers);


            return follower;
        }

        public bool AddFollowers(PhotoGrapherFollower Flw)
        {
            Db.Set<PhotoGrapherFollower>().Add(Flw);
            Db.SaveChanges();


            return true;
        }



        #endregion

        #region //Following 

        public IEnumerable<PhotoGrapherFollowing> GetAllFollowing(int id)
        {
            return Db.Set<PhotoGrapherFollowing>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
        }

        public int TotalFollowing(int id)
        {
            var following_list = Db.Set<PhotoGrapherFollowing>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();

            var following = following_list.Sum(x => x.Following);


            return following;
        }

        public bool AddFollowing(PhotoGrapherFollowing Flow)
        {
            Db.Set<PhotoGrapherFollowing>().Add(Flow);
            Db.SaveChanges();


            return true;
        }



        #endregion



        #region //Ratting Region
        //Total People Count
        public int Total_People_Ratting(int id)
        {
            var Total_People_list = Db.Set<PhotoGrapherRatting>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();

            var Total_People = Total_People_list.Sum(x => x.Fk_Client_id);

            return Total_People;
        }

        //Ratting ex:4.5
        public double TotalRatting(int id)
        {
            int Total_People = Total_People_Ratting(id);

            var FiveStar_List = Db.Set<PhotoGrapherRatting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 5).ToList();
            var FourStar_List = Db.Set<PhotoGrapherRatting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 4).ToList();
            var ThreeStar_List = Db.Set<PhotoGrapherRatting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 3).ToList();
            var TwoStar_List = Db.Set<PhotoGrapherRatting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 2).ToList();
            var OneStar_List = Db.Set<PhotoGrapherRatting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 1).ToList();


            int Five_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id) * 5;
            int Four_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id) * 4;
            int three_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id) * 3;
            int Two_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id) * 2;
            int One_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id) * 1;


            int sum_Star = Five_Star_People_Sum + Four_Star_People_Sum + three_Star_People_Sum + Two_Star_People_Sum + One_Star_People_Sum;


            Double Result = sum_Star / Total_People;


            return Result;
        }

        //Client Ratting Add
        public bool AddRatting(PhotoGrapherRatting Rat)
        {
            Db.Set<PhotoGrapherRatting>().Add(Rat);
            Db.SaveChanges();


            return true;
        }

        #endregion
    }
}
