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

using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPublicPhotoGrapher_Profile_Interface;
using CoolCat.PhotoGrapherLancer.Core.Entities.PublicProfilePhotoGrapher;

namespace CoolCat.PhotoGrapherLancer.Core._.Service
{
    public class ClientServices : IClientServices
    {

        DbContext Db;

        public ClientServices(DbContext context)
        {

            Db=context;

        }

        #region // Client Service
        //Get All Client Fetch By Admin
        public IEnumerable<Client> GetallClient()
        {
            return Db.Set<Client>().ToList();
        }

        //Single Client Details
        public Client GetClient(int id)
        {
            var obj_Client = Db.Set<Client>().Find(id);

            return obj_Client;
        }


        //Client Registration
        public bool AddClient(Client Newclient)
        {
            Db.Set<Client>().Add(Newclient);
            Db.SaveChanges();


            return true;

        }


        //Cliet Her Profile Update
        public bool EditClient(Client editclient)
        {

            Db.Entry(editclient).State = EntityState.Modified;
            Db.SaveChanges();
            return true;
        }

        //Pass_Change Is Model Object This Objec Inside ClientID
        public bool ChangePassword(ChangePassword Pass_Change)
        {
            //Find The Client Object
            var obj = Db.Set<Client>().Where(a => a.ClientId == Pass_Change.ClientId).FirstOrDefault();

            if (obj.Password == Pass_Change.CurrentPassword)
            {

                //new Password set
                obj.Password = Pass_Change.NewPassword;

                //Single Field Update
                Db.Configuration.ValidateOnSaveEnabled = false;

                Db.SaveChanges();
                return true;
            }

            else
            {

                return false;

            }
            

           
        }


        #endregion




    }
}
