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
using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.ServiceModel;
using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPublicPhotoGrapher_Profile_Interface;
using CoolCat.PhotoGrapherLancer.Core.Entities.PublicProfilePhotoGrapher;

namespace CoolCat.PhotoGrapherLancer.Core._.Service
{
    public class ClientServices : IClientServices,IClientJobsPost_Services, IClientBooking_Service, IClientContact_Service
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


        


        public IEnumerable<PhotoGraphyCatagory> GetALLPhotoCatagory()
        {
            return Db.Set<PhotoGraphyCatagory>().ToList();
        }

        public IEnumerable<PhotoGrapherProfile_ViewModel> GetAllPhotoGrapher()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PhotoGrapherProfile_ViewModel> PhotoGrapherProfile(int id)
        {
            //   PhotoGrapherProfile_ViewModel objALL = new PhotoGrapherProfile_ViewModel();

            // objALL.Pt= Db.Set<PhotoGrapher>().ToList() ;



            throw new NotImplementedException();
        }



        #endregion


        #region //PhotoGrapher Booking Service
        public IEnumerable<PhotoGrapherBooking> GelALLBooking()
        {
            return Db.Set<PhotoGrapherBooking>().ToList();
        }

        //PhotoGrapher All The List Who Is Booked
        public IEnumerable<PhotoGrapherBooking> GetBooking(int id)
        {
            var BookingList = Db.Set<PhotoGrapherBooking>().Where(x => x.Fk_PhotoGrapher_Id == id).ToList();

            return BookingList;
        }

        //CLient All The List Who Is Booked
        public IEnumerable<PhotoGrapherBooking> GetBooking_Client_Show(int id)
        {
            var Client_BookingList = Db.Set<PhotoGrapherBooking>().Where(x => x.Fk_Client_Id == id).ToList();

            return Client_BookingList;
        }


        public bool AddBooking(PhotoGrapherBooking Booked)
        {
            Db.Set<PhotoGrapherBooking>().Add(Booked);
            Db.SaveChanges();
            return true;
        }



        #endregion



        #region //Client Conract PhotoGrapher

        //Admin All The Contact List
        public IEnumerable<ClientContact> AllGetContact()
        {
            return Db.Set<ClientContact>().ToList();
        }

        //PhotoGrapher Get  Single Contact Details
        public ClientContact GetContact_Details(int id)
        {
            var Get_Contact_Details = Db.Set<ClientContact>().Where(x => x.ContactId == id).FirstOrDefault();
            return Get_Contact_Details;
        }


        //PhotoGrapher Get All Contact List
        public IEnumerable<ClientContact> Get_All_PhotoGrapher_Contact(int id)
        {
            var Contact_List = Db.Set<ClientContact>().Where(x => x.Fk_PhotoGrapherID== id).ToList();

            return Contact_List;
        }


        public bool AddContact(ClientContact Add_Contact)
        {
            Db.Set<ClientContact>().Add(Add_Contact);
            Db.SaveChanges();
            return true;
        }

       



        #endregion

    }
}
