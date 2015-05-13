using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixDistributedNew
{
    public class Product
    {
        private int prodId;
        private string name;
        private string brand;
        private string country;
        private int supId;
        private int purchPrice;
        private int salePrice;
        private string warrenty;


        public int prodIdValue
        {
            get { return prodId; }

            set { prodId = value; }
        }

        public string nameValue
        {
            get { return name; }

            set { name = value; }
        }

        public string brandValue
        {
            get { return this.brand; }

            set { brand = value; }
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

        public int purchPriceValue
        {
            get
            {
                return this.purchPrice;
            }
            set
            {
                purchPrice = value;
            }
        }

        public int salePriceValue
        {
            get
            {
                return this.salePrice;
            }
            set
            {
                salePrice = value;
            }
        }

        public string warrentValue
        {
            get
            {
                return this.warrenty;
            }
            set
            {
                warrenty = value;
            }
        }

    }
}

