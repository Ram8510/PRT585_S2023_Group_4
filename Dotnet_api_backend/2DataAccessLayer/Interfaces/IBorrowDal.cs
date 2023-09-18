using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IBorrowDal
    {
        // Getters
        BorrowModel? GetById(int BorrowId);
        List<BorrowModel> GetAll();

        // Actions
        int CreateBorrow(BorrowModel Borrow);
        void UpdateBorrow(BorrowModel Borrow);
        void DeleteBorrow(int BorrowId);
    }
}
