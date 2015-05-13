using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MetrixDistributedNew
{
   
    public class Supplier
    {
        private int supId;
        private string companyName;
        private string address;
        private string contact;
        private string refName;
        private string email;
        private string country;

        public int supIdValue
        {
            get
            {
                return this.supId;
            }
            set
            {
                supId = value;
            }
        }

        public string companyNameValue
        {
            get
            {
                return this.companyName;
            }
            set
            {
                companyName = value;
            }
        }

        public string contactValue
        {
            get
            {
                return this.contact;
            }
            set
            {
                contact = value;
            }
        }

        public string refNameValue
        {
            get
            {
                return this.refName;
            }
            set
            {
                refName = value;
            }
        }

        public string emailValue
        {
            get
            {
                return this.email;
            }
            set
            {
                email = value;
            }
        }

        public string add
        {
            get
            {
                return this.address;
            }
            set
            {
                address = value;
            }
        }

        public string countryValue
        {
            get
            {
                return this.country;
            }
            set
            {
                country = value;
            }
        }
        
        
    }

    
}

