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
        //Dette ville autogenere brugertyperne - vi har valgt statisk i User_new.aspx
        //SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
        //SqlCommand SQLCmd = new SqlCommand("select Usertype from Users", DBCon);
        //SQLCmd.Connection.Open();
        //SqlDataReader Reader = SQLCmd.ExecuteReader();

        //while (Reader.Read())
        //{
        //    Usertype_drop.Items.Add(Reader["Usertype"].ToString());
        //}
    }


    protected void cancel_newuser_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }


    protected void create_user_Click(object sender, EventArgs e)
    {
        SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");

        SqlCommand SQLCmd = new SqlCommand("Insert into Users values ('"+new_username.Text+"','"+new_password.Text+"','"+new_address.Text+"','"+new_email.Text+"','"+Usertype_drop.Text+"');", DBCon);
        SQLCmd.Connection.Open();
        SQLCmd.ExecuteNonQuery();
        SQLCmd.Connection.Close();
        SQLCmd.Connection.Dispose();

        //Denne side redirecte til Admin
        if (Usertype_drop.Text == "Admin")
        {
            Response.Redirect("User_Admin.aspx");
        }
        //Denne side redirecte til Sub
        if (Usertype_drop.Text == "Sub")
        {
            Response.Redirect("User_Sub.aspx");
        }
        //Denne side redirecte til Calc
        if (Usertype_drop.Text == "Calc");
        {
            Response.Redirect("User_Calc.aspx");
        }
        //Denne side redirecte til Subcalc
        if (Usertype_drop.Text == "SubCalc");
        {
            Response.Redirect("User_SubCalc.aspx");
        }

        
      

    }

    
}    
