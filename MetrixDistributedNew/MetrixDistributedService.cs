using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using MySql.Data.MySqlClient;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace MetrixDistributedNew
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MetrixDistributedService" in both code and config file together.
    public class MetrixDistributedService : ICustomerServices, IEmployeeServices, IProductServices, ISupplierServices, IInvoiceServices, IOrderServices, ILoginService, IUserSettingsServices
    //IStockServices 
    {
        DatabaseConnection db = new DatabaseConnection();
        //Customer Interface
        public int CustomerSave(Customer customer)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO customer VALUES('" + customer.cusIdValue + "','" + customer.cusNameValue + "','" + customer.cusContactValue + "', '" + customer.cusNicValue + "', '" + customer.cusAdLine1Value + "', '" + customer.cusAdLine2Value + "', '" + customer.cusAdLine3Value + "')";

            return new DatabaseConnection().Query(sql);
        }

        public int CustomerUpdate(Customer customer)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE customer SET  Name='" + customer.cusNameValue + "', ContactNo='" + customer.cusContactValue + "', NICNo='" + customer.cusNicValue + "', AddressLine1='" + customer.cusAdLine1Value + "', AddressLine2='" + customer.cusAdLine2Value + "', AddressLine3='" + customer.cusAdLine3Value + "' WHERE CustomerId='" + customer.cusIdValue + "'";

            return new DatabaseConnection().Query(sql);
        }

        public int CustomerDelete(Customer customer)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "DELETE FROM customer WHERE CustomerId='" + customer.cusIdValue + "'";

            return new DatabaseConnection().Query(sql);
        }

        public Customer CustomerSearch(int customerId)
        {
            Customer customer = new Customer();
            DatabaseConnection db = new DatabaseConnection();

            string sql = "SELECT * FROM customer WHERE CustomerId = '" + customerId + "' ";
            DataTable table = db.SearchQuery(sql);
            customer.cusNameValue = table.Rows[0][1].ToString();
            customer.cusContactValue = table.Rows[0][3].ToString();
            customer.cusNicValue = table.Rows[0][2].ToString();
            customer.cusAdLine1Value = table.Rows[0][4].ToString();
            customer.cusAdLine2Value = table.Rows[0][5].ToString();
            customer.cusAdLine3Value = table.Rows[0][6].ToString();

            return customer;
        }
        //Employee Interface
        public int EmployeeSave(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO employee VALUES('" + employee.empIdValue + "','" + employee.empNameValue + "','" + employee.empContactValue + "', '" + employee.empAdLine1Value + "', '" + employee.empAdLine2Value + "', '" + employee.empDobValue + "', '" + employee.empNicValue + "', '" + employee.empPosValue + "', '" + employee.empDeptValue + "')";

            return new DatabaseConnection().Query(sql);
        }

        public int EmployeeUpdate(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE employee SET EmpName = '" + employee.empNameValue + "', ContactNo = '" + employee.empContactValue + "', AddressLine1 = '" + employee.empAdLine1Value + "', AddressLine2='" + employee.empAdLine2Value + "', DOB='" + employee.empDobValue + "', NICNo='" + employee.empNicValue + "', Position='" + employee.empPosValue + "', Department='" + employee.empDeptValue + "' WHERE EmpId='" + employee.empIdValue + "'";

            return new DatabaseConnection().Query(sql);
        }

        public int EmployeeDelete(Employee employee)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "DELETE FROM employee WHERE EmpId='" + employee.empIdValue + "' ";

            return new DatabaseConnection().Query(sql);
        }

        public Employee EmployeeSearch(int employeeId)
        {
            Employee employee = new Employee();
            DatabaseConnection db = new DatabaseConnection();

            string sql = "SELECT * FROM employee WHERE EmpId = '" + employeeId + "'";
            DataTable table = db.SearchQuery(sql);
            employee.empNameValue = table.Rows[0][1].ToString();
            employee.empContactValue = table.Rows[0][2].ToString();
            employee.empAdLine1Value = table.Rows[0][3].ToString();
            employee.empAdLine2Value = table.Rows[0][4].ToString();
            employee.empDobValue = Convert.ToDateTime(table.Rows[0][5].ToString());
            employee.empNicValue = table.Rows[0][6].ToString();
            employee.empPosValue = table.Rows[0][7].ToString();
            employee.empDeptValue = table.Rows[0][8].ToString();

            return employee;
        }
        //Product Interface
        public int ProductSave(Product product)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO product VALUES('" + product.prodIdValue + "','" + product.nameValue + "','" + product.brandValue + "', '" + product.countryValue + "', '" + product.supIdValue + "', '" + product.purchPriceValue + "', '" + product.salePriceValue + "', '" + product.warrentValue + "')";

            return new DatabaseConnection().Query(sql);
        }

        public int ProductUpdate(Product product)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE product SET ProductName = '" + product.nameValue + "',  Brand= '" + product.brandValue + "', Country = '" + product.countryValue + "', SupplierId='" + product.supIdValue + "',PurchasePrice='" + product.purchPriceValue + "', SalesPrice='" + product.salePriceValue + "', Warrenty='" + product.warrentValue + "' WHERE productId='" + product.prodIdValue + "'   ";

            return new DatabaseConnection().Query(sql);
        }

        public int ProductDelete(Product product)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "DELETE FROM product WHERE productId='" + product.prodIdValue + "'";

            return new DatabaseConnection().Query(sql);
        }

        public Product ProductSearch(int productId)
        {
            Product product = new Product();
            DatabaseConnection db = new DatabaseConnection();

            string sql = "SELECT * FROM product WHERE productId = '" + productId + "'";
            DataTable table = db.SearchQuery(sql);
            product.nameValue = table.Rows[0][1].ToString();
            product.brandValue = table.Rows[0][2].ToString();
            product.countryValue = table.Rows[0][3].ToString();
            product.supIdValue = Convert.ToInt16(table.Rows[0][4].ToString());
            product.purchPriceValue = Convert.ToInt16(table.Rows[0][5].ToString());
            product.salePriceValue = Convert.ToInt16(table.Rows[0][6].ToString());
            product.warrentValue = table.Rows[0][7].ToString();

            return product;
        }
        //Supplier Interface
        public int SupplierSave(Supplier supplier)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO supplier VALUES('" + supplier.supIdValue + "','" + supplier.companyNameValue + "','" + supplier.contactValue + "', '" + supplier.add + "', '" + supplier.countryValue + "', '" + supplier.emailValue + "', '" + supplier.refNameValue + "') ";

            return new DatabaseConnection().Query(sql);
        }

        public int SupplierUpdate(Supplier supplier)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE supplier SET CompanyName = '" + supplier.companyNameValue + "',  ContactNo= '" + supplier.contactValue + "', Address = '" + supplier.add + "', Country='" + supplier.countryValue + "',Email='" + supplier.emailValue + "', ReferenceName='" + supplier.refNameValue + "' WHERE SupplierId='" + supplier.supIdValue + "' ";

            return new DatabaseConnection().Query(sql);
        }

        public int SupplierDelete(Supplier supplier)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "DELETE FROM product WHERE SupplierId='" + supplier.supIdValue + "' ";

            return new DatabaseConnection().Query(sql);
        }

        public Supplier SupplierSearch(int supplierId)
        {
            Supplier supplier = new Supplier();
            DatabaseConnection db = new DatabaseConnection();

            string sql = "SELECT * FROM supplier WHERE SupplierId = '" + supplierId + "'";
            DataTable table = db.SearchQuery(sql);
            supplier.companyNameValue = table.Rows[0][1].ToString();
            supplier.contactValue = table.Rows[0][2].ToString();
            supplier.add = table.Rows[0][3].ToString();
            supplier.countryValue = table.Rows[0][4].ToString();
            supplier.emailValue = table.Rows[0][5].ToString();
            supplier.refNameValue = table.Rows[0][6].ToString();

            return supplier;
        }

        ////public int ForeignSupplierSave(ForeignSupplier fsupplier)
        ////{
        ////    MySqlCommand cmd = new MySqlCommand();
        ////    string sql = "INSERT INTO supplier VALUES('" + fsupplier.supIdValue + "','" + fsupplier.companyNameValue + "','" + fsupplier.contactValue + "', '" + fsupplier.add + "', '" + fsupplier.countryValue + "', '" + fsupplier.emailValue + "', '" + fsupplier.refNameValue + "') ";

        ////    return new DatabaseConnection().Query(sql);
        ////}

        ////public int ForeignSupplierUpdate(ForeignSupplier fsupplier)
        ////{
        ////    MySqlCommand cmd = new MySqlCommand();
        ////    string sql = "UPDATE suplier SET CompanyName = '" + fsupplier.companyNameValue + "',  ContactNo= '" + fsupplier.contactValue + "', Address = '" + fsupplier.add + "', Country='" + fsupplier.countryValue + "',Email='" + fsupplier.emailValue + "', ReferenceName='" + fsupplier.refNameValue + "' ";

        ////    return new DatabaseConnection().Query(sql);
        ////}

        ////public int ForeignSupplierDelete(ForeignSupplier fsupplier)
        ////{
        ////    throw new NotImplementedException();
        ////}

        ////public ForeignSupplier ForeignSupplierSearch(int supplierId)
        ////{
        ////    ForeignSupplier fsupplier = new ForeignSupplier();
        ////    DatabaseConnection db = new DatabaseConnection();

        ////    string sql = "SELECT * FROM supplier WHERE SupplierId = '"+fsupplier.supIdValue+"'";
        ////    DataTable table = db.SearchQuery(sql);
        ////    fsupplier.companyNameValue = table.Rows[0][1].ToString();
        ////    fsupplier.contactValue = table.Rows[0][2].ToString();
        ////    fsupplier.add = table.Rows[0][3].ToString();
        ////    fsupplier.countryValue = table.Rows[0][4].ToString();
        ////    fsupplier.emailValue = table.Rows[0][5].ToString();
        ////    fsupplier.refNameValue = table.Rows[0][6].ToString();

        ////    return fsupplier;

        ////}

        ////Stock Interface
        //public int StockSave(Stock stock)
        //{
        //    MySqlCommand cmd = new MySqlCommand();
        //    string sql = "INSERT INTO stock(ProductId,InStock,ReorderLevel,ReorderQuantity,Ordered) VALUES( '" + stock.productId + "','" + stock.Sinstock + "','" + stock.Srelevel + "','" + stock.Squan + "','" + stock.Sordered + "')";

        //    return new DatabaseConnection().Query(sql);
        //}

        //public int SupplierUpdate(Stock stock)
        //{
        //    MySqlCommand cmd = new MySqlCommand();
        //    string sql = "UPDATE stock SET InStock = '" + stock.Sinstock + "', ReorderLevel = '" + stock.Srelevel + "', ReorderQuantity = '" + stock.Squan + "', Ordered = '" + stock.Sordered + "' WHERE ProductId = '" + stock.productId + "' ;";

        //    return new DatabaseConnection().Query(sql);
        //}

        //public int StockDelete(Stock stock)
        //{
        //    MySqlCommand cmd = new MySqlCommand();
        //    string sql = "DELETE FROM stock WHERE ProductId= '" + stock.productId + "' ";

        //    return new DatabaseConnection().Query(sql);
        //}

        //public Stock StockSearch(int stockid)
        //{
        //    Stock stock = new Stock();
        //    DatabaseConnection db = new DatabaseConnection();

        //    string sql = "SELECT * FROM stock WHERE ProductId = '" + stockid + "' ";
        //    DataTable table = db.SearchQuery(sql);
        //    stock.Sinstock = Convert.ToInt16(table.Rows[0][1].ToString());
        //    stock.Srelevel = Convert.ToInt16(table.Rows[0][2].ToString());
        //    stock.Squan = Convert.ToInt16(table.Rows[0][3].ToString());
        //    stock.Sordered = Convert.ToInt16(table.Rows[0][4].ToString());

        //    return stock;
        //}

        //public Stock SearchInStock()
        //{
        //    Stock stock = new Stock();
            

        //    string sql = "SELECT `InStock`, `ReorderLevel` FROM `stock` WHERE `ProductId` = '" + stock.proInvo + "' ";

        //    DataTable table = db.SearchQuery(sql);
        //    stock.Sinstock = Convert.ToInt16(table.Rows[0][1].ToString());
        //    stock.Srelevel = Convert.ToInt16(table.Rows[0][2].ToString());

        //    return stock;
        //}

        //public void UpdateInvoiceByStock(Stock stock)
        //{
        //    SearchInStock();

        //    stock.setBalance = stock.Sinstock - stock.quanInvo; //set balance

        //    //message for reorder level
        //    if (stock.setBalance <= stock.Srelevel)
        //    {
        //        MessageBox.Show("Stock balance is getting low. Order new products");
        //    }

        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand();
        //        string sql = "UPDATE `stock` SET `InStock`='" + stock.setBalance + "',`ReorderLevel`='" + stock.Srelevel + "',`ReorderQuantity`='" + stock.Squan + "',`Ordered`='" + stock.Sordered + "' WHERE `ProductId`='" + stock.proInvo + "' ";

        //        new DatabaseConnection().Query(sql);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error" + ex);
        //    }
        //}
        
        
        //Invoice Interface
        public int InvoiceSave(Invoice invoice)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO `transaction`(`TransactionId`, `Date`, `Time`, `Total`, `EmpId`, `CustomerId`) VALUES( '" + invoice.invoice + "','" + invoice.Date + "','" + invoice.Invotime + "','" + invoice.tot + "','" + invoice.employeeId + "','" + invoice.customer + "')";

            return new DatabaseConnection().Query(sql);
        }

        public int SaveInvoiceList(Invoice invoice)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO `transproduct`(`invoId`,`producId`, `quantity`) VALUES ( '" + invoice.invoice + "','" + invoice.product + "','" + invoice.quan + "')";

            return new DatabaseConnection().Query(sql);
        }

        public Invoice InvoiceProductSearch(int productId)
        {
            Invoice invoice = new Invoice();
            DatabaseConnection db = new DatabaseConnection();

            string sql = "SELECT `Date`, `Time`, `Total`, `EmpId`, `CustomerId` FROM `transaction` WHERE `TransactionId`='" + invoice.invoice + "' ";

            DataTable table = db.SearchQuery(sql);
            invoice.Date = Convert.ToDateTime(table.Rows[0][1].ToString());
            invoice.Invotime = table.Rows[0][2].ToString();
            invoice.tot = Convert.ToInt16(table.Rows[0][3].ToString());
            invoice.employeeId = Convert.ToInt16(table.Rows[0][4].ToString());
            invoice.customer = Convert.ToInt16(table.Rows[0][5].ToString());

            return invoice;
        }
        
        //Order Interface
        public int OrderSave(Order order)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO order(OrderId,OrderedDate,ExpectedDate,SupplierId) VALUES( '" + order.ordId + "','" + order.ordDate + "','" + order.expectDate + "','" + order.suplier + "')";

            return new DatabaseConnection().Query(sql);
        }

        public int OrderUpdate(Order order)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE order SET OrderedDate = '" + order.ordDate + "',  ExpectedDate= '" + order.expectDate + "', SupplierId = '" + order.suplier + "' WHERE OrderId='" + order.ordId + "' ";

            return new DatabaseConnection().Query(sql);
        }

        public int OrderDelete(Order order)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "DELETE FROM order WHERE OrderId= '" + order.ordId + "' ";

            return new DatabaseConnection().Query(sql);
        }

        //public Order OrderSearch(int orderId)
        //{
        //    //Order order = new Order();
        //    //DatabaseConnection db = new DatabaseConnection();

        //    //string sql = "SELECT `Date`, `Time`, `Total`, `EmpId`, `CustomerId` FROM `transaction` WHERE `TransactionId`='" + invoice.invoice + "' ";

        //    //DataTable table = db.SearchQuery(sql);
        //    //Order

        //    //return order;
        //}

        public int SaveOrderList(Order order)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO orderlist(OrderId, ProductId, Quantity) VALUES('" + order.ordId + "','" + order.product + "','" + order.Quantity + "')";

            return new DatabaseConnection().Query(sql);
        }

        
        //Login Service
        public int SignIn(user user)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "SELECT `username`, `password` FROM `credentials` WHERE `username`='" + user.Username + "' ";
            return new DatabaseConnection().Query(sql);
        }

        //User settings service
        public int SignUp(UserSettings usersett)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO `credentials`(`username`, `password`) VALUES ('" + usersett.user + "','" + usersett.pass + "') ";
            return new DatabaseConnection().Query(sql);
        }

        public int ChangeUser(UserSettings usersett)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "UPDATE `credentials` SET `password`='" + usersett.pass + "' WHERE `username`='" + usersett.user + "' ";
            return new DatabaseConnection().Query(sql);
        }
    }
}
