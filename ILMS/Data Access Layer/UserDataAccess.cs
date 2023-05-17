using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILMS.Data_Access_Layer
{
    class UserDataAccess:DataAccess
    {
        public List<User> GetAllUsers()
        {
            string sql = "SELECT * FROM [Users]";
            SqlDataReader reader = GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.Id = (int)reader[0];
                user.Name = reader[1].ToString();
                user.StudentID = reader[2].ToString();
                user.Email = reader[3].ToString();
                user.Password = reader[4].ToString();
                user.DoB = reader[5].ToString();
                user.Gender = reader[6].ToString();
                user.BloodGroup = reader[7].ToString();
                user.UserType = reader[8].ToString();

                users.Add(user);
            }

            return users;
        }

        public bool AddNewUser(User user)
        {
            String sql = "INSERT INTO [Users](Name,StudentID,Email,Password,DateofBirth,Gender,BloodGroup,UserType)" +
                        " VALUES('" + user.Name + "','" + user.StudentID + "','" + user.Email + "','" + user.Password + "','" + user.DoB + "','" + user.Gender + "','" + user.BloodGroup + "','" + user.UserType + "') ";
            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return true;
            }
            return false;

        }

        public int UserVerification(string studentID, string password)
        {
            List<User> users = GetAllUsers();
            for(int i = 0; i < users.Count(); i++)
            {
                if (users[i].StudentID == studentID && users[i].Password == password && users[i].UserType=="admin")
                {
                    return 1;
                }
                else if (users[i].StudentID == studentID && users[i].Password == password && users[i].UserType == "student")
                {
                    return 2;
                }                
            }

            return 0;            
        }
    }
}
