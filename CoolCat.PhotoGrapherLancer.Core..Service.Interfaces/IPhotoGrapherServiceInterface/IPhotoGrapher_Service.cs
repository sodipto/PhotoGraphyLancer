using CoolCat.PhotoGrapherLancer.Core.Entities.PhotoGrapher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.IPhotoGrapherServiceInterface
{
    public interface IPhotoGrapher_Service
    {

        #region // PhotoGrapher Basic Profile

        //Get All PhotoGrapher
        IEnumerable<PhotoGrapher> GetAll();


        //PhotoGrapher Details By Id
        //This Is The Get Id Then All type Of Details Fetch by This ID 
        PhotoGrapher GetPhotoGrapher(int id);



        //Add PhotoGrapher When Register Basic Item
        //When Add Another Table Update PhotoGrapher_Basic_Profile Only Id Update
        bool AddPhotoGrapher(PhotoGrapher pht_Add);


        //Basic PhotoGrapher Additional Profile Item Edit View
        //This Id Is photoGrapher Id
        PhotoGrapher_Basic_Profile GetBasicProfile(int id);       


        //Add PhotoGrapher Additional Profile Item
        bool Update_Profile_Item(PhotoGrapher_Basic_Profile BasicAdd);


        #endregion



        #region //PhotoGrapher Experience Region


        //Add Experience
        bool AddExperience(PhotoGrapherExperience Exp);

        //Get Experience List By User Id
        //This The PhotoGrapher ID Fetch All Experience This Id And Reurn List
        IEnumerable<PhotoGrapherExperience> GetExperience(int id);


        //Update View 
        //This Id Experience ID
        bool UpdateExperience(PhotoGrapherExperience ExpUpdate,int id); 

        #endregion




        #region //PhotoGrapher Skill Region


        //Add Experience
        bool AddSkill(PhotoGrapherSkills Add_Skill);

        //Get Experience List By User Id
        //This The PhotoGrapher ID Fetch All Experience This Id And Reurn List
        IEnumerable<PhotoGrapherSkills> GetSkill(int id);


        //Update View 
        //This Id Skill ID
        bool UpdateSkill(PhotoGrapherSkills UpSkill, int id);  

        #endregion



        #region //PhotoGrapher Award Region


        //Add Experience
        bool AddAward(PhotoGrapherAward Add_Award);

        //Get Experience List By User Id
        //This The PhotoGrapher ID Fetch All Experience This Id And Reurn List
        IEnumerable<PhotoGrapherAward> GetAward(int id);


        //Update View 
        //This Id Skill ID
        bool UpdateAward(PhotoGrapherAward UpAward, int id);

        #endregion


        #region //PhotoGrapher PhotoGarphy Type Region


        //Add Experience
        bool AddPhotoGraphy_Type(PhotoGrapher_PhotoGraphy_Type Add_Type);

        //Get Experience List By User Id
        //This The PhotoGrapher ID Fetch All Experience This Id And Reurn List
        IEnumerable<PhotoGrapher_PhotoGraphy_Type> GetPhotoGraphy_Type(int id);


        //Update View 
        //This Id Skill ID
        bool UpdatePhotoGraphy_Type(PhotoGrapher_PhotoGraphy_Type UpType, int id);  

        #endregion

















    }
}
