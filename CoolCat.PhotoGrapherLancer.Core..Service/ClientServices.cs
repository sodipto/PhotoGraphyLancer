using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IClientServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using CoolCat.PhotoGrapherLancer.Core.Entities;
using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using System.Data.Entity;
using CoolCat.PhotoGrapherLancer.Core.Service.ServiceModel;

namespace CoolCat.PhotoGrapherLancer.Core._.Service
{
    public class ClientServices : IClientServices,IClientJobsPost_Services
    {

        DbContext Db;

        public ClientServices(DbContext context)
        {

            Db=context;

        }

        #region // Client Service

        public IEnumerable<Client> GetallClient()
        {
            return Db.Set<Client>().ToList();
        }

        public Client GetClient(int id)
        {
            var obj_Client = Db.Set<Client>().Find(id);

            return obj_Client;
        }


        public bool AddClient(Client Newclient)
        {
            Db.Set<Client>().Add(Newclient);
            Db.SaveChanges();


            return true;

        }



        public bool EditClient(Client editclient)
        {

            Db.Entry(editclient).State = EntityState.Modified;
            Db.SaveChanges();
            return true;
        }

        //Pass_Change Is Model Object This Objec Inside ClientID
        public bool ChangePassword(ChangePassword Pass_Change)
        {
            //Find The Client Object
            var obj = Db.Set<Client>().Where(a => a.ClientId == Pass_Change.ClientId).FirstOrDefault();

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


        #endregion


        #region//Client Job Post Service
        
        //Get All Post By Client ID
        public IEnumerable<ClientJobsPost> GetALLPost(int id)
        {
            var All_Obj_Post = Db.Set<ClientJobsPost>().Where(x => x.FkClientID == id).ToList();

            return All_Obj_Post;
        }



        //Single Job Post
        public ClientJobsPost ClientPost(int id)
        {
            var JobPostDetails= Db.Set<ClientJobsPost>().Where(x => x.PostId == id).FirstOrDefault();
            return JobPostDetails;
        }


        //Add Post
        public bool AddJobsPost(ClientJobsPost jobspost)
        {
            Db.Set<ClientJobsPost>().Add(jobspost);
            Db.SaveChanges();
            return true;

        }


        //Edit JobsPost
        public bool EditJobsPost(ClientJobsPost editPost)
        {

            Db.Entry(editPost).State = EntityState.Modified;
            Db.SaveChanges();
            return true;
        }

        //Interest PhotoGrapher List
        public IEnumerable<JobsInterested> GetAllInterest(int ClientID, int PostId)
        {
            var InterestList_PhotoGrapher = Db.Set<JobsInterested>().Where(x => x.FkClientID == ClientID && x.FkJobsPostId == PostId).ToList();

            return InterestList_PhotoGrapher;


        }


        public IEnumerable<Entities.PhotoGrapher.PhotoGrapher_Profile_ViewModel> GetAllPhotoGrapher()
        {
            return Db.Set<PhotoGrapher_Profile_ViewModel>().ToList();
        }



        public PhotoGrapher_Profile_ViewModel PhotoGrapherProfile(int id)
        {

            Core.Service.ServiceModel.PhotoGrapher_Profile_ViewModel obj_Profile_all = new Core.Service.ServiceModel.PhotoGrapher_Profile_ViewModel();

            obj_Profile_all.pt = Db.Set<Entities.PhotoGrapher.PhotoGrapher_Profile_ViewModel>().Find(id);

             return obj_Profile_all;
        }


        public IEnumerable<PhotoGraphyCatagory> GetALLPhotoCatagory()
        {
            return Db.Set<PhotoGraphyCatagory>().ToList();
        }

       

        #endregion

    }
}
