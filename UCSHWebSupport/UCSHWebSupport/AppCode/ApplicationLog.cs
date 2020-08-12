using System;
using System.Globalization;
using System.IO;

public class ApplicationLog
{
    public string GetHostNIPAdd()
    {
        string HostNIPAdd = "";

        //var host = Dns.GetHostEntry(Dns.GetHostName());
        //string ServerName = Dns.GetHostName();
        //string InterNetworkAddress = (from ip in host.AddressList where ip.AddressFamily == AddressFamily.InterNetwork select ip.ToString()).FirstOrDefault();

        //HostNIPAdd = InterNetworkAddress + "[" + ServerName + "]";

        return HostNIPAdd;
    }

    public void WriteLog(string eMessage)
    {
        try
        {
            if (!string.IsNullOrEmpty(eMessage))
            {
                string AppPath = System.Configuration.ConfigurationManager.AppSettings.Get("AppPath");
                string TempYear = DateTime.Now.Year.ToString();
                string Tempmonth = DateTime.Now.Month.ToString();
                string TempDay = DateTime.Now.Day.ToString();

                if (Tempmonth.Length == 1) Tempmonth = "0" + Tempmonth;
                if (TempDay.Length == 1) TempDay = "0" + TempDay;
                if (!Directory.Exists("~/LogFile/"))
                {
                    Directory.CreateDirectory("~/LogFile");
                }

                StreamWriter y; string revdate = DateTime.Now.ToLongDateString();
                y = System.IO.File.AppendText("~\\LogFile\\L" + TempYear + Tempmonth + TempDay + ".log");
                y.WriteLine("[" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToString("HH",
                    CultureInfo.InvariantCulture) + ":" + DateTime.Now.ToString("mm", CultureInfo.InvariantCulture) +
                    ":" + DateTime.Now.ToString("ss", CultureInfo.InvariantCulture) + "] " + " Message: " + eMessage + Environment.NewLine);
                y.Close();
            }
        }
        catch (Exception ex)
        {

        }
    }

    public void WriteErrorLog(string eMessage, string ErrorModule, string OrgData)
    {
        try
        {
            if (!string.IsNullOrEmpty(eMessage))
            {
                string AppPath = System.Configuration.ConfigurationManager.AppSettings.Get("AppPath");
                string TempYear = DateTime.Now.Year.ToString();
                string Tempmonth = DateTime.Now.Month.ToString();
                string TempDay = DateTime.Now.Day.ToString();

                if (Tempmonth.Length == 1) Tempmonth = "0" + Tempmonth;
                if (TempDay.Length == 1) TempDay = "0" + TempDay;
                if (!Directory.Exists("~/LogFile/"))
                {
                    Directory.CreateDirectory("~/LogFile");
                }
                System.IO.StreamWriter y; string revdate = DateTime.Now.ToLongDateString();
                y = System.IO.File.AppendText("~\\LogFile\\E" + TempYear + Tempmonth + TempDay + ".log");
                y.WriteLine("[" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToString("HH",
                    CultureInfo.InvariantCulture) + ":" + DateTime.Now.ToString("mm", CultureInfo.InvariantCulture) +
                    ":" + DateTime.Now.ToString("ss", CultureInfo.InvariantCulture) + "] " + "[" + ErrorModule + "]" + " Message: " + eMessage + Environment.NewLine + OrgData);
                y.Close();
            }
        }
        catch (Exception ex)
        {

        }
    }
}
