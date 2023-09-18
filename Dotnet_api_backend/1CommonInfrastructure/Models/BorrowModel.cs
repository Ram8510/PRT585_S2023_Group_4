using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class BorrowModel
    {
        public int BorrowId { get; set; } // int
        public string BorrowName { get; set; } // nvarchar(400)
        public string BorrowBook { get; set; }

    }

}
