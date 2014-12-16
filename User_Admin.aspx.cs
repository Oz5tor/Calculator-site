using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Login"] != null && Session["Login_User"].ToString() == "Admin")
        {
            Admin_Label.Text = "Hej " + Session["Login"].ToString() + ". Du er logget på Admin siden.";
            SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
            SqlCommand SQLCmd = new SqlCommand("select Username from Users", DBCon);
            SQLCmd.Connection.Open();
            SqlDataReader Reader = SQLCmd.ExecuteReader();

            while (Reader.Read())
            {
                Dropdown_dropdelete.Items.Add(Reader["Username"].ToString());
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
        

        
    }
    protected void logoff_admin_Click(object sender, EventArgs e)
    {
        Session["Login"] = "";
        Session["Login_user"] = "";
        Response.Redirect("Default.aspx");
    }
    protected void delete_user_Click(object sender, EventArgs e)
    {
        SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
        SqlCommand SQLCmd = new SqlCommand("DELETE FROM Users WHERE Username = '"+ Dropdown_dropdelete.Text + "'", DBCon);
        SQLCmd.Connection.Open();
        SQLCmd.ExecuteNonQuery();
        SQLCmd.Connection.Close();
        SQLCmd.Connection.Dispose();
        Response.Redirect("User_Admin.aspx");

    }
}