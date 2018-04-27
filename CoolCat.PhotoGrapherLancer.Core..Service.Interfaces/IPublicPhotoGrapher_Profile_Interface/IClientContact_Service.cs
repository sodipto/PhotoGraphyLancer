using CoolCat.PhotoGrapherLancer.Core.Entities.PublicProfilePhotoGrapher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPublicPhotoGrapher_Profile_Interface
{
    public interface IClientContact_Service
    {


        //All The Contact Get By Admin



        //Get Contact By PhotoGrapher

        ClientContact GetContact(int id);  //Get By PhotoGrapher ID/Client ID 


        //Add Contact To The Database

        bool AddContact(ClientContact Add_Contact);

    }
}
