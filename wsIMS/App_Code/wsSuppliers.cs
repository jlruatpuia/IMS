using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsSuppliers
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsSuppliers : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    Server2Client sc;
    Supplier sup;

    #region Suppliers
    [WebMethod]
    public Server2Client getSuppliers()
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, SupplierName, Address, Phone, Email FROM Supplier", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getSuppliersFull()
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Supplier.ID, Supplier.SupplierName, Supplier.Address, Supplier.Phone, Supplier.Email, SUM(SupplierAccount.Debit) - SUM(SupplierAccount.Credit) AS Balance FROM Supplier LEFT OUTER JOIN SupplierAccount ON Supplier.ID=SupplierAccount.SupplierID GROUP BY Supplier.ID, Supplier.SupplierName, Supplier.Address, Supplier.Phone, Supplier.Email", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getMaxID()
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(ID) FROM Supplier", cm);
        try
        {
            cm.Open();
            sc.Count = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch (Exception ex)
        {
            sc.Message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Supplier getSupplier(int ID)
    {
        sup = new Supplier();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, SupplierName, Address, Phone, Email FROM Supplier WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            sup.SupplierName = rd[1].ToString();
            sup.Address = rd[2].ToString();
            sup.Phone = rd[3].ToString();
            sup.Email = rd[4].ToString();
            //sup.Balance = Convert.ToDouble(rd[5]);
        }
        catch
        {
            ;
        }
        finally { cm.Close(); }
        return sup;
    }

    [WebMethod]
    public Server2Client addSupplier(Supplier sup)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO Supplier (SupplierName, Address, Phone, Email) VALUES (@SNM, @ADR, @PHN, @EML)", cm);
        cmd.Parameters.AddWithValue("@SNM", sup.SupplierName);
        cmd.Parameters.AddWithValue("@ADR", sup.Address);
        cmd.Parameters.AddWithValue("@PHN", sup.Phone);
        cmd.Parameters.AddWithValue("@EML", sup.Email);
        //cmd.Parameters.AddWithValue("@BAL", sup.Balance);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
            sc.Count = Convert.ToInt32(cmd.LastInsertedId);
        }
        catch (Exception ex)
        {
            sc.Message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client updateSupplier(Supplier sup)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE Supplier SET SupplierName=@SNM, Address=@ADR, Phone=@PHN, Email=@EML WHERE ID=" + sup.SupplierID, cm);
        cmd.Parameters.AddWithValue("@SNM", sup.SupplierName);
        cmd.Parameters.AddWithValue("@ADR", sup.Address);
        cmd.Parameters.AddWithValue("@PHN", sup.Phone);
        cmd.Parameters.AddWithValue("@EML", sup.Email);
        //cmd.Parameters.AddWithValue("@BAL", sup.Balance);
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

    [WebMethod]
    public Server2Client deleteSupplier(int ID)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM Supplier WHERE ID=" + ID, cm);
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

    [WebMethod]
    public Server2Client Supplier_Account()
    {
        sc = new Server2Client();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds = new DataSet();
        cmd = new MySqlCommand("SELECT ID, SupplierName, Address, Phone, Email FROM Supplier", cm);
        da = new MySqlDataAdapter(cmd);
        da.Fill(ds, "Supplier");

        cmd = new MySqlCommand("SELECT ID, SupplierID, TransDate, Description, Debit, Credit, Balance FROM SupplierAccount", cm);
        da = new MySqlDataAdapter(cmd);
        da.Fill(ds, "SupplierAccount");
        DataColumn pk = ds.Tables[0].Columns[0];
        DataColumn fk = ds.Tables[1].Columns[1];
        sc.Message = "pk_fk";
        ds.Relations.Add(sc.Message, pk, fk);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataSet = ds;
        return sc;
    }
    #endregion

    #region SupplierAccount
    [WebMethod]
    public Server2Client addTrans(SupplierAccount ca)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO SupplierAccount (SupplierID, TransDate, Description, Debit, Credit, Balance) VALUES (@CID, @TDT, @DSC, @CDR, @CCR, @BAL)", cm);
        cmd.Parameters.AddWithValue("@CID", ca.SupplierID);
        cmd.Parameters.AddWithValue("@TDT", ca.TransDate);
        cmd.Parameters.AddWithValue("@DSC", ca.Description);
        cmd.Parameters.AddWithValue("@CDR", ca.Debit);
        cmd.Parameters.AddWithValue("@CCR", ca.Credit);
        cmd.Parameters.AddWithValue("@BAL", ca.Balance);
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

    [WebMethod]
    public Server2Client getSupplierBalanceByID(int SupplierID)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT SUM(Debit) - SUM(Credit) FROM SupplierAccount WHERE SupplierID=" + SupplierID, cm);
        try
        {
            cm.Open();
            sc.Value = Convert.ToDouble(cmd.ExecuteScalar());
        }
        catch
        {
            sc.Message = "0";
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client getSupplierOpeningBalance(int SupplierID)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Balance FROM SupplierAccount WHERE Description='Opening Balance' AND SupplierID=" + SupplierID, cm);
        try
        {
            cm.Open();
            sc.Value = Convert.ToDouble(cmd.ExecuteScalar());
        }
        catch
        {
            sc.Message = "0";
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client getSupplierBalanceByDates(int SupplierID, DateTime dtFr, DateTime dtTo)
    {
        Server2Client sc = new Server2Client();
        string df = dtFr.Date.Month.ToString("00") + "/" + dtFr.Date.Day.ToString("00") + "/" + dtFr.Date.Year.ToString();
        string dt = dtTo.Date.Month.ToString("00") + "/" + dtTo.Date.Day.ToString("00") + "/" + dtTo.Date.Year.ToString();
        MySqlCommand cmd;
        cmd = new MySqlCommand("SELECT Sum(Debit)-Sum(Credit) AS OpeningBalance FROM SupplierAccount WHERE SupplierID=" + SupplierID + " AND TransDate < #" + df + "#", cm);
        double OpeningBalance = 0;
        try
        {
            cm.Open();
            OpeningBalance = Convert.ToDouble(cmd.ExecuteScalar());
        }
        catch
        {
            OpeningBalance = 0;
        }
        finally
        {
            cm.Close();
        }

        cmd = new MySqlCommand("SELECT SUM(Debit) - SUM(Credit) FROM SupplierAccount WHERE SupplierID=" + SupplierID + " AND TransDate BETWEEN #" + df + "# AND #" + dt + "#", cm);
        try
        {
            cm.Open();
            sc.Value = Convert.ToDouble(cmd.ExecuteScalar());
            sc.Value = sc.Value + OpeningBalance;
        }
        catch (Exception ex)
        {
            sc.Message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client getTransactionDetails(int SupplierID)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Supplier.SupplierName, Supplier.Address, Supplier.Phone, Supplier.Email, SupplierAccount.TransDate, SupplierAccount.Description, CASE WHEN SupplierAccount.Debit = 0 THEN Null ELSE SupplierAccount.Debit END AS Debit, CASE WHEN SupplierAccount.Credit = 0 THEN Null ELSE SupplierAccount.Credit END AS Credit, SupplierAccount.Balance FROM Supplier INNER JOIN SupplierAccount ON Supplier.ID = SupplierAccount.SupplierID WHERE SupplierID=" + SupplierID, cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dataTable = ds.Tables[0];
        sc.Count = ds.Tables[0].Rows.Count;
        return sc;
    }

    [WebMethod]
    public Server2Client AccountStatement(int SupplierID, DateTime dtFr, DateTime dtTo)
    {
        sc = new Server2Client();

        DataTable dt = new DataTable();
        dt.Columns.Add("TransDate", typeof(DateTime));
        dt.Columns.Add("Description", typeof(string));
        dt.Columns.Add("Debit", typeof(double));
        dt.Columns.Add("Credit", typeof(double));
        dt.Columns.Add("Balance", typeof(double));
        string dtf = dtFr.Date.Month.ToString("00") + "/" + dtFr.Date.Day.ToString("00") + "/" + dtFr.Date.Year.ToString();
        string dtt = dtTo.Date.Month.ToString("00") + "/" + dtTo.Date.Day.ToString("00") + "/" + dtTo.Date.Year.ToString();
        MySqlCommand cmd = new MySqlCommand("SELECT Sum(Debit)-Sum(Credit) AS OpeningBalance FROM SupplierAccount WHERE SupplierID=" + SupplierID + " AND TransDate < '" + dtf + "'", cm);
        double OpeningBalance = 0;
        try
        {
            cm.Open();
            OpeningBalance = Convert.ToDouble(cmd.ExecuteScalar());
        }
        catch
        {
            OpeningBalance = 0;
        }
        finally
        {
            cm.Close();
        }

        dt.Rows.Add(dtFr, "Opening Balance", OpeningBalance, 0, OpeningBalance);

        cmd = new MySqlCommand("SELECT TransDate, Description, CASE WHEN Debit=0 THEN NULL ELSE Debit END AS Dr,  CASE WHEN Credit=0 THEN NULL ELSE Credit END AS Cr, Balance FROM SupplierAccount WHERE SupplierID=" + SupplierID + " AND SupplierAccount.TransDate BETWEEN '" + dtf + "' AND '" + dtt + "'", cm);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
        {
            DateTime dd = DateTime.Parse(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            string desc = ds.Tables[0].Rows[i].ItemArray[1].ToString();
            double debit, credit, balance;
            try
            {
                debit = Convert.ToDouble(ds.Tables[0].Rows[i].ItemArray[2]);
            }
            catch { debit = 0; }
            try
            {
                credit = Convert.ToDouble(ds.Tables[0].Rows[i].ItemArray[3]);
            }
            catch { credit = 0; }
            try
            {
                balance = Convert.ToDouble(ds.Tables[0].Rows[i].ItemArray[4]);
            }
            catch { balance = 0; }
            dt.Rows.Add(dd, desc, debit, credit, balance);
        }
        dt.TableName = "AccountStatement";
        sc.dataTable = dt;
        sc.Count = dt.Rows.Count;
        return sc;
    } 
    #endregion
}
