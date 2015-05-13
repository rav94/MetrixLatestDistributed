using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixDistributedNew
{
    public class Customer
    {
        private int cusId;
        private string cusName;
        private string cusContact;
        private string cusNic;
        private string cusAdLine1;
        private string cusAdLine2;
        private string cusAdLine3;

        public int cusIdValue
        {
            get
            {
                return cusId;
            }
            set
            {
                cusId = value;
            }
        }

        public string cusNameValue
        {
            get
            {
                return cusName;
            }
            set
            {
                cusName = value;
            }
        }

        public string cusContactValue
        {
            get
            {
                return cusContact;
            }
            set
            {
                cusContact = value;
            }
        }


        public string cusNicValue
        {
            get
            {
                return cusNic;
            }
            set
            {
                cusNic = value;
            }
        }


        public string cusAdLine1Value
        {
            get
            {
                return cusAdLine1;
            }
            set
            {
                cusAdLine1 = value;
            }
        }

        public string cusAdLine2Value
        {
            get
            {
                return cusAdLine2;
            }
            set
            {
                cusAdLine2 = value;
            }
        }

        public string cusAdLine3Value
        {
            get
            {
                return cusAdLine3;
            }
            set
            {
                cusAdLine3 = value;
            }
        }
    }
    }

