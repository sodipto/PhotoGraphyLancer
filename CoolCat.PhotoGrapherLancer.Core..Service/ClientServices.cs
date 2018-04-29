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

        public bool ChangePassword(ChangePassword Pass_Change)
        {


            return true;
        }


        #endregion


        #region//Client Job Post Service
        
        //Get All Post By Client ID
        public IEnumerable<ClientJobsPost> GetALLPost(int id)
        {
            throw new NotImplementedException();
        }



        //Single Job Post
        public ClientJobsPost ClientPost(int id)
        {
            throw new NotImplementedException();
        }


        //Add Post
        public bool AddJobsPost(ClientJobsPost jobspost)
        {
            throw new NotImplementedException();
        }


        //
        public bool EditJobsPost(Client editclient)
        {
            throw new NotImplementedException();
        }




        

        

        public IEnumerable<JobsInterested> GetAllInterest(int ClientID, int PostId)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<PhotoGrapher> GetAllPhotoGrapher()
        {
            throw new NotImplementedException();
        }



        public PhotoGrapher PhotoGrapherProfile(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<PhotoGraphyCatagory> GetALLPhotoCatagory()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
