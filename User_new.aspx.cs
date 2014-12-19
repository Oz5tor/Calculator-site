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


    protected void cancel_newuser_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }


    protected void create_user_Click(object sender, EventArgs e)
    {
        //Her tjekkes der for om brugeren(brugernavn/email) findes i forvejen.
        SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
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
            //Grunden dette står to steder - er fordi at connection skal lukkes - og hvis koden går udenom om IF sætningen så er den stadig åben.
            SQLCheck.Connection.Close();
            SQLCheck.Connection.Dispose();
            //Her oprettes du som bruger
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
