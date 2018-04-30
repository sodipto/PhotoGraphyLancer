using CoolCat.PhotoGrapherLancer.Core.Entities;
using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using CoolCat.PhotoGrapherLancer.Core.Entities.PublicProfilePhotoGrapher;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Infrastructure
{
    public class PhotoGraphyDbContext:DbContext
    {
        //Client
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientJobsPost> ClientJobsPosts { get; set;}

        //Job Interest/Applied
        public DbSet<JobsInterested> JobsInteresteds { get; set; }


        //PhotoGrapher 
        public DbSet<PhotoGrapher> PhotoGraphers { get; set; }

        //PhotoGrapher_Basic_Profile
        public DbSet<PhotoGrapher_Basic_Profile> PhotoGrapher_Basic_Profiles { get; set; }


        //Client Book PhotoGrapher
        public DbSet<PhotoGrapherBooking> PhotoGrapherBookings { get; set; }


        //Client Contacr PhotoGrapher
        public DbSet<ClientContact> ClientContacts { get; set; }

        //Change Profile Picture
        public DbSet<ProfilePicture> ProfilePictures { get; set; }

        //Award Tables
        public DbSet<Award> Awards { get; set; }

        //PhotoGrapher Award 
        public DbSet<PhotoGrapherAward> PhotoGrapherAwards { get; set; }

        //Experience Table
        public DbSet<Experience> Experiences { get; set; }


        //PhotoGrapher Experience
        public DbSet<PhotoGrapherExperience> PhotoGrapherExperiences { get; set; }

        //skill Table
        public DbSet<Skill> Skills { get; set; }


        //PhotoGrapher Skill 
        public DbSet<PhotoGrapherSkill> PhotoGrapherSkills { get; set; }

        //PhotoGraphyTypes
        public DbSet<PhotoGraphyType> PhotoGraphyTypes { get; set; }


        //PhotoGrapher PhotoGrapher_PhotoGraphy_Type
        public DbSet<PhotoGrapherPhotoGraphyType> PhotoGrapherPhotoGraphyTypes { get; set; }


        // PhotoGrapher PriceDetail Catagory
        public DbSet<PriceDetail> PriceDetails { get; set; }




        //PhotoGrapher_Follower
        public DbSet<PhotoGrapher_Follower> PhotoGrapher_Followers { get; set; }


        //PhotoGrapher_Followings
        public DbSet<PhotoGrapher_Following> PhotoGrapher_Followings { get; set; }

        //PhotoGrapher_Ratting
        public DbSet<PhotoGrapher_Ratting> PhotoGrapher_Rattings { get; set; }





        //PhotoGraphyCatagory

        public DbSet<PhotoGraphyCatagory> PhotoGraphyCatagorys { get; set; }








    }
}
