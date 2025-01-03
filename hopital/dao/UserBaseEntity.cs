using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hopital.dao
{
    public class UserBaseEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public int age { get; set; }
        public UserBaseEntity(){}

        public UserBaseEntity(string name, string email, string gender, string phone, int age)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.phone = phone;
            this.age = age;
        }

        public UserBaseEntity(string name, string email, string gender, string password, string phone, int age) { 
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.password = password;
            this.phone = phone;
            this.age = age;
        }
    }
}
