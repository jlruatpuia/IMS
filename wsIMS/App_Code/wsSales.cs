using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsSales
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsSales : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    [WebMethod]
    public Server2Client AddSale(Sale sls)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO Sale (InvoiceNo, SaleDate, CustomerID, Amount, Discount, Payment, Balance) VALUES (@INV, @SDT, @CID, @AMT, @DSC, @PMT, @BAL)", cm);
        cmd.Parameters.AddWithValue("@INV", sls.InvoiceNo);
        cmd.Parameters.AddWithValue("@SDT", sls.SaleDate);
        cmd.Parameters.AddWithValue("@CID", sls.CustomerID);
        cmd.Parameters.AddWithValue("@AMT", sls.Amount);
        cmd.Parameters.AddWithValue("@DSC", sls.Discount);
        cmd.Parameters.AddWithValue("@PMT", sls.Payment);
        cmd.Parameters.AddWithValue("@BAL", sls.Balance);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex) { sc.Message = ex.Message; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client AddSaleDetails(SaleDetail s)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO SaleDetail (InvoiceNo, ProductID, Quantity, BuyingValue, SellingValue, Amount) VALUES (@INV, @PID, @QTY, @BVL, @SVL, @TAM)", cm);
        cmd.Parameters.AddWithValue("@INV", s.InvoiceNo);
        cmd.Parameters.AddWithValue("@PID", s.ProductID);
        cmd.Parameters.AddWithValue("@QTY", s.Quantity);
        cmd.Parameters.AddWithValue("@BVL", s.BuyingValue);
        cmd.Parameters.AddWithValue("@SVL", s.SellingValue);
        cmd.Parameters.AddWithValue("@TAM", s.Amount);
        try
        {
            cm.Open();
            sc.Count = cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            sc.Message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client GetSales()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT InvoiceNo FROM sale ORDER BY InvoiceNo", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getSalesByInvoice(string InvoiceNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT sale.SaleDate, saledetail.ID, saledetail.ProductID, saledetail.Quantity, saledetail.SellingValue, saledetail.Amount FROM saledetail INNER JOIN sale ON sale.InvoiceNo=saledetail.InvoiceNo WHERE sale.InvoiceNo='" + InvoiceNo + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client DeleteSalesByInvoice(string InvoiceNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM sale WHERE InvoiceNo='" + InvoiceNo + "'", cm);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            sc.Message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Customer GetCustomerByInvoice(string InvoiceNo)
    {
        Customer cus = new Customer();
        MySqlCommand cmd = new MySqlCommand("SELECT customer.ID, customer.CustomerName, customer.Address, customer.Phone FROM sale INNER JOIN customer ON sale.CustomerID=customer.ID WHERE sale.InvoiceNo='" + InvoiceNo + "'", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            cus.CustomerID = Convert.ToInt32(rd[0]);
            cus.CustomerName = rd[1].ToString();
            cus.Address = rd[2].ToString();
            cus.Phone = rd[3].ToString();
            cus.Email = rd[4].ToString();
        }
        catch { ; }
        finally { cm.Close(); }
        return cus;
    }

    [WebMethod]
    public Server2Client getSoldProductsByDate(DateTime dt)
    {
        string df = Settings.getDate(dt);
        
        Server2Client sc = new Server2Client();
        //MySqlCommand cmd = new MySqlCommand("SELECT Customer.CustomerName, Customer.Address, Customer.Phone, Sale.InvoiceNo, Sale.SaleDate, Product.ProductName, group_concat(Product.BarCode) BarCode, SUM(SaleDetail.Quantity) AS Quantity, SaleDetail.SellingValue AS SellingValue, SUM(SaleDetail.Quantity)*SaleDetail.SellingValue AS Amount, Sale.Discount, Sale.Payment FROM (Customer INNER JOIN Sale ON Customer.ID = Sale.CustomerID) INNER JOIN(Product INNER JOIN SaleDetail ON Product.ID = SaleDetail.ProductID) ON Sale.InvoiceNo = SaleDetail.InvoiceNo WHERE Sale.SaleDate = '" + df + "' GROUP BY product.ProductName", cm);
        MySqlCommand cmd = new MySqlCommand("SELECT Sale.InvoiceNo, Sale.SaleDate, Product.ProductName, group_concat(Product.BarCode) BarCode, SUM(SaleDetail.Quantity) AS SumOfQuantity, SaleDetail.SellingValue AS SellingValue, SUM(SaleDetail.Quantity) * SaleDetail.SellingValue AS Amount, Sale.Discount,     Sale.Payment, Sale.Balance FROM Sale INNER JOIN(Product INNER JOIN SaleDetail ON Product.ID = SaleDetail.ProductID) ON Sale.InvoiceNo = SaleDetail.InvoiceNo WHERE Sale.SaleDate = '" + df + "' GROUP BY    product.ProductName, sale.InvoiceNo", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getSoldProductsByDates(DateTime dtFR, DateTime dtTO)
    {
        string df = Settings.getDate(dtFR);
        string dt = Settings.getDate(dtTO);
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Customer.CustomerName, Customer.Address, Customer.Phone, Sale.InvoiceNo, Sale.SaleDate, Product.ProductName, group_concat(Product.BarCode) BarCode, SUM(SaleDetail.Quantity) AS Quantity, SaleDetail.SellingValue AS SellingValue, SUM(SaleDetail.Quantity)*SaleDetail.SellingValue AS Amount, Sale.Discount, Sale.Payment FROM (Customer INNER JOIN Sale ON Customer.ID = Sale.CustomerID) INNER JOIN(Product INNER JOIN SaleDetail ON Product.ID = SaleDetail.ProductID) ON Sale.InvoiceNo = SaleDetail.InvoiceNo WHERE Sale.SaleDate BETWEEN '" + df + "' AND '" + dt + "' GROUP BY product.ProductName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getSoldProductsByInvoiceNo(string InvoiceNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Customer.CustomerName, Customer.Address, Customer.Phone, Sale.InvoiceNo, Sale.SaleDate, Product.ProductName, group_concat(Product.BarCode) BarCode, SUM(SaleDetail.Quantity) AS Quantity, SaleDetail.SellingValue AS SellingValue, SUM(SaleDetail.Quantity)*SaleDetail.SellingValue AS Amount, Sale.Discount, Sale.Balance, Sale.Payment FROM (Customer INNER JOIN Sale ON Customer.ID = Sale.CustomerID) INNER JOIN(Product INNER JOIN SaleDetail ON Product.ID = SaleDetail.ProductID) ON Sale.InvoiceNo = SaleDetail.InvoiceNo WHERE Sale.InvoiceNo = '" + InvoiceNo + "' GROUP BY product.ProductName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getProfitLossByDate(DateTime dt)
    {
        string dd = Settings.getDate(dt);

        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Sale.SaleDate, SUM(Product.SellingValue*SaleDetail.Quantity) AS TotalSellingValue, SUM(Product.BuyingValue*SaleDetail.Quantity) AS TotalBuyingValue, TotalSellingValue -  TotalBuyingValue AS Profit FROM Sale INNER JOIN(Product INNER JOIN SaleDetail ON Product.ID = SaleDetail.ProductID) ON Sale.InvoiceNo = SaleDetail.InvoiceNo WHERE Sale.SaleDate=#" + dd + "# GROUP BY Sale.SaleDate", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getProfitLossByDates(DateTime dtFR, DateTime dtTO)
    {
        string df = Settings.getDate(dtFR);
        string dt = Settings.getDate(dtTO);
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Sale.SaleDate, SUM(Product.SellingValue*SaleDetail.Quantity) AS TotalSellingValue, SUM(Product.BuyingValue*SaleDetail.Quantity) AS TotalBuyingValue, TotalSellingValue -  TotalBuyingValue AS Profit FROM Sale INNER JOIN(Product INNER JOIN SaleDetail ON Product.ID = SaleDetail.ProductID) ON Sale.InvoiceNo = SaleDetail.InvoiceNo WHERE Sale.SaleDate BETWEEN #" + df + "# AND #" + dt + "# GROUP BY Sale.SaleDate", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client SalesToCustomerByID(int CustomerID)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Customer.CustomerName, Customer.Address, Customer.Phone, Sale.SaleDate, Product.ProductName, group_concat(Product.BarCode) BarCode, SaleDetail.SellingValue, Sum(SaleDetail.Quantity) AS Quantity, SaleDetail.SellingValue*SaleDetail.Quantity AS Amount FROM Product INNER JOIN((Customer INNER JOIN Sale ON Customer.ID = Sale.CustomerID) INNER JOIN SaleDetail ON Sale.InvoiceNo = SaleDetail.InvoiceNo) ON Product.ID = SaleDetail.ProductID WHERE Customer.ID=" + CustomerID + " GROUP BY Product.ProductName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client SalesToCustomerByDates(int CID, DateTime dtF, DateTime dtT)
    {
        string dtf = Settings.getDate(dtF);
        string dtt = Settings.getDate(dtT);
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Customer.CustomerName, Customer.Address, Customer.Phone, Sale.SaleDate, Product.ProductName, group_concat(Product.BarCode) BarCode, SaleDetail.SellingValue, Sum(SaleDetail.Quantity) AS Quantity, SaleDetail.SellingValue*SaleDetail.Quantity AS Amount FROM Product INNER JOIN((Customer INNER JOIN Sale ON Customer.ID = Sale.CustomerID) INNER JOIN SaleDetail ON Sale.InvoiceNo = SaleDetail.InvoiceNo) ON Product.ID = SaleDetail.ProductID WHERE Customer.ID=" + CID + " AND Sale.SaleDate BETWEEN '" + dtf + "' AND '" + dtt + "' GROUP BY Product.ProductName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

}
