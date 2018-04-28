using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPhotoGrapherServiceInterface
{
    public interface IPhotoGrapher_Album_Service
    {

        #region //Create Album

        //Get All Album by PhotoGrapherID
        IEnumerable<CreateAlbum> GetALL(int id);

        //Create Album
        bool CreateAlbum(CreateAlbum create);

        #endregion





    }
}
