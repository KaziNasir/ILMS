using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILMS.Data_Access_Layer
{
    class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String StudentID { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String DoB { get; set; }
        public String Gender { get; set; }
        public String BloodGroup { get; set; }
        public String UserType { get; set; }

    }
}
