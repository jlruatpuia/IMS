using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Server2Client
/// </summary>
public class Server2Client
{
    public int Count { get; set; }
    public double Value { get; set; }
    public string Message { get; set; }
    public DataTable dataTable { get; set; }
    public DataSet dataSet { get; set; }

}

public class Category
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }

}

public class Customer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Balance { get; set; }
}
public class CustomerAccount
{
    public int CustomerAccountID { get; set; }
    public int CustomerID { get; set; }
    public DateTime TransDate { get; set; }
    public string Description { get; set; }
    public double Debit { get; set; }
    public double Credit { get; set; }
    public double Balance { get; set; }
}

public class Product
{
    public int ProductID { get; set; }
    public string ProductCode { get; set; }
    public int CategoryID { get; set; }
    public int SupplierID { get; set; }
    public string ProductName { get; set; }
    public double BuyingValue { get; set; }
    public double SellingValue { get; set; }
    public int Quantity { get; set; }
    public string BarCode { get; set; }
    public string Message { get; set; }
}
public class ProductDetail
{
    public int ProductDetailID { get; set; }
    public int ProductID { get; set; }
    public double BuyingValue { get; set; }
    public double SellingValue { get; set; }
    public int Quantity { get; set; }
}
public class Purchase
{
    public int PurchaseID { get; set; }
    public string InvoiceNo { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int SupplierID { get; set; }
    public double Amount { get; set; }
    public double Payment { get; set; }
    public double Balance { get; set; }
}
public class PurchaseDetail
{
    public int PurchaseDetailID { get; set; }
    public string InvoiceNo { get; set; }
    public string ProductCode { get; set; }
    public double BuyingValue { get; set; }
    public double SellingValue { get; set; }
    public int Quantity { get; set; }
    public double Amount { get; set; }
}
public class Sale
{
    public int SaleID { get; set; }
    public string InvoiceNo { get; set; }
    public DateTime SaleDate { get; set; }
    public int CustomerID { get; set; }
    public double Amount { get; set; }
    public double Discount { get; set; }
    public double Payment { get; set; }
    public double Balance { get; set; }
}
public class SaleDetail
{
    public int SaleDetailID { get; set; }
    public string InvoiceNo { get; set; }
    public int ProductID { get; set; }
    public double BuyingValue { get; set; }
    public double SellingValue { get; set; }
    public int Quantity { get; set; }
    public double Amount { get; set; }
}
public class Supplier
{
    public int SupplierID { get; set; }
    public string SupplierName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public double Balance { get; set; }
}
public class SupplierAccount
{
    public int SupplierAccountID { get; set; }
    public int SupplierID { get; set; }
    public DateTime TransDate { get; set; }
    public string Description { get; set; }
    public double Debit { get; set; }
    public double Credit { get; set; }
    public double Balance { get; set; }
}

public class User
{
    public int ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int AccountType { get; set; }
    public bool Active { get; set; }
}