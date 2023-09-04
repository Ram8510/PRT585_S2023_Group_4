using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IProfessorDal
    {
        // Getters
        ProfessorModel? GetById(int ProfessorId);
        List<ProfessorModel> GetAll();

        // Actions
        int CreateProfessor(ProfessorModel Professor);
        void UpdateProfessor(ProfessorModel Professor);
        void DeleteProfessor(int ProfessorId);
    }
}
