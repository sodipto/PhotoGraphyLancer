﻿using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IClientServiceInterface
{
    public interface IClientServices
    {

        //Get All Client
        IEnumerable<Client> GetallClient();

        //Client Profile
          Client GetClient(int id);


        //Add Client

        bool AddClient(Client Newclient);

        //edit view

        Client EditView(int id);

        //Edit

        bool EditClient(Client editclient);

       //


    }
}