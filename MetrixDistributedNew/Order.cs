using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixDistributedNew
{
    public class Order
    {
        private int orderId;
        private int productId;
        private int orderQuantity;
        private DateTime orderedDate;
        private DateTime expectedDate;
        private bool paid;
        private int supplierId;

        public int ordId
        {
            get
            {
                return this.orderId;
            }
            set
            {
                orderId = value;
            }
        }

        public int product
        {
            get
            {
                return this.productId;
            }
            set
            {
                productId = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.orderQuantity;
            }
            set
            {
                orderQuantity = value;
            }
        }

        public DateTime ordDate
        {
            get
            {
                return this.orderedDate;
            }
            set
            {
                orderedDate = value;
            }
        }

        public DateTime expectDate
        {
            get
            {
                return this.expectedDate;
            }
            set
            {
                expectedDate = value;
            }
        }

        public bool ordPaid
        {
            get
            {
                return this.paid;
            }
            set
            {
                paid = value;
            }
        }

        public int suplier
        {
            get
            {
                return this.supplierId;
            }
            set
            {
                supplierId = value;
            }
        }
    }
}
