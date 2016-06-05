using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsCustomers
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsCustomers : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    Server2Client sc;
    Customer cus;

    #region Customers
    [WebMethod]
    public Server2Client getCustomers()
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, CustomerName, Address, Phone, Email FROM Customer WHERE CustomerName NOT LIKE 'DefaultCustomer%'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataTable = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client getCustomersFull()
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Customer.ID, Customer.CustomerName, Customer.Address, Customer.Phone, Customer.Email, SUM(CustomerAccount.Debit) - SUM(CustomerAccount.Credit) AS Balance FROM Customer LEFT OUTER JOIN CustomerAccount ON Customer.ID=CustomerAccount.CustomerID WHERE Customer.CustomerName NOT LIKE 'DefaultCustomer%' GROUP BY Customer.ID, Customer.CustomerName, Customer.Address, Customer.Phone, Customer.Email", cm);
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(ID) FROM Customer", cm);
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
    public Customer getCustomer(int ID)
    {
        cus = new Customer();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, CustomerName, Address, Phone, Email FROM Customer WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            cus.CustomerID = ID;
            cus.CustomerName = rd[1].ToString();
            cus.Address = rd[2].ToString();
            cus.Phone = rd[3].ToString();
            cus.Email = rd[4].ToString();
            //cus.Balance = Convert.ToDouble(rd[5]);
        }
        catch
        {
            ;
        }
        finally { cm.Close(); }
        return cus;
    }

    [WebMethod]
    public Server2Client addCustomer(Customer cus)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO Customer (CustomerName, Address, Phone, Email) VALUES (@CNM, @ADR, @PHN, @EML)", cm);
        cmd.Parameters.AddWithValue("@CNM", cus.CustomerName);
        cmd.Parameters.AddWithValue("@ADR", cus.Address);
        cmd.Parameters.AddWithValue("@PHN", cus.Phone);
        cmd.Parameters.AddWithValue("@EML", cus.Email);
        //cmd.Parameters.AddWithValue("@BAL", cus.Balance);
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
    public Server2Client updateCustomer(Customer cus)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE Customer SET CustomerName=@CNM, Address=@ADR, Phone=@PHN, Email=@EML WHERE ID=" + cus.CustomerID, cm);
        cmd.Parameters.AddWithValue("@CNM", cus.CustomerName);
        cmd.Parameters.AddWithValue("@ADR", cus.Address);
        cmd.Parameters.AddWithValue("@PHN", cus.Phone);
        cmd.Parameters.AddWithValue("@EML", cus.Email);
        //cmd.Parameters.AddWithValue("@BAL", cus.Balance);
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
    public Server2Client deleteCustomer(int ID)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM Customer WHERE ID=" + ID, cm);
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
    public Server2Client Customer_Account()
    {
        sc = new Server2Client();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds = new DataSet();
        cmd = new MySqlCommand("SELECT ID, CustomerName, Address, Phone, Email FROM Customer WHERE CustomerName NOT LIKE 'DefaultCustomer%'", cm);
        da = new MySqlDataAdapter(cmd);
        da.Fill(ds, "Customer");

        cmd = new MySqlCommand("SELECT ID, CustomerID, TransDate, Description, Debit, Credit, Balance FROM CustomerAccount", cm);
        da = new MySqlDataAdapter(cmd);
        da.Fill(ds, "CustomerAccount");
        DataColumn pk = ds.Tables[0].Columns[0];
        DataColumn fk = ds.Tables[1].Columns[1];
        sc.Message = "pk_fk";
        ds.Relations.Add(sc.Message, pk, fk);
        sc.Count = ds.Tables[0].Rows.Count;
        sc.dataSet = ds;
        return sc;
    }

    [WebMethod]
    public Server2Client CreateDefaultCustomer()
    {
        sc = new Server2Client();
        int id = GetDefaultCustomer();
        string query1 = "INSERT INTO Customer (CustomerName, Address, Phone, Email) VALUES (@CNM, @ADR, @PHN, @EML)";
        //string query2 = "SELECT @@Identity";

        using (MySqlCommand cmd = new MySqlCommand(query1, cm))
        {
            cmd.Parameters.AddWithValue("@CNM", "DefaultCustomer" + id.ToString("0000000000"));
            cmd.Parameters.AddWithValue("@ADR", "Skynet Computers");
            cmd.Parameters.AddWithValue("@PHN", "0000000000");
            cmd.Parameters.AddWithValue("@EML", "customer@skynetcomputers.com");
            cm.Open();
            cmd.ExecuteNonQuery();
            //cmd.CommandText = query2;
            //sc.Count = (int)cmd.ExecuteScalar();
            sc.Count = (int)cmd.LastInsertedId;
        }
        return sc;
    }

    [WebMethod]
    private int GetDefaultCustomer()
    {
        int id = 0;
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(MID(CustomerName, 16)) FROM Customer WHERE CustomerName LIKE 'DefaultCustomer%' ORDER BY ID DESC", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                id = Convert.ToInt32(rd[0]);
            }
            else
            {
                id = 0;
            }
        }
        catch { id = 0; }
        finally { cm.Close(); }
        return id + 1;
    }
    #endregion

    #region CustomerAccounts

    [WebMethod]
    public Server2Client addTrans(CustomerAccount ca)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO CustomerAccount (CustomerID, TransDate, Description, Debit, Credit, Balance) VALUES (@CID, @TDT, @DSC, @CDR, @CCR, @BAL)", cm);
        cmd.Parameters.AddWithValue("@CID", ca.CustomerID);
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
    public Server2Client getCustomerBalanceByID(int CustomerID)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT SUM(Debit) - SUM(Credit) FROM CustomerAccount WHERE CustomerID=" + CustomerID, cm);
        try
        {
            cm.Open();
            sc.Value = Convert.ToDouble(cmd.ExecuteScalar());
        }
        catch
        {
            sc.Value = 0;
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client getCustomerBalanceByDates(int CustomerID, DateTime dtFr, DateTime dtTo)
    {
        Server2Client sc = new Server2Client();
        string df = dtFr.Date.Year.ToString("0000") + "-" + dtFr.Date.Month.ToString("00") + "-" + dtFr.Date.Day.ToString("00");
        string dt = dtTo.Date.Year.ToString("0000") + "-" + dtTo.Date.Month.ToString("00") + "-" + dtTo.Date.Day.ToString("00");
        MySqlCommand cmd;
        cmd = new MySqlCommand("SELECT Sum(Debit)-Sum(Credit) AS OpeningBalance FROM CustomerAccount WHERE CustomerID=" + CustomerID + " AND TransDate < '" + df + "'", cm);
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

        cmd = new MySqlCommand("SELECT SUM(Debit) - SUM(Credit) FROM CustomerAccount WHERE CustomerID=" + CustomerID + " AND TransDate BETWEEN '" + df + "' AND '" + dt + "'", cm);
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
    public Server2Client getTransactionDetails(int CustomerID)
    {
        sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT Customer.CustomerName, Customer.Address, Customer.Phone, Customer.Email, CustomerAccount.TransDate, CustomerAccount.Description, CASE WHEN CustomerAccount.Debit = 0 THEN Null ELSE CustomerAccount.Debit END AS Debit, CASE WHEN CustomerAccount.Credit = 0 THEN Null ELSE CustomerAccount.Credit END AS Credit, CustomerAccount.Balance FROM Customer INNER JOIN CustomerAccount ON Customer.ID = CustomerAccount.CustomerID WHERE CustomerID=" + CustomerID, cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dataTable = ds.Tables[0];
        sc.Count = ds.Tables[0].Rows.Count;
        return sc;
    }

    [WebMethod]
    public Server2Client OpeningBalance(int CustomerID, DateTime dt)
    {
        sc = new Server2Client();
        string d = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT Sum(Debit)-Sum(Credit) AS OpeningBalance FROM CustomerAccount WHERE CustomerID=" + CustomerID + " AND TransDate < '" + d + "'", cm);
        
        try
        {
            cm.Open();
            sc.Value = Convert.ToDouble(cmd.ExecuteScalar());
        }
        catch { sc.Value = 0; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client AccountStatement(int CustomerID, DateTime dtFr, DateTime dtTo)
    {
        sc = new Server2Client();

        DataTable dt = new DataTable();
        dt.Columns.Add("TransDate", typeof(DateTime));
        dt.Columns.Add("Description", typeof(string));
        dt.Columns.Add("Debit", typeof(double));
        dt.Columns.Add("Credit", typeof(double));
        dt.Columns.Add("Balance", typeof(double));
        //string dtf = dtFr.Date.Year.ToString("0000") + "-" + dtFr.Date.Month.ToString("00") + "-" + dtFr.Date.Day.ToString("00");
        //string dtt = dtTo.Date.Year.ToString("0000") + "-" + dtTo.Date.Month.ToString("00") + "-" + dtTo.Date.Day.ToString("00");
        string dtf = Settings.getDate(dtFr);
        string dtt = Settings.getDate(dtTo);

        MySqlCommand cmd = new MySqlCommand("SELECT Sum(Debit)-Sum(Credit) AS OpeningBalance FROM CustomerAccount WHERE CustomerID=" + CustomerID + " AND TransDate < '" + dtf + "'", cm);
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

        

        cmd = new MySqlCommand("SELECT TransDate, Description, CASE WHEN Debit=0 THEN NULL ELSE Debit END AS Dr, CASE WHEN Credit=0 THEN NULL ELSE Credit END AS Cr, Balance FROM CustomerAccount WHERE CustomerID=" + CustomerID + " AND CustomerAccount.TransDate BETWEEN '" + dtf + "' AND '" + dtt + "'", cm);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
        {
            DateTime dd = DateTime.Parse(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            string desc = ds.Tables[0].Rows[i].ItemArray[1].ToString();
            double debit, credit, balance;
            try { debit = Convert.ToDouble(ds.Tables[0].Rows[i].ItemArray[2]); }
            catch { debit = 0; }
            try { credit = Convert.ToDouble(ds.Tables[0].Rows[i].ItemArray[3]); }
            catch { credit = 0; }
            try { balance = Convert.ToDouble(ds.Tables[0].Rows[i].ItemArray[4]); }
            catch { balance = 0; }
            dt.Rows.Add(dd, desc, debit, credit, balance);
        }
        dt.TableName = "AccountStateMent";
        sc.dataTable = dt;
        sc.Count = dt.Rows.Count;
        return sc;
    }
    #endregion
}
