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
    public static class RegisterMapExtensions
    {
        public static RegisterModel ToRegisterModel(this Register src)
        {
            var dst = new RegisterModel();

            dst.RegisterId = src.RegisterId;
            dst.RegisterName = src.RegisterName;

            return dst;
        }

        public static Register ToRegister(this RegisterModel src, Register dst = null)
        {
            if (dst == null)
            {
                dst = new Register();
            }

            dst.RegisterId = src.RegisterId;
            dst.RegisterName = src.RegisterName;

            return dst;
        }
    }
}
