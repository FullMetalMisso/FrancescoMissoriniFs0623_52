using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pomeridiano
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["USER_LOGIN"] != null)
            {
                LblShow.Text = $"{Request.Cookies["USER_LOGIN"]["username"]}, {Request.Cookies["USER_LOGIN"]["password"]}";
            }
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["USER_LOGIN"] != null)
            {
                HttpCookie myCookie = new HttpCookie("USER_LOGIN");
                myCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(myCookie);
                Response.Redirect("Login.aspx");
            }
        }
    }
}