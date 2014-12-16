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
    protected void Send_besked_Click(object sender, EventArgs e)
    {
        
         
        SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");

        SqlCommand SQLCmd = new SqlCommand("Insert into Kontakt values ('" + kontakt_navn.Text + "','" + kontakt_email.Text + "','" + kontakt_besked.Text + "');", DBCon);
        SQLCmd.Connection.Open();
        SQLCmd.ExecuteNonQuery();
        SQLCmd.Connection.Close();
        SQLCmd.Connection.Dispose();

        besked_send.Visible = true;
        
        }
    }
