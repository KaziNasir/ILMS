using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILMS.Data_Access_Layer
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Genre { get; set; }
        public String Author { get; set; }
        public String PublishedDate { get; set; }
        public String Edition { get; set; }
        public String Issued { get; set; }

    }
}
