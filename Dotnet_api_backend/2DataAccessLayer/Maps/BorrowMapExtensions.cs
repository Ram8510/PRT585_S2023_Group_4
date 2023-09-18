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
    public static class BorrowMapExtensions
    {
        public static BorrowModel ToBorrowModel(this Borrow src)
        {
            var dst = new BorrowModel();

            dst.BorrowId = src.BorrowId;
            dst.BorrowName = src.BorrowName;
            dst.BorrowBook = src.BorrowBook;

            return dst;
        }

        public static Borrow ToBorrow(this BorrowModel src, Borrow dst = null)
        {
            if (dst == null)
            {
                dst = new Borrow();
            }

            dst.BorrowId = src.BorrowId;
            dst.BorrowName = src.BorrowName;
            dst.BorrowBook = src.BorrowBook;

            return dst;
        }
    }
}
