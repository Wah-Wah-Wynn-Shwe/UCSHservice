using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.Configuration;

namespace UCSHWebSupport
{
    public partial class Login : System.Web.UI.Page
    {
        UCSHService.UCSHServiceClient usc = new UCSHService.UCSHServiceClient();
        SystemLogic sl = new SystemLogic();
        ApplicationLog al = new ApplicationLog();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie uLoginIP = new HttpCookie("uLoginIP");
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                string IPAddress = (from ip in host.AddressList where ip.AddressFamily == AddressFamily.InterNetwork select ip.ToString()).FirstOrDefault();
                uLoginIP["IPAddress"] = IPAddress;
                Response.Cookies.Add(uLoginIP);
                txtUserID.Focus();
                if (!String.IsNullOrEmpty(Request.QueryString["Logout"]) && Request.QueryString["Logout"].ToString() == "True")
                {
                    HttpCookie veCook = Request.Cookies["uLoginInfo"];
                    if (veCook != null)
                    {
                        veCook.Expires = DateTime.Now.AddHours(-2);
                        Response.Cookies.Add(veCook);
                        Response.Redirect("Default.aspx", false);
                    }
                }
                HttpCookie uLogincook = Request.Cookies["uLoginInfo"];
                if (uLogincook != null)
                {
                    Response.Redirect("Default.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Please contact administrator for assistant.')</script>");
                al.WriteErrorLog(ex.Message, "Login FormLoad", "");

            }
            txtUserID.Focus();
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie uLoginIP = Request.Cookies["uLoginIP"];
            String iuser = txtUserID.Text.Replace(" ", "").ToUpper();
            String ipass = txtPassword.Text;
            HttpCookie uLogincook = new HttpCookie("uLoginInfo");

            try
            {
                //EncryptingappSettings();
                if (isCompleteLogin() && uLoginIP != null)
                {

                    uLogincook["ACode"] = System.Configuration.ConfigurationManager.AppSettings.Get("AuthenticationCode");

                    string hpassword = sl.SHA256Hasing(ipass);
                    DataTable iResult = SystemLogic.CollectionHelper.ConvertTo(usc.GetStudent(uLoginIP["IPAddress"], System.Configuration.ConfigurationManager.AppSettings.Get("AuthenticationCode"), "", iuser, hpassword, "", "","", "", "","", "true"));
                    if (iResult != null && iResult.Rows.Count == 1)
                    {
                        uLogincook["Name"] = iResult.Rows[0]["FullName"].ToString();
                        uLogincook["ID"] = iResult.Rows[0]["ID"].ToString();
                        uLogincook["LoginID"] = iResult.Rows[0]["LoginID"].ToString();

                        Response.Cookies.Add(uLogincook);
                        Response.Redirect("Default.aspx", false);
                    }
                    else
                    {
                        Response.Write("<script LANGUAGE='JavaScript' >alert('Incorrect User Information!')</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Please contact administrator for assistant.')</script>");
                if (uLogincook != null && uLoginIP != null)
                {
                    al.WriteErrorLog(ex.Message, "Login Click", "IP Address=" + uLoginIP["IPAddress"] + ",LoginID=" + iuser + ",Password(Before Encrypt)=+" + ipass);
                }
            }
        }
        private void EncryptingappSettings()
        {
            try
            {
                Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
                ConfigurationSection configStrings = config.GetSection("appSettings");


                if (configStrings != null && configStrings.SectionInformation.IsProtected == false)
                {
                    configStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    configStrings.SectionInformation.ForceSave = true;
                    config.Save(ConfigurationSaveMode.Full);
                }
            }
            catch (Exception ex)
            {
               
            }
        }
        protected bool isCompleteLogin()
        {
            if (String.IsNullOrEmpty(txtUserID.Text))
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('User ID Required!')</script>");
                txtUserID.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Password Required!')</script>");
                txtPassword.Focus();
                return false;
            }
            else return true;
        }
    }
}