using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsProducts
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsProducts : System.Web.Services.WebService
{

    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    #region Category
    [WebMethod]
    public Server2Client GetCategories()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, CategoryName FROM Category ORDER BY CategoryName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataSet = ds;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetProductCategories()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Category.ID, Category.CategoryName, CASE SUM(Product.Quantity) WHEN null then 0 ELSE Sum(Product.Quantity) END AS NoOfProducts FROM Category LEFT JOIN Product ON Category.ID = Product.CategoryID GROUP BY Category.ID, Category.CategoryName", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataSet = ds;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Category GetCategory(int CategoryID)
    {
        Category cat = new Category();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, CategoryName FROM Category WHERE ID=" + CategoryID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            cat.CategoryID = Convert.ToInt32(rd[0]);
            cat.CategoryName = rd[1].ToString();
        }
        catch { throw; }
        finally { cm.Close(); }
        return cat;
    }

    [WebMethod]
    public Server2Client AddCategory(Category cat)
    {
        Server2Client sc = new Server2Client();
        sc.Message = null;
        MySqlCommand cmd = new MySqlCommand("INSERT INTO Category (CategoryName) VALUES (@CNM)", cm);
        cmd.Parameters.AddWithValue("@CNM", cat.CategoryName);
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
    public Server2Client UpdateCategory(Category cat)
    {
        Server2Client sc = new Server2Client();
        sc.Message = null;
        MySqlCommand cmd = new MySqlCommand("UPDATE Category SET CategoryName=@CNM WHERE ID=" + cat.CategoryID, cm);
        cmd.Parameters.AddWithValue("@CNM", cat.CategoryName);
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
    public Server2Client DeleteCategory(Category cat)
    {
        Server2Client sc = new Server2Client();
        sc.Message = null;
        MySqlCommand cmd = new MySqlCommand("DELETE FROM Category WHERE ID=" + cat.CategoryID, cm);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex) { sc.Message = ex.Message; }
        finally { cm.Close(); }
        return sc;
    }

    #endregion

    #region Products

    [WebMethod]
    public Server2Client GetProducts()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, ProductName, BuyingValue, SellingValue, SUM(Quantity) AS Quantity FROM Product GROUP BY ID, ProductName, BuyingValue, SellingValue", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetProductFull()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Product.ID, Category.CategoryName, Product.ProductName, ProductDetail.BuyingValue, ProductDetail.SellingValue, ProductDetail.Quantity, Product.BarCode, Product.ReorderLevel FROM(Category INNER JOIN Product ON Category.ID = Product.CategoryID) INNER JOIN ProductDetail ON Product.ID = ProductDetail.ProductID", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetProductsTable()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, CategoryID, ProductName, BarCode FROM Product", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetProductValues()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT CategoryName, ProductName, BuyingValue, SellingValue, SUM(Quantity) AS TotalQuantity FROM Category INNER JOIN Product ON Category.ID = Product.CategoryID GROUP BY CategoryName, ProductName, BuyingValue, SellingValue", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetProductByCategory(int CategoryID)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, ProductName, BuyingValue, SellingValue, SUM(Quantity) AS Quantity FROM Product WHERE CategoryID=" + CategoryID + " AND Quantity > 0 GROUP BY ID, ProductName, BuyingValue, SellingValue", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Product GetProductByID(int ProductID)
    {
        Product prd = new Product();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, CategoryID, ProductName, BuyingValue, SellingValue, Quantity, BarCode FROM Product WHERE ID=" + ProductID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            prd.ProductID = Convert.ToInt32(rd[0]);
            prd.CategoryID = Convert.ToInt32(rd[1]);
            prd.ProductName = rd[2].ToString();
            prd.BuyingValue = Convert.ToDouble(rd[3]);
            prd.SellingValue = Convert.ToDouble(rd[4]);
            prd.Quantity = Convert.ToInt32(rd[5]);
            prd.BarCode = rd[6].ToString();
        }
        catch (Exception ex) { throw ex; }
        finally { cm.Close(); }
        return prd;
    }

    [WebMethod]
    public Product GetProductByBarCode(string BarCode)
    {
        Product prd = new Product();
        prd.Message = null;
        MySqlCommand cmd = new MySqlCommand("SELECT ID, CategoryID, ProductName, BuyingValue, SellingValue, Quantity, BarCode FROM Product WHERE BarCode='" + BarCode + "' ORDER BY ID", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                prd.ProductID = Convert.ToInt32(rd[0]);
                prd.CategoryID = Convert.ToInt32(rd[1]);
                prd.ProductName = rd[2].ToString();
                prd.BuyingValue = Convert.ToDouble(rd[3]);
                prd.SellingValue = Convert.ToDouble(rd[4]);
                prd.Quantity = Convert.ToInt32(rd[5]);
                prd.BarCode = rd[6].ToString();
            }
        }
        catch (Exception ex) { prd.Message = ex.Message; }
        finally { cm.Close(); }
        return prd;
    }

    [WebMethod]
    public Server2Client AddProduct(Product prd)
    {
        Server2Client sc = new Server2Client();
        sc.Message = null;
        MySqlCommand cmd = new MySqlCommand("INSERT INTO Product (CategoryID, SupplierID, ProductCode, ProductName, BuyingValue, SellingValue, Quantity, BarCode) VALUES (@CID, @SID, @PCD, @PNM, @BVL, @SVL, @QTY, @BCD)", cm);
        cmd.Parameters.AddWithValue("@CID", prd.CategoryID);
        cmd.Parameters.AddWithValue("@SID", prd.SupplierID);
        cmd.Parameters.AddWithValue("@PCD", prd.ProductCode);
        cmd.Parameters.AddWithValue("@PNM", prd.ProductName);
        cmd.Parameters.AddWithValue("@BVL", prd.BuyingValue);
        cmd.Parameters.AddWithValue("@SVL", prd.SellingValue);
        cmd.Parameters.AddWithValue("@QTY", prd.Quantity);
        cmd.Parameters.AddWithValue("@BCD", prd.BarCode);
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
    public Server2Client updateProduct(Product prd)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE Product SET CategoryID=@CID, ProductName=@PNM, BuyingValue=@BVL, SellingValue=@SVL, Quantity=@QTY, BarCode=@BCD WHERE ID=" + prd.ProductID, cm);
        cmd.Parameters.AddWithValue("@CID", prd.CategoryID);
        cmd.Parameters.AddWithValue("@PNM", prd.ProductName);
        cmd.Parameters.AddWithValue("@BVL", prd.BuyingValue);
        cmd.Parameters.AddWithValue("@SVL", prd.SellingValue);
        cmd.Parameters.AddWithValue("@BVL", prd.Quantity);
        cmd.Parameters.AddWithValue("@BCD", prd.BarCode);
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
    public Server2Client deleteProduct(int ID)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM Product WHERE ID=" + ID, cm);
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
    public int GetLastInsertedID()
    {
        int i = 0;
        MySqlCommand cmd = new MySqlCommand("SELECT TOP 1 ID FROM Product ORDER BY ID DESC", cm);
        try
        {
            cm.Open();
            i = (int)cmd.ExecuteScalar();
        }
        catch { i = -1; }
        finally { cm.Close(); }
        return i;
    }

    [WebMethod]
    public Server2Client updateQuantity(int ID, int Value, string type)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE Product SET Quantity=Quantity" + type + "" + Value + " WHERE ID=" + ID, cm);

        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            sc.Message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }
    #endregion

    #region ProductDetails

    [WebMethod]
    public Server2Client ProductListByCategorySimplified()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Category.CategoryName, Product.ProductName, Product.BuyingValue, Product.SellingValue, Sum(Product.Quantity) AS SumOfQuantity FROM Category INNER JOIN Product ON Category.ID = Product.CategoryID WHERE Product.Quantity > 0 GROUP BY Category.CategoryName, Product.ProductName, Product.BuyingValue, Product.SellingValue", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dataTable = ds.Tables[0];

        return sc;
    }

    [WebMethod]
    public Server2Client ProductListByCategoryExtended()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Category.CategoryName, Product.ProductName, Product.BuyingValue, Product.SellingValue, Product.Quantity, Product.BarCode FROM Category INNER JOIN Product ON Category.ID = Product.CategoryID WHERE Product.Quantity > 0 GROUP BY Category.CategoryName, Product.ProductName, Product.BuyingValue, Product.SellingValue, Product.BarCode, Product.Quantity", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dataTable = ds.Tables[0];

        return sc;
    }

    [WebMethod]
    public Server2Client ProductListBySupplierSimple()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Supplier.SupplierName, Product.ProductName, Product.BuyingValue, Product.SellingValue, Sum(Product.Quantity) AS SumOfQuantity FROM Supplier LEFT JOIN Product ON Supplier.ID = Product.SupplierID GROUP BY Supplier.SupplierName, Product.ProductName, Product.BuyingValue, Product.SellingValue", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dataTable = ds.Tables[0];

        return sc;
    }

    [WebMethod]
    public Server2Client ProductListBySupplierExtended()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Supplier.SupplierName, Product.ProductName, Product.BuyingValue, Product.SellingValue, Quantity, Product.BarCode FROM Supplier LEFT JOIN Product ON Supplier.ID = Product.SupplierID GROUP BY Supplier.SupplierName, Product.ProductName, Product.BuyingValue, Product.SellingValue, Product.BarCode, Quantity", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dataTable = ds.Tables[0];

        return sc;
    }
    #endregion
}
