using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    LoginFac objUser = new LoginFac();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        LoginFac objUser = new LoginFac();
        DataTable dt;

        objUser._username = txtUsername.Text;
        objUser._password = objUser.GetSH1(txtPassword.Text);
        dt = objUser.Login();

        if (dt.Rows.Count == 1)
        {
            Session["User"] = dt.Rows[0]["fldID"].ToString();
            Session["Rolle"] = dt.Rows[0]["fldRolleID"].ToString();

            if (Convert.ToInt32(Session["Rolle"]) == 1 || Convert.ToInt32(Session["Rolle"]) == 2)
            {
                if (String.IsNullOrEmpty(Request.QueryString["returnurl"]))
                {
                    Response.Redirect("Admin/DefaultAdmin.aspx");
                }
                else
                {
                    Response.Redirect(Request.QueryString["returnurl"]);
                }
            }
            if (Convert.ToInt32(Session["Rolle"]) == 3)
            {
                Response.Redirect("Bruger.aspx");
            }
        }
        else
        {
            litError.Text = "<h4>Ukendt bruger og/eller password</h4>";
        }

    }
}