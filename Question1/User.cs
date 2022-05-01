using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class User
    {
        public User(int UserId, string DOB, string UserName, char Gender, string GuardianName)
        {
            this.UserId = UserId;
            this.DOB = DOB;
            this.UserName = UserName;
            this.Gender = Gender;
            this.GuardianName = GuardianName;
        }

        public Int32 UserId { get; set; }
        public string UserName { get; set; }
        public string DOB { get; set; }
        public string GuardianName { get; set; }
        public char Gender { get; set; }

    }
}
