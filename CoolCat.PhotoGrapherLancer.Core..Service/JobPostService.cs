using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IClientServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using System.Data.Entity;
using CoolCat.PhotoGrapherLancer.Core.Infrastructure;
using CoolCat.PhotoGrapherLancer.Core.Service.ServiceViewModel;
using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using CoolCat.PhotoGrapherLancer.Core.Service;

namespace CoolCat.PhotoGrapherLancer.Core.Service
{
    public class JobPostService : IClientJobsPost_Services
    {
        PhotoGraphyDbContext Db = new PhotoGraphyDbContext();

        //DbContext Db;

        //public JobPostService(DbContext context)
        //{

        //    Db = context;

        //}


        #region//Client Job Post Service

        //Get All Job Post
        public IEnumerable<ClientJobsPost> GetAll_Jobs_Post()
        {

            
           
            

                 

            
            return Db.Set<ClientJobsPost>().Include("Clients").ToList();     //Join Use by navigation property
        }


        public IEnumerable<ClientJobsPost> GetAll_Jobs_Post_P(int photographerid)
        {

           // var appliedpost_user = Db.JobsInteresteds.Where(x => x.PhotoGrapherId == 1).ToList();







            return Db.Set<ClientJobsPost>().Include("Clients").Where(x => !Db.JobsInteresteds.Any(f => f.FkJobsPostId == x.PostId && f.PhotoGrapherId == photographerid)).ToList();     //Join Use by navigation property
        }





        //get All job post photographer except applied post


        //Get All Post By Client ID
        public IEnumerable<ClientJobsPost> GetALLPost(int id)
        {
            var All_Obj_Post = Db.Set<ClientJobsPost>().Include("Clients").Where(x => x.FkClientID == id).ToList();

            return All_Obj_Post;
        }






        //Single Job Post
        public ClientJobsPost ClientPost(int id)
        {
            var JobPostDetails = Db.Set<ClientJobsPost>().Where(x => x.PostId == id).FirstOrDefault();
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
        public IEnumerable<JobsInterestedListViewModel> GetAllInterest(int PostId)
        {

            //  var InterestList_PhotoGrapher = Db.Set<JobsInterested>().Where(x=>x.FkJobsPostId == PostId).ToList();

            // return InterestList_PhotoGrapher;
            PhotoGrapherSocialService socialservice = new PhotoGrapherSocialService();
            PhotoGrapherServices pt = new PhotoGrapherServices();



            List<PhotoGrapher> pht = Db.PhotoGraphers.ToList();
            List<JobsInterested> interest = Db.JobsInteresteds.ToList();
           

            var data = (from p in pht
                        join j in interest
                        on p.PhotoGrapherId equals j.PhotoGrapherId
                        //
                        where j.FkJobsPostId == PostId
                        select new JobsInterestedListViewModel
                        {
                            photographer=p,
                            jobinterest=j,

                            //here function call total follower get by photographerid
                            follower= socialservice.TotalFollowers(p.PhotoGrapherId),

                            //here function call ratting get photographer
                            ratting=socialservice.TotalRatting(p.PhotoGrapherId),


                            profilepicture=pt.CurrentProfilePicture(p.PhotoGrapherId)

                        }).ToList();
                      
                      
                      
                      
                     

                return data;


        }



        //No Way Data Pass So I use View model
        public IEnumerable<AppliedPostViewModel> GetApplied(int id)
        {
            List<ClientJobsPost> ClPost = Db.ClientJobsPosts.ToList();
            List<JobsInterested> Jst = Db.JobsInteresteds.ToList();
          


            var data = (from d in Jst
                        join f in ClPost
                        on d.FkJobsPostId equals f.PostId
                        where d.PhotoGrapherId == id
                        select new AppliedPostViewModel
                        {

                            JobPostList = f,
                            JobInterestList = d



                        }).ToList();

            return data;

        }

        //Get By PhotoGrapherID
        public IEnumerable<JobsInterested> Get_All_Jobs_Applied(int id)
        {
            return Db.Set<JobsInterested>().Where(x => x.PhotoGrapherId == id).ToList();

        }

        //Job Interest Add
        public bool AddJobInterest(JobsInterested Interest)
        {
            Db.Set<JobsInterested>().Add(Interest);
            Db.SaveChanges();


            return true;
        }




        #endregion

    }
}
