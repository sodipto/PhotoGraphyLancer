﻿using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPhotoGrapherServiceInterface;
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
    public class PhotoGrapherServices : IPhotoGrapher_Service
    {


        DbContext Db;

        public PhotoGrapherServices(DbContext context)
        {

            Db = context;

        }



        public IEnumerable<PhotoGrapher> GetAll()
        {
            throw new NotImplementedException();
        }

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
        //Get Client Details
        public Client GetClient(int id)
        {
            return Db.Set<Client>().Find(id);
        }

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



        #endregion

        public bool AddJobInterest(JobsInterested Interest)
        {
            throw new NotImplementedException();
        }

       

        public bool AddPhotoGraphy_Type(PhotoGrapher_PhotoGraphy_Type Add_Type)
        {
            throw new NotImplementedException();
        }

        public bool AddPrice(PriceDetail Add_Price)
        {
            throw new NotImplementedException();
        }

        public bool AddSkill(PhotoGrapherSkill Add_Skill)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<PriceDetail> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientJobsPost> GetAll_Jobs_Post()
        {
            throw new NotImplementedException();
        }

       

        public PhotoGrapher_Basic_Profile GetBasicProfile(int id)
        {
            throw new NotImplementedException();
        }

       

        public PriceDetail GetDetails(int priceId)
        {
            throw new NotImplementedException();
        }

       

       

        public IEnumerable<PhotoGrapher_PhotoGraphy_Type> GetPhotoGraphy_Type(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PhotoGrapherSkill> GetSkill(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobsInterested> Get_All_Jobs_Applied(int id)
        {
            throw new NotImplementedException();
        }

        
        
        

        public bool UpdatePhotoGraphy_Type(PhotoGrapher_PhotoGraphy_Type UpType, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePriceDetails(PriceDetail UpPrice)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSkill(PhotoGrapherSkill UpSkill, int id)
        {
            throw new NotImplementedException();
        }

        public bool Update_Profile_Item(PhotoGrapher_Basic_Profile BasicAdd)
        {
            throw new NotImplementedException();
        }

        
    }
}