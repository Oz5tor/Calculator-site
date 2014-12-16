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
        //int affected = 0;
        SqlCommand SQLCheck = new SqlCommand("select * from Users where Username = '"+new_username.Text+"' or Email = '"+new_email.Text+"'", DBCon);
        SQLCheck.Connection.Open();
        SqlDataReader Reader = SQLCheck.ExecuteReader();

        if (Reader.Read())
        {
            new_username.Text = "";
            new_password.Text = "";
            conf_new_password.Text = "";
            new_email.Text = "";
            new_address.Text = "";
            label_brugerfindes.Visible = true;
            label_brugerfindes.Text = "Brugernavnet eller Email findes allerede!";
            SQLCheck.Connection.Close();
            SQLCheck.Connection.Dispose();
        }


        else
        {
            SQLCheck.Connection.Close();
            SQLCheck.Connection.Dispose();
            SqlConnection DBCon1 = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
            SqlCommand SQLCmd = new SqlCommand("Insert into Users values ('" + new_username.Text + "','" + new_password.Text + "','" + new_address.Text + "','" + new_email.Text + "','" + Usertype_drop.Text + "');", DBCon1);
            SQLCmd.Connection.Open();
            SQLCmd.ExecuteNonQuery();
            SQLCmd.Connection.Close();
            SQLCmd.Connection.Dispose();
            label_brugeropret.Visible = true;
            label_brugeropret.Text = "Brugeren " +new_username.Text+ " er oprettet.";
            new_username.Text = "";
            new_password.Text = "";
            conf_new_password.Text = "";
            new_email.Text = "";
            new_address.Text = "";

        }
      

    }

    
}    
