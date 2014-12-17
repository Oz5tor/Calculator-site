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
            SQLCmd.Connection.Close();
            SQLCmd.Connection.Dispose();
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
    protected void update_user_Click(object sender, EventArgs e)
    {
        
        
        SqlConnection DBCon1 = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
        SqlCommand SQLCmd = new SqlCommand("UPDATE Users SET Username = '" + Edit_username.Text.ToString() + "',  Userpwd = '" + Edit_pwd.Text.ToString() + "', Adresse = '" + Edit_adress.Text.ToString() + "', Email = '" + Edit_email.Text.ToString() + "', Usertype = '" + Edit_usertype.Text.ToString() + "' where UserID = '" + user_id.Text + "'", DBCon1);
        SQLCmd.Connection.Open();
        SQLCmd.ExecuteNonQuery();
        SQLCmd.Connection.Close();
        SQLCmd.Connection.Dispose();
        

    }
    protected void select_user_Click(object sender, EventArgs e)
    {
        SqlConnection DBCon2 = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
        SqlCommand SQLCmd = new SqlCommand("select * from Users where Username = '" + Dropdown_dropdelete.Text+ "'", DBCon2);
        SQLCmd.Connection.Open();
        SqlDataReader Reader = SQLCmd.ExecuteReader();
        
        // labels to visivle
        Brugernavn.Visible  = true;
        Email.Visible       = true;
        Kodeord.Visible     = true;
        Addresse.Visible    = true;
        Brugertype.Visible  = true;
        user_id_lable.Visible = true;
        // select user dropdown hidden
        Dropdown_dropdelete.Visible = false;
        select_user.Visible = false;
        Tilbage_select_user.Visible = true;
        // input feilds visible
        Edit_username.Visible  = true;
        Edit_email.Visible     = true;
        Edit_pwd.Visible       = true;
        Edit_adress.Visible    = true;
        Edit_usertype.Visible  = true;
        user_id.Visible = true;

        // admin user functions buttons
        update_user.Visible = true;
        delete_user.Visible = true;
        // set values from database into input feilds
        while (Reader.Read())
        {

            user_id.Text = Reader["UserID"].ToString();
            Edit_username.Text = Reader["Username"].ToString();
            Edit_email.Text = Reader["Email"].ToString();
            Edit_pwd.Text = Reader["Userpwd"].ToString();
            Edit_adress.Text = Reader["Adresse"].ToString();
            Edit_usertype.Text = Reader["Usertype"].ToString();
            
        }
    }
    protected void Tilbage_select_user_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_Admin.aspx");
        // labels to visivle
        Brugernavn.Visible = false;
        Email.Visible = false;
        Kodeord.Visible = false;
        Addresse.Visible = false;
        Brugertype.Visible = false;
        user_id_lable.Visible = false;
        // select user dropdown hidden
        Dropdown_dropdelete.Visible = true;
        select_user.Visible = true;
        // input feilds visible
        Edit_username.Visible = false;
        Edit_email.Visible = false;
        Edit_pwd.Visible = false;
        Edit_adress.Visible = false;
        Edit_usertype.Visible = false;
        user_id.Visible = false;

        // admin user functions buttons
        update_user.Visible = false;
        delete_user.Visible = false;
        Tilbage_select_user.Visible = false;
        // clear input feilds
            Edit_username.Text = "";
            Edit_email.Text = "";
            Edit_pwd.Text = "";
            Edit_adress.Text = "";
            Edit_usertype.Text = "";
    }
}