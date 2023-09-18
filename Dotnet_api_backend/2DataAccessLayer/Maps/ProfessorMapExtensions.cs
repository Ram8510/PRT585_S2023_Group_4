using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class ProfessorMapExtensions
    {
        public static ProfessorModel ToProfessorModel(this Professor src)
        {
            var dst = new ProfessorModel();

            dst.ProfessorId = src.ProfessorId;
            dst.ProfessorName = src.ProfessorName;
            dst.ProfessorDepartment = src.ProfessorDepartment;

            return dst;
        }

        public static Professor ToProfessor(this ProfessorModel src, Professor dst = null)
        {
            if (dst == null)
            {
                dst = new Professor();
            }

            dst.ProfessorId = src.ProfessorId;
            dst.ProfessorName = src.ProfessorName;
            dst.ProfessorDepartment = src.ProfessorDepartment;

            return dst;
        }
    }
}
