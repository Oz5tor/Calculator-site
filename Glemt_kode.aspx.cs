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

    }

    protected void forside_glemt_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Ress_password_Click(object sender, EventArgs e)
    {
        if (res_password.Text == conf_res_password.Text)
        {
            SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
            SqlCommand Sqlupdate = new SqlCommand("UPDATE Users SET Userpwd = '" + res_password.Text + "' where Username = '" + res_Username.Text + "' and Email = '" + res_email.Text + "'", DBCon);
            Sqlupdate.Connection.Open();
            Sqlupdate.ExecuteNonQuery();
            Sqlupdate.Connection.Close();
            Sqlupdate.Connection.Dispose();

            Resat_label.Visible = true;
            Resat_label.Text = "Brugeren " + res_Username.Text + " har fået ændret sit password";
            


            res_Username.Text = "";
            res_password.Text = "";
            conf_res_password.Text = "";
            res_email.Text = "";

            System.Threading.Thread.Sleep(3500);
            Response.Redirect("Default.aspx");


        }




        else
        {
            Resat_label.Visible = true;
            Resat_label.Text = "De 2 passwords matchede ikke";
            res_password.Text = "";
            conf_res_password.Text = "";
        }

    }
}
