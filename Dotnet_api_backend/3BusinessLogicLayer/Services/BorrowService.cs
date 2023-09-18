

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class BorrowService :  IBorrowService
    {
        private readonly IBorrowDal _BorrowDal;
        //private readonly IBorrowBalService _BorrowBalService;
        public BorrowService(IBorrowDal BorrowDal
        //ILoggingService loggingService,
        //IBorrowDal BorrowDal,
        //IAuditDal auditDal
       // IBorrowBalanceService balsvc
        ) 
        {
            _BorrowDal = BorrowDal;
            // _BorrowBalService = balsvc;
        }

        public async Task<BorrowModel?> GetById(int BorrowId)
        {           
            return _BorrowDal.GetById(BorrowId);
        }

        public async Task<List<BorrowModel>> GetAll()
        {            
            return _BorrowDal.GetAll();
        }

        public async Task<int> CreateBorrow(BorrowModel Borrow)
        {
            //write validations here
            var newBorrowId = _BorrowDal.CreateBorrow(Borrow);
            return newBorrowId;
        }

        public async Task UpdateBorrow(BorrowModel Borrow)
        {
            //write validations here 
            _BorrowDal.UpdateBorrow(Borrow);
        }

        public async Task DeleteBorrow(int BorrowId)
        {            
            try
            {
                //if(balservice.getBal(BorrowId) = 0)
                _BorrowDal.DeleteBorrow(BorrowId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Borrow Id:{BorrowId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
