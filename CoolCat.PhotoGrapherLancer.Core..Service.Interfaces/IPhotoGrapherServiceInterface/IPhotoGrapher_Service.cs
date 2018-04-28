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
        PhotoGrapher GetPhotoGrapher(int id);    //This Is The Get Id Then All type Of Details Fetch by This ID 



        //Add PhotoGrapher When Register Basic Item

        bool AddPhotoGrapher(PhotoGrapher pht_Add); //When Add Another Table Update PhotoGrapher_Basic_Profile Only Id Update


        //Basic PhotoGrapher Additional Profile Item Edit View

        PhotoGrapher_Basic_Profile GetBasicProfile(int id);       //This Id Is photoGrapher Id


        //Add PhotoGrapher Additional Profile Item
        bool Update_Profile_Item(PhotoGrapher_Basic_Profile BasicAdd);


        #endregion



        #region //PhotoGrapher Experience Region


        //Add Experience
        bool AddExperience(PhotoGrapherExperience Exp);

        //Get Experience List By User Id

        IEnumerable<PhotoGrapherExperience> GetExperience(int id); //This The PhotoGrapher ID Fetch All Experience This Id And Reurn List


        //Update View 

        bool UpdateExperience(PhotoGrapherExperience ExpUpdate,int id);  //This Id Experience ID

        #endregion




        #region //PhotoGrapher Skill Region


        //Add Experience
        bool AddSkill(PhotoGrapherSkills Add_Skill);

        //Get Experience List By User Id

        IEnumerable<PhotoGrapherSkills> GetSkill(int id); //This The PhotoGrapher ID Fetch All Experience This Id And Reurn List


        //Update View 

        bool UpdateSkill(PhotoGrapherSkills UpSkill, int id);  //This Id Skill ID

        #endregion



        #region //PhotoGrapher Award Region


        //Add Experience
        bool AddAward(PhotoGrapherAward Add_Award);

        //Get Experience List By User Id

        IEnumerable<PhotoGrapherAward> GetAward(int id); //This The PhotoGrapher ID Fetch All Experience This Id And Reurn List


        //Update View 

        bool UpdateAward(PhotoGrapherAward UpAward, int id);  //This Id Skill ID

        #endregion


        #region //PhotoGrapher PhotoGarphy Type Region


        //Add Experience
        bool AddPhotoGraphy_Type(PhotoGrapher_PhotoGraphy_Type Add_Type);

        //Get Experience List By User Id

        IEnumerable<PhotoGrapher_PhotoGraphy_Type> GetPhotoGraphy_Type(int id); //This The PhotoGrapher ID Fetch All Experience This Id And Reurn List


        //Update View 

        bool UpdatePhotoGraphy_Type(PhotoGrapher_PhotoGraphy_Type UpType, int id);  //This Id Skill ID

        #endregion

















    }
}
