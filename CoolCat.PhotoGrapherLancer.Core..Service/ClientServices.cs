using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IClientServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using CoolCat.PhotoGrapherLancer.Core.Entities;
using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;

namespace CoolCat.PhotoGrapherLancer.Core._.Service
{
    public class ClientServices : IClientServices,IClientJobsPost_Services
    {

        #region // Client Service

        public IEnumerable<Client> GetallClient()
        {
            throw new NotImplementedException();
        }

        public Client GetClient(int id)
        {
            throw new NotImplementedException();
        }


        public bool AddClient(Client Newclient)
        {
            throw new NotImplementedException();
        }



        public bool EditClient(Client editclient)
        {
            throw new NotImplementedException();
        }

        public bool ChangePassword(ChangePassword Pass_Change)
        {
            throw new NotImplementedException();
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
