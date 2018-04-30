using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using CoolCat.PhotoGrapherLancer.Core.Entities;
using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.ServiceModel;

namespace CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IClientServiceInterface
{
     public  interface IClientJobsPost_Services
    {

        //Get All Client Post(By Client Id)

        IEnumerable<ClientJobsPost> GetALLPost (int id);


        //SinglePost
        //This Id Job Post Id
        ClientJobsPost ClientPost(int id);



        //Add post

        bool AddJobsPost(ClientJobsPost jobspost);



        //Edit
        bool EditJobsPost(ClientJobsPost editPost);


        

        //JobsInterest PhotoGrapherList by ClientID

        IEnumerable<JobsInterested> GetAllInterest(int ClientID,int PostId);  //individual client search by all post and interested



        //List of PhotoGraphy catagory

      //  IEnumerable<PhotoGraphyCatagory> GetALLPhotoCatagory();

      

      

        


      

    }
}
