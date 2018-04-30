using CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPhotoGrapherServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using System.Data.Entity;

namespace CoolCat.PhotoGrapherLancer.Core.Service
{
    public class AlbumService : IPhotoGrapherAlbumService
    {


        DbContext Db;

        public AlbumService(DbContext context)
        {

            Db = context;

        }

        //Create Album
        public bool CreateAlbum(Album create)
        {
            Db.Set<Album>().Add(create);
            Db.SaveChanges();
            return true;
        }
        
        //get all Albam by phohgrapher id
        public IEnumerable<Album> GetALL(int id)
        {
            return Db.Set<Album>().Where(x => x.Fk_PhotoGrapher_ID == id).ToList();
        }



        //add Album Photo
        public bool Add_Albam_Photo(AlbamPhoto add)
        {
            Db.Set<AlbamPhoto>().Add(add);
            Db.SaveChanges();
            return true;
        }

        //Get All Album Photo 
        public IEnumerable<AlbamPhoto> GetAll_Albam_Photo(int AlbamId)
        {
            return Db.Set<AlbamPhoto>().Where(x => x.Albam_ID == AlbamId).ToList();
        }
    }
}
