﻿using CoolCat.PhotoGrapherLancer.Core.Entities.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IClientService
{
    public interface IClientServices
    {

        //Client Profile

        IEnumerable<Client> GetClient(int id);


        //Add Client

        bool AddClient(Client Newclient);

        //edit view

        Client EditView(int id);

        //Edit

        bool EditClient(Client editclient);

       //


    }
}
