using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPhotoGrapherServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using System.Data.Entity;

namespace CoolCat.PhotoGrapherLancer.Core.Service
{
    public class PhotoGrapherServices : IPhotoGrapher_Service, IPhotoGrapher_Social_Service
    {


        DbContext Db;

        public PhotoGrapherServices(DbContext context)
        {

            Db = context;

        }


        //Get All PhotoGrapher
        public IEnumerable<PhotoGrapher> GetAll()
        {
            throw new NotImplementedException();
        }

        //PhotoGrapher Profile
        public PhotoGrapher GetPhotoGrapher(int id)
        {
            throw new NotImplementedException();
        }

       //When Register PhotoGrapher Add
        public bool AddPhotoGrapher(PhotoGrapher pht_Add)
        {
            Db.Set<PhotoGrapher>().Add(pht_Add);
            Db.SaveChanges();


            return true;

        }

        //PhotoGrapher Change Password
        public bool ChangePassword(PhotoGrapherChangePassword Pass_Change)
        {
            //Find The Client Object
            var obj = Db.Set<PhotoGrapher>().Where(a => a.PhotoGrapherId == Pass_Change.PhotoGrapherId).FirstOrDefault();

            if (obj.Password == Pass_Change.CurrentPassword)
            {

                //new Password set
                obj.Password = Pass_Change.NewPassword;

                //Single Field Update
                Db.Configuration.ValidateOnSaveEnabled = false;

                Db.SaveChanges();
                return true;
            }

            else
            {

                return false;

            }
        }


        #region //Profile Picture Region
       

        //Get All Profile Picture List PhotGrapher
        public IEnumerable<ProfilePicture> Get_All_ProfilePicture(int id)
        {
            return Db.Set<ProfilePicture>().ToList();
        }


        //Current Profile Picture Show
        public ProfilePicture CurrentProfilePicture(int id)
        {
            var Change_Profile_Picture = Db.Set<ProfilePicture>().Where(x => x.Fk_PhotoGrapher_ID == id && x.status == "set").FirstOrDefault();
            return Change_Profile_Picture;

        }


        //Profile picture Change Add To Database 
        public bool Add_Profile_Picture(ProfilePicture chng)
        {
            Db.Set<ProfilePicture>().Add(chng);
            Db.SaveChanges();

            return true;
        }


        //Change Current Profile Picture
        public bool Active_Profile_Picture(int id, int PictureID)
        {
            var set_Staus_check = Db.Set<ProfilePicture>().Where(x => x.Fk_PhotoGrapher_ID == id && x.status=="set").FirstOrDefault();
            var Pht_Grapher = Db.Set<ProfilePicture>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Pf_ID == PictureID).FirstOrDefault();

            if (Pht_Grapher != null)
            {

                //new Password set
                Pht_Grapher.status = "set";//Present set Profile Picture
                set_Staus_check.status = "unset"; //Previous which set Preset Unset


                //Single Field Update
                Db.Configuration.ValidateOnSaveEnabled = false;

                Db.SaveChanges();
                return true;


               
            }

            else
            {

                return false;
            }

        }

        #endregion


        #region //PhotoGrapher Award Region

        //Get All Award PhotoGrapher
        public IEnumerable<PhotoGrapherAward> GetAward(int id)
        {
            var get_All_award = Db.Set<PhotoGrapherAward>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
            return get_All_award;
        }


        public bool AddAward(PhotoGrapherAward Add_Award)
        {
            Db.Set<PhotoGrapherAward>().Add(Add_Award);
            Db.SaveChanges();


            return true;

        }

