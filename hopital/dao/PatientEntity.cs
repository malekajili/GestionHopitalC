using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace hopital.dao
{
    public class PatientEntity : UserBaseEntity
    {
        public string address {  get; set; }
        public PatientEntity() { }
        public PatientEntity(string name, string email, string gender, string phone, int age, string address)
            : base(name, email, gender, phone, age) {
            this.address = address;
        }
    }
}
