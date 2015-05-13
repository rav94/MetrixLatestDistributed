using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetrixDistributedNew
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMetrixDistributedService" in both code and config file together.
    [ServiceContract]
    public interface ICustomerServices
    {
        [OperationContract]
        int CustomerSave(Customer customer);

        [OperationContract]
        int CustomerUpdate(Customer customer);

        [OperationContract]
        int CustomerDelete(Customer customer);

        [OperationContract]
        Customer CustomerSearch(int customerId);
    }


    [ServiceContract]
    public interface IEmployeeServices
    {
        [OperationContract]
        int EmployeeSave(Employee employee);

        [OperationContract]
        int EmployeeUpdate(Employee employee);

        [OperationContract]
        int EmployeeDelete(Employee employee);

        [OperationContract]
        Employee EmployeeSearch(int employeeId);
    }

    [ServiceContract]
    public interface IProductServices
    {
        [OperationContract]
        int ProductSave(Product product);

        [OperationContract]
        int ProductUpdate(Product product);

        [OperationContract]
        int ProductDelete(Product product);

        [OperationContract]
        Product ProductSearch(int productId);
    }

    [ServiceContract]
    public interface ISupplierServices
    {
        [OperationContract]
        int SupplierSave(Supplier supplier);

        [OperationContract]
        int SupplierUpdate(Supplier supplier);

        [OperationContract]
        int SupplierDelete(Supplier supplier);

        [OperationContract]
        Supplier SupplierSearch(int supplierId);
    }

    //[ServiceContract]
    //public interface IStockServices
    //{
    //    [OperationContract]
    //    int StockSave(Stock stock);

    //    [OperationContract]
    //    int SupplierUpdate(Stock stock);

    //    [OperationContract]
    //    int StockDelete(Stock stock);

    //    [OperationContract]
    //    Stock StockSearch(int stockid);

    //    //search in stock level
    //    //[OperationContract]
    //    //Stock SearchInStock();

    //    //[OperationContract]
    //    //void UpdateInvoiceByStock(Stock stock);
    //}

    [ServiceContract]
    public interface IInvoiceServices
    {
        [OperationContract]
        int InvoiceSave(Invoice invoice);

        [OperationContract]
        int SaveInvoiceList(Invoice invoice);

        [OperationContract]
        Invoice InvoiceProductSearch(int productId);
    }

    [ServiceContract]
    public interface IOrderServices
    {
        [OperationContract]
        int OrderSave(Order order);

        [OperationContract]
        int OrderUpdate(Order order);

        [OperationContract]
        int OrderDelete(Order order);

        //[OperationContract]
        //Order OrderSearch(int orderId); 

        [OperationContract]
        int SaveOrderList(Order order);

    }

    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        int SignIn(user user);
    }

    [ServiceContract]
    public interface IUserSettingsServices
    {
        [OperationContract]
        int SignUp(UserSettings usersett);

        [OperationContract]
        int ChangeUser(UserSettings usersett);

    }

}
