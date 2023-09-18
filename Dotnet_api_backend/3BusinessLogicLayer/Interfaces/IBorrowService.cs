using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IBorrowService
    {
        Task<BorrowModel?> GetById(int BorrowId);
        Task<List<BorrowModel>> GetAll();

        Task<int> CreateBorrow(BorrowModel Borrow);
        Task UpdateBorrow(BorrowModel Borrow);
        Task DeleteBorrow(int BorrowId);
    }
}
