using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsPurchases
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsPurchases : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    [WebMethod]
    public Server2Client addPurchase(Purchase p)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO Purchase (InvoiceNo, PurchaseDate, SupplierID, Amount, Payment, Balance) VALUES (@INV, @PDT, @SID, @TAM, @TPM, @TBL)", cm);
        cmd.Parameters.AddWithValue("@INV", p.InvoiceNo);
        cmd.Parameters.AddWithValue("@PDT", p.PurchaseDate);
        cmd.Parameters.AddWithValue("@SID", p.SupplierID);
        cmd.Parameters.AddWithValue("@TAM", p.Amount);
        cmd.Parameters.AddWithValue("@TPM", p.Payment);
        cmd.Parameters.AddWithValue("@TBL", p.Balance);
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
    public Server2Client addPurchaseDetails(PurchaseDetail p)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO PurchaseDetail (InvoiceNo, ProductCode, Quantity, BuyingValue, SellingValue, Amount) VALUES (@INV, @PID, @QTY, @BVL, @SVL, @TAM)", cm);
        cmd.Parameters.AddWithValue("@INV", p.InvoiceNo);
        cmd.Parameters.AddWithValue("@PID", p.ProductCode);
        cmd.Parameters.AddWithValue("@QTY", p.Quantity);
        cmd.Parameters.AddWithValue("@BVL", p.BuyingValue);
        cmd.Parameters.AddWithValue("@SVL", p.SellingValue);
        cmd.Parameters.AddWithValue("@TAM", p.Amount);
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
    public Server2Client getPurchasedProductsByDate(DateTime dt)
    {
        string dd = dt.Date.Year.ToString("0000") + "-" + dt.Date.Month.ToString("00") + "-" + dt.Date.Day.ToString("00");
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Purchase.PurchaseDate, Product.ProductName, GROUP_CONCAT(BarCode) BarCode, PurchaseDetail.BuyingValue, Sum(PurchaseDetail.Quantity) AS SumOfQuantity, PurchaseDetail.BuyingValue * Sum(PurchaseDetail.Quantity) AS SumOfAmount FROM Purchase INNER JOIN(Product INNER JOIN PurchaseDetail ON Product.ProductCode = PurchaseDetail.ProductCode) ON Purchase.InvoiceNo = PurchaseDetail.InvoiceNo WHERE Purchase.PurchaseDate = '" + dd + "' GROUP BY Product.ProductName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getPurchasedProductsByDates(DateTime dtFr, DateTime dtTo)
    {
        string df = dtFr.Date.Year.ToString("0000") + "-" + dtFr.Date.Month.ToString("00") + "-" + dtFr.Date.Day.ToString("00");
        string dt = dtTo.Date.Year.ToString("0000") + "-" + dtTo.Date.Month.ToString("00") + "-" + dtTo.Date.Day.ToString("00");
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Purchase.PurchaseDate, Product.ProductName, GROUP_CONCAT(BarCode) BarCode, PurchaseDetail.BuyingValue, Sum(PurchaseDetail.Quantity) AS SumOfQuantity, PurchaseDetail.BuyingValue * Sum(PurchaseDetail.Quantity) AS SumOfAmount FROM Purchase INNER JOIN(Product INNER JOIN PurchaseDetail ON Product.ProductCode = PurchaseDetail.ProductCode) ON Purchase.InvoiceNo = PurchaseDetail.InvoiceNo WHERE Purchase.PurchaseDate BETWEEN '" + df + "' AND '" + dt + "' GROUP BY Product.ProductName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getPurchasedProductsByInvoice(string InvoiceNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Purchase.PurchaseDate, Product.ProductName, GROUP_CONCAT(BarCode) BarCode, PurchaseDetail.BuyingValue, Sum(PurchaseDetail.Quantity) AS SumOfQuantity, PurchaseDetail.BuyingValue * Sum(PurchaseDetail.Quantity) AS SumOfAmount FROM Purchase INNER JOIN(Product INNER JOIN PurchaseDetail ON Product.ProductCode = PurchaseDetail.ProductCode) ON Purchase.InvoiceNo = PurchaseDetail.InvoiceNo WHERE Purchase.InvoiceNo = '" + InvoiceNo + "' GROUP BY Product.ProductName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client PurchaseFromSupplierByID(int SupplierID)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Purchase.PurchaseDate, Product.ProductName, GROUP_CONCAT(BarCode) BarCode, PurchaseDetail.BuyingValue, Sum(PurchaseDetail.Quantity) AS TotalQuantity, PurchaseDetail.BuyingValue * Sum(PurchaseDetail.Quantity) AS Amount FROM Purchase INNER JOIN(Product INNER JOIN PurchaseDetail ON Product.ProductCode = PurchaseDetail.ProductCode) ON Purchase.InvoiceNo = PurchaseDetail.InvoiceNo WHERE Purchase.SupplierID =" + SupplierID + " GROUP BY Product.ProductName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client PurchaseFromSupplierByDates(int SupplierID, DateTime dtFr, DateTime dtTo)
    {
        string df = dtFr.Date.Year.ToString("0000") + "-" + dtFr.Date.Month.ToString("00") + "-" + dtFr.Date.Day.ToString("00");
        string dt = dtTo.Date.Year.ToString("0000") + "-" + dtTo.Date.Month.ToString("00") + "-" + dtTo.Date.Day.ToString("00");
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Purchase.PurchaseDate, Product.ProductName, GROUP_CONCAT(BarCode) BarCode, PurchaseDetail.BuyingValue, Sum(PurchaseDetail.Quantity) AS TotalQuantity, PurchaseDetail.BuyingValue * Sum(PurchaseDetail.Quantity) AS Amount FROM Purchase INNER JOIN(Product INNER JOIN PurchaseDetail ON Product.ProductCode = PurchaseDetail.ProductCode) ON Purchase.InvoiceNo = PurchaseDetail.InvoiceNo WHERE Purchase.SupplierID =" + SupplierID + " AND Purchase.PurchaseDate BETWEEN '" + df + "' AND '" + dt + "' GROUP BY Product.ProductName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

}
