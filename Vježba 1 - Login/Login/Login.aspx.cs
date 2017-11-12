using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated == true)
            {
                Response.Redirect("~/PostLogin.aspx");
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username, password;

            username = ConfigurationManager.AppSettings["username"];

            password = ConfigurationManager.AppSettings["password"];

            if (this.Login1.UserName == username && this.Login1.Password == password)
            {
                e.Authenticated = true;
            }
            else e.Authenticated = false;
            
        }
    }
}