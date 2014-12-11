using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] != null && Session["Login_User"].ToString() == "Calc")
        {
            Calc_Label.Text = "Hej " + Session["Login"].ToString() + ". Du er logget på Calc siden.";
        }
        else
        {
            Response.Redirect("Default.aspx");
        }

    }
    protected void logoff_calc_Click(object sender, EventArgs e)
    {
        Session["Login"] = "";
        Session["Login_user"] = "";
        Response.Redirect("Default.aspx");
    }
}