using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IRegisterService
    {
        Task<RegisterModel?> GetById(int RegisterId);
        Task<List<RegisterModel>> GetAll();

        Task<int> CreateRegister(RegisterModel Register);
        Task UpdateRegister(RegisterModel Register);
        Task DeleteRegister(int RegisterId);
    }
}
