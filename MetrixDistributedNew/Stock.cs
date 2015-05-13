using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixDistributedNew
{
    public class Stock
    {
        private int id;
        private int proid;
        private int instock;
        private int relevel;
        private int requan;
        private int orderer;
        private int proidInvo;
        private int quantityInvo;
        private int balance;


        public int productId
        {
            get
            {
                return proid;
            }
            set
            {
                proid = value;
            }
        }


        public int proInvo
        {
            get
            {
                return proidInvo;
            }
            set
            {
                proidInvo = value;
            }
        }

        public int quanInvo
        {
            get
            {
                return quantityInvo;
            }
            set
            {
                quantityInvo = value;
            }
        }

        public int sid
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int SproId
        {
            get
            {
                return proid;
            }
            set
            {
                proid = value;
            }
        }
        public int Sinstock
        {
            get
            {
                return instock;
            }
            set
            {
                instock = value;
            }
        }
        public int Srelevel
        {
            get
            {
                return relevel;
            }
            set
            {
                relevel = value;
            }
        }
        public int Squan
        {
            get
            {
                return requan;
            }
            set
            {
                requan = value;
            }
        }
        public int Sordered
        {
            get
            {
                return orderer;
            }
            set
            {
                orderer = value;
            }
        }

        public int setBalance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
