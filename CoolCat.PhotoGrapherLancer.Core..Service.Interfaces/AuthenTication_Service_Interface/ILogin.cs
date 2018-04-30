using CoolCat.PhotoGrapherLancer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Service.Interfaces.AuthenTication_Service_Interface
{
    public  interface ILogin
    {
        bool Login(Login  user);
    }
}
