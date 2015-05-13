using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixDistributedNew
{
    public class Invoice
    {
        private int invoiceId;
        private DateTime date;
        private string InvoiceTime;
        private int total;
        private int EmpId;
        private int ProductId;
        private int CustomerId;
        private int Quantity;

        public int invoice
        {
            get
            {
                return invoiceId;
            }
            set
            {
                invoiceId = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public String Invotime
        {
            get
            {
                return InvoiceTime;
            }
            set
            {
                InvoiceTime = value;
            }
        }

        public int tot
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }

        public int employeeId
        {
            get
            {
                return EmpId;
            }
            set
            {
                EmpId = value;
            }
        }
        public int product
        {
            get
            {
                return this.ProductId;
            }
            set
            {
                ProductId = value;
            }
        }
        public int quan
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity = value;
            }
        }
        public int customer
        {
            get
            {
                return CustomerId;
            }
            set
            {
                CustomerId = value;
            }
        }
    }
}