        //Award Update 
        public bool UpdateAward(PhotoGrapherAward UpAward, int id)
        {
           var find_single_Award= Db.Set<PhotoGrapherAward>().Find(id);
            if (find_single_Award != null)
            {

                Db.Entry(UpAward).State = EntityState.Modified;
                Db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        #endregion


        #region //PhotoGrapher Experience region

        //Get All Experience
        public IEnumerable<PhotoGrapherExperience> GetExperience(int id)
        {
            var get_All_ExpList = Db.Set<PhotoGrapherExperience>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
            return get_All_ExpList;
        }



        //Add Experience
        public bool AddExperience(PhotoGrapherExperience Exp)
        {
            Db.Set<PhotoGrapherExperience>().Add(Exp);
            Db.SaveChanges();


            return true;

        }

        //Update Experience
        public bool UpdateExperience(PhotoGrapherExperience ExpUpdate, int id)
        {
            var find_single_Exp = Db.Set<PhotoGrapherExperience>().Find(id);
            if (find_single_Exp != null)
            {

                Db.Entry(ExpUpdate).State = EntityState.Modified;
                Db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion


        #region //Skill Region
        //Get All Skill
        public IEnumerable<PhotoGrapherSkill> GetSkill(int id)
        {
            var get_All_SkillKist = Db.Set<PhotoGrapherSkill>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
            return get_All_SkillKist;
        }

        //Add Skill
        public bool AddSkill(PhotoGrapherSkill Add_Skill)
        {
            Db.Set<PhotoGrapherSkill>().Add(Add_Skill);
            Db.SaveChanges();


            return true;
        }
        
         //Update Skill
        public bool UpdateSkill(PhotoGrapherSkill UpSkill, int id)
        {
            var find_single_skill = Db.Set<PhotoGrapherSkill>().Find(id);
            if (find_single_skill != null)
            {

                Db.Entry(UpSkill).State = EntityState.Modified;
                Db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region //Type Of Catagory

       
        //Get All Type PhotoGraphy 
        public IEnumerable<PhotoGrapher_PhotoGraphy_Type> GetPhotoGraphy_Type(int id)
        {
            var get_All_type = Db.Set<PhotoGrapher_PhotoGraphy_Type>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
            return get_All_type;
        }

        public bool AddPhotoGraphy_Type(PhotoGrapher_PhotoGraphy_Type Add_Type)
        {
            Db.Set<PhotoGrapher_PhotoGraphy_Type>().Add(Add_Type);
            Db.SaveChanges();


            return true;
        }

        public bool UpdatePhotoGraphy_Type(PhotoGrapher_PhotoGraphy_Type UpType, int id)
        {
            var find_single_type = Db.Set<PhotoGrapher_PhotoGraphy_Type>().Find(id);
            if (find_single_type != null)
            {

                Db.Entry(UpType).State = EntityState.Modified;
                Db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }



        #endregion


        #region //Price Catagory

        //Get All Price List
        public IEnumerable<PriceDetail> GetAll(int id)
        {
            return Db.Set<PriceDetail>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
        }

        //Add
        public bool AddPrice(PriceDetail Add_Price)
        {
            Db.Set<PriceDetail>().Add(Add_Price);
            Db.SaveChanges();


            return true;
        }



        public bool UpdatePriceDetails(PriceDetail UpPrice)
        {
            Db.Entry(UpPrice).State = EntityState.Modified;
            Db.SaveChanges();
            return true;
        }


        public PriceDetail GetDetails(int priceId)
        {
            return Db.Set<PriceDetail>().Find(priceId);
        }



        #endregion



        #region //PhotoGrahper Basic Profile

        public PhotoGrapher_Basic_Profile GetBasicProfile(int id)
        {
            return Db.Set<PhotoGrapher_Basic_Profile>().Find(id);
        }

        //Update By default All Field Null
        public bool Update_Profile_Item(PhotoGrapher_Basic_Profile BasicAdd)
        {
            Db.Entry(BasicAdd).State = EntityState.Modified;
            Db.SaveChanges();
            return true;
        }



        #endregion


        #region //Follwers Region

        public IEnumerable<PhotoGrapher_Follower> GetAllFollowers(int id)
        {
            return Db.Set<PhotoGrapher_Follower>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
        }

        public int TotalFollowers(int id)
        {
           // int ratting=0;

            var followers_list= Db.Set<PhotoGrapher_Follower>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();

            var follower = followers_list.Sum(x => x.Followers);


            return follower;
        }

        public bool AddFollowers(PhotoGrapher_Follower Flw)
        {
            Db.Set<PhotoGrapher_Follower>().Add(Flw);
            Db.SaveChanges();


            return true;
        }



        #endregion

        #region //Following 

        public IEnumerable<PhotoGrapher_Following> GetAllFollowing(int id)
        {
            return Db.Set<PhotoGrapher_Following>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
        }

        public int TotalFollowing(int id)
        {
            var following_list = Db.Set<PhotoGrapher_Following>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();

            var following = following_list.Sum(x => x.Following);


            return following;
        }

        public bool AddFollowing(PhotoGrapher_Following Flow)
        {
            Db.Set<PhotoGrapher_Following>().Add(Flow);
            Db.SaveChanges();


            return true;
        }



        #endregion



        #region //Ratting Region
        //Total People Count
        public int Total_People_Ratting(int id)
        {
            var Total_People_list = Db.Set<PhotoGrapher_Ratting>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();

            var Total_People = Total_People_list.Sum(x => x.Fk_Client_id);

            return Total_People;
        }

        //Ratting ex:4.5
        public double TotalRatting(int id)
        {
            int Total_People = Total_People_Ratting(id);

            var FiveStar_List = Db.Set<PhotoGrapher_Ratting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 5).ToList();
            var FourStar_List = Db.Set<PhotoGrapher_Ratting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 4).ToList();
            var ThreeStar_List = Db.Set<PhotoGrapher_Ratting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 3).ToList();
            var TwoStar_List = Db.Set<PhotoGrapher_Ratting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 2).ToList();
            var OneStar_List = Db.Set<PhotoGrapher_Ratting>().Where(x => x.Fk_PhotoGrapher_ID == id && x.Ratting == 1).ToList();


            int Five_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id)*5;
            int Four_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id)*4;
            int three_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id)*3;
            int Two_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id)*2;
            int One_Star_People_Sum = FiveStar_List.Sum(x => x.Fk_Client_id)*1;


            int sum_Star = Five_Star_People_Sum + Four_Star_People_Sum + three_Star_People_Sum + Two_Star_People_Sum + One_Star_People_Sum;


            Double Result = sum_Star / Total_People;


            return Result;
        }

        //Client Ratting Add
        public bool AddRatting(PhotoGrapher_Ratting Rat)
        {
            Db.Set<PhotoGrapher_Ratting>().Add(Rat);
            Db.SaveChanges();


            return true;
        }

        #endregion

    }
}
