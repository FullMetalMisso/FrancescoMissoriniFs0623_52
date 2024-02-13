using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pomeridiano
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("USER_LOGIN");
            myCookie.Values["username"] = TxtUsername.Text;
            myCookie.Values["password"] = TxtPassword.Text;
            myCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(myCookie);
            Response.Redirect("WebForm1.aspx");
        }
    }
}