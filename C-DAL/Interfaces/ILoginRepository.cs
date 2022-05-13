using System;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.C_DAL.Interfaces
{
    public interface ILoginRepository:IBaseRepository<Login>
    {
        Login LogIn(string usuario,string senha);
    }
}
