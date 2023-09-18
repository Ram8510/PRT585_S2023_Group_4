using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IRegisterDal
    {
        // Getters
        RegisterModel? GetById(int RegisterId);
        List<RegisterModel> GetAll();

        // Actions
        int CreateRegister(RegisterModel Register);
        void UpdateRegister(RegisterModel Register);
        void DeleteRegister(int RegisterId);
    }
}
