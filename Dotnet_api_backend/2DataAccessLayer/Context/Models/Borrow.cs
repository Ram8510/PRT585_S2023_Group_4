using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public string BorrowName { get; set; }
        public string BorrowBook { get; set; }
    }
}
