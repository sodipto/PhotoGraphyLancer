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


        #region //Albam Photo


        //Get All This Albam Photo
        IEnumerable<AlbamPhoto> GetAll_Albam_Photo(int AlbamId);

        //Add Albam Photo By Albam Id
        bool Add_Albam_Photo(AlbamPhoto add);


        #endregion



        #region //Upload photo Gallary

        //Get All Upload Photo By Photographer Id
        //This Id Is The PhotoGrapher Id 
        IEnumerable<PhotoUpload_Gallary> Get_All_Gallary_Photo(int id);

        //client Show Public Gallary Photo only public Photo
        IEnumerable<PhotoUpload_Gallary> Get_All_Gallary_Photo_Public(int id);

        //Details Single Image
        PhotoUpload_Gallary PhotoDetails(int photoId);
      


        //Upload Photo Gallary
        bool Upload_Photo_Gallary(PhotoUpload_Gallary upload);


        //Update when Image In Public or private
        //Only Update On field Shared Coloum public/Private
        bool UpdateGallaryPhoto(PhotoUpload_Gallary UpdatePhoto);
       
        #endregion





    }
}
