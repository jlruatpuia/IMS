using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wrSettings
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wrSettings : System.Web.Services.WebService
{
    static MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    public static string GetFinancialYear(DateTime dt)
    {
        string finyear = "";

        int m = dt.Month;
        int y = dt.Year;
        if (m > 3)
        {
            finyear = y.ToString().Substring(2, 2) + "-" + Convert.ToString((y + 1)).Substring(2, 2);
        }
        else
        {
            finyear = Convert.ToString((y - 1)).Substring(2, 2) + "-" + y.ToString().Substring(2, 2);
        }
        return finyear;
    }

    [WebMethod]
    public string GetInvoiceNo(DateTime dt, string Table, string ShortName)
    {
        //string inv_no = "";
        int inv_no;
        string inv_yr = "";
        MySqlCommand cmd = new MySqlCommand("SELECT SUBSTRING(InvoiceNo, 11, 5) FROM " + Table + " WHERE SUBSTRING(InvoiceNo, 8, 2) = 'RI' ORDER BY InvoiceNo DESC", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            inv_yr = rd[0].ToString();
            inv_yr = inv_yr.Substring(0, 5);
        }
        catch
        {
            inv_yr = GetFinancialYear(dt);
        }
        finally { cm.Close(); }

        string yr = inv_yr == GetFinancialYear(dt) ? inv_yr : GetFinancialYear(dt);

        cmd = new MySqlCommand("SELECT SUBSTRING(InvoiceNo, 17) FROM " + Table + " WHERE SUBSTRING(InvoiceNo, 8, 2) = 'RI' AND SUBSTRING(InvoiceNo, 11, 5)='" + yr + "' ORDER BY InvoiceNo DESC", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            string i = rd[0].ToString();
            inv_no = Convert.ToInt32(rd[0]); //.ToString();
        }
        catch
        {
            inv_no = 0;
        }
        finally { cm.Close(); }

        return ShortName + "/RI/" + yr + "/" + (inv_no + 1).ToString("0000");
    }

    [WebMethod]
    public string GetQuickInvoiceNo(DateTime dt, string ShortName)
    {
        //string inv_no = "";
        int inv_no;
        string inv_yr = "";
        MySqlCommand cmd = new MySqlCommand("SELECT SUBSTRING(InvoiceNo, 11, 5) FROM Sale WHERE SUBSTRING(InvoiceNo, 8, 2) = 'QS' ORDER BY InvoiceNo DESC", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            inv_yr = rd[0].ToString();
            inv_yr = inv_yr.Substring(0, 5);
        }
        catch
        {
            inv_yr = GetFinancialYear(dt);
        }
        finally { cm.Close(); }

        string yr = inv_yr == GetFinancialYear(dt) ? inv_yr : GetFinancialYear(dt);

        cmd = new MySqlCommand("SELECT SUBSTRING(InvoiceNo, 17) FROM Sale WHERE SUBSTRING(InvoiceNo, 8, 2) = 'QS' AND SUBSTRING(InvoiceNo, 11, 5)='" + yr + "' ORDER BY InvoiceNo DESC", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            string i = rd[0].ToString();
            inv_no = Convert.ToInt32(rd[0]); //.ToString();
        }
        catch
        {
            inv_no = 0;
        }
        finally { cm.Close(); }

        return ShortName + "/QS/" + yr + "/" + (inv_no + 1).ToString("0000");
    }

    [WebMethod]
    public string GetServiceInvoiceNo(DateTime dt, string ShortName)
    {
        //string inv_no = "";
        int inv_no;
        string inv_yr = "";
        MySqlCommand cmd = new MySqlCommand("SELECT SUBSTRING(InvoiceNo, 11, 5) FROM Sale WHERE SUBSTRING(InvoiceNo, 8, 2) = 'SV' ORDER BY InvoiceNo DESC", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            inv_yr = rd[0].ToString();
            inv_yr = inv_yr.Substring(0, 5);
        }
        catch
        {
            inv_yr = GetFinancialYear(dt);
        }
        finally { cm.Close(); }

        string yr = inv_yr == GetFinancialYear(dt) ? inv_yr : GetFinancialYear(dt);

        cmd = new MySqlCommand("SELECT SUBSTRING(InvoiceNo, 17) FROM Sale WHERE SUBSTRING(InvoiceNo, 8, 2) = 'SV' AND SUBSTRING(InvoiceNo, 11, 5)='" + yr + "' ORDER BY InvoiceNo DESC", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            string i = rd[0].ToString();
            inv_no = Convert.ToInt32(rd[0]); //.ToString();
        }
        catch
        {
            inv_no = 0;
        }
        finally { cm.Close(); }

        return ShortName + "/SV/" + yr + "/" + (inv_no + 1).ToString("0000");
    }

}
