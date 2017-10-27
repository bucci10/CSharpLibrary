using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorChallenge
{
    class MobilePhone
    {    //Bronze Challenge

        public MobilePhone(string make, string model)

        {
            this.PhoneMake = make;
            this.PhoneModel = model;
        }

        public string PhoneMake { get; set; }
        public string PhoneModel { get; set; }
        
    }

   
}
