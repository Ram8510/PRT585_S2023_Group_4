using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IProfessorService
    {
        Task<ProfessorModel?> GetById(int ProfessorId);
        Task<List<ProfessorModel>> GetAll();

        Task<int> CreateProfessor(ProfessorModel Professor);
        Task UpdateProfessor(ProfessorModel Professor);
        Task DeleteProfessor(int ProfessorId);
    }
}
