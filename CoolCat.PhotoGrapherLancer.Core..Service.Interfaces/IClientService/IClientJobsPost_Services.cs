using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using CoolCat.PhotoGrapherLancer.Core.Entities;

namespace CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IClientService
{
     public  interface IClientJobsPost_Services
    {

        //Get All Client Post(By Client Id)

        IEnumerable<ClientJobsPost> GetALLPost (int id);


        //SinglePost

        ClientJobsPost ClientPost(int id);



        //Add post

        bool AddJobsPost(ClientJobsPost jobspost);



        //EditView
        Client EditJobView(int id);


        //Edit
        bool EditJobsPost(Client editclient);



        //JobsInterest PhotoGrapherList by ClientID

        IEnumerable<JobsInterested> GetAllInterest(int ClientID,int PostId);  //individual client search by all post and interested



        //List of PhotoGraphy catagory

        IEnumerable<PhotoGraphyCatagory> GetALLPhotoCatagory();

        #region //PhotoGrapher Handle

        //All PhotoGrapher List

        //IEnumerable<PhotoGrapher> GetAllPhotoGrapher();


        //Single PhotoGrapherProfile

        //PhotoGrapher PhotoGrapherProfile(int id);

        #endregion

    }
}
