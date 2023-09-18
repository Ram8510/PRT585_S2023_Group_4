using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class BorrowDto
    {
        public int BorrowId { get; set; }
        public string BorrowName { get; set; }
        public string BorrowBook { get; set; }
                        
    }

    public static class BorrowDtoMapExtensions
    {
        public static BorrowDto ToBorrowDto(this BorrowModel src)
        {
            var dst = new BorrowDto();
            dst.BorrowId = src.BorrowId;
            dst.BorrowName = src.BorrowName;
            dst.BorrowBook = src.BorrowBook;
            return dst;
        }

        public static BorrowModel ToBorrowModel(this BorrowDto src)
        {
            var dst = new BorrowModel();
            dst.BorrowId = src.BorrowId;
            dst.BorrowName = src.BorrowName;
            dst.BorrowBook = src.BorrowBook;
            return dst;
        }
    }
}
