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
        //if (res_password.Text == conf_res_password.Text )
        //{
        //    Resat_Label1.Text = "test";
        //    Resat_Label1.Visible = true;
        //}
        
        

    }

    protected void forside_glemt_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Ress_password_Click(object sender, EventArgs e)
    {


        
        
        if (res_password.Text == conf_res_password.Text)
        {
            int affectedrows;
            SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
            SqlCommand Sqlcheckuser = new SqlCommand("Select * From Users Where Username = '" + res_Username.Text + "' and Email = '"+res_email.Text+"'", DBCon);
            Sqlcheckuser.Connection.Open();
            affectedrows = Sqlcheckuser.ExecuteNonQuery();
            Sqlcheckuser.Connection.Close();
            if (affectedrows == 1)
            {
                // updatere password i databasen
                SqlCommand Sqlupdate = new SqlCommand("UPDATE Users SET Userpwd = '" + res_password.Text + "' where Username = '" + res_Username.Text + "' and Email = '" + res_email.Text + "'", DBCon);
                Sqlupdate.Connection.Open();
                Sqlupdate.ExecuteNonQuery();
                Sqlupdate.Connection.Close();
                Sqlupdate.Connection.Dispose();

                // informere brugeren om det er lykkesed eller ej
                Resat_Label1.Text = "Brugeren " + res_Username.Text + " har fået ændret kodeord";
                Resat_Label1.Visible = true;
                res_Username.Text = "";
                res_password.Text = "";
                conf_res_password.Text = "";
                res_email.Text = "";
                Response.AddHeader("REFRESH", "2;URL=Default.aspx");
            }
            else
            {
                Resat_Label1.Visible = true;
                Resat_Label1.Text = "Brugeren fandtes ikke";
                res_Username.Text = "";
                res_email.Text = "";
                res_password.Text = "";
                conf_res_password.Text = "";
            }
        }
        else
        {
            Resat_Label1.Visible = true;
            Resat_Label1.Text = "De 2 passwords matchede ikke";
            res_password.Text = "";
            conf_res_password.Text = "";
        }

    }
}
