﻿using CoolCat.PhotoGrapherLancer.Core.Entities;
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

        //Client Book PhotoGrapher
        public DbSet<PhotoGrapherBooking> PhotoGrapherBookings { get; set; }


        //Client Contacr PhotoGrapher
        public DbSet<ClientContact> ClientContacts { get; set; }

        //Change Profile Picture
        public DbSet<ProfilePicture> ProfilePictures { get; set; }

        //PhotoGrapher Award 
        public DbSet<PhotoGrapherAward> PhotoGrapherAwards { get; set; }

        //PhotoGrapher Experience
        public DbSet<PhotoGrapherExperience> PhotoGrapherExperiences { get; set; }

        //PhotoGrapher Skill
        public DbSet<PhotoGrapherSkill> PhotoGrapherSkills { get; set; }












        //PhotoGraphyCatagory

        public DbSet<PhotoGraphyCatagory> PhotoGraphyCatagorys { get; set; }








    }
}
