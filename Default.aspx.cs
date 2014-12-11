using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_field_Click(object sender, EventArgs e)
    {
        if (Username_Field.Text != "" && Password_Field.Text != "")
        {
            SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
              SqlCommand SQLCmd = new SqlCommand("select * from Users where Username = '"+ Username_Field.Text +"' and UserPwd = '"+Password_Field.Text +"'", DBCon);
              SQLCmd.Connection.Open();
              SqlDataReader Reader = SQLCmd.ExecuteReader();
              string USR = "", PWD = "", USRT ="";

              while (Reader.Read())
              {
                  USR = Reader["Username"].ToString();
                  PWD = Reader["Userpwd"].ToString();
                  USRT = Reader["Usertype"].ToString();
              }
             //Denne side redirecte til Admin
              if (USR == Username_Field.Text && PWD == Password_Field.Text && USRT == "Admin")
              {
                  Response.Redirect("User_Admin.aspx");
              }
              //Denne side redirecte til Sub
              else if (USR == Username_Field.Text && PWD == Password_Field.Text && USRT == "Sub")
              {
                  Response.Redirect("User_Sub.aspx");
              }
              //Denne side redirecte til Calc
              else if (USR == Username_Field.Text && PWD == Password_Field.Text && USRT == "Calc")
              {
                  Response.Redirect("User_Calc.aspx");
              }
              //Denne side redirecte til Subcalc
              else if (USR == Username_Field.Text && PWD == Password_Field.Text && USRT == "Subcalc")
              {
                  Response.Redirect("User_SubCalc.aspx");
              }
              //Denne side redirecte til Default(.aspx)
              else
              {
                  Response.Redirect("Default.aspx");
              }


           
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void _field_Click(object sender, EventArgs e)
    {
        Response.Redirect("Glemt_kode.aspx");
    }
    protected void new_user_field_Click(object sender, EventArgs e)
    {
        Response.Redirect("User_new.aspx");
    }
}