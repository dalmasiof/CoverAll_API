using System;
using CoverAll_API.B_Service;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.B_BLL.Interfaces
{
    public interface ILoginService : IBaseService<Login>
    {
        Cliente LogIn(string usuario,string senha);
    }
}
