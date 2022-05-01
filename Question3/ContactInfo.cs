using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class ContactInfo
    {
        public ContactInfo(string Address,string City,string State,string Country,string MobileNo,string EmailId)
        {
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Country = Country;
            this.MobileNo = MobileNo;
            this.EmailId = EmailId;
        }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string MobileNo { get; set; }

        public string EmailId { get; set; }

    }
}
