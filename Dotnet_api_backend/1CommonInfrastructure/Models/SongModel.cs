using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class SongModel
    {
        public int SongId { get; set; } // int
        public string SongName { get; set; } // nvarchar(400)
        public string SongAuthor { get; set; }

    }

}
