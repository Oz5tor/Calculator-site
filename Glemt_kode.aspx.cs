﻿using System;
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
        //Tjekker de to indtastede password er ens
        if (res_password.Text == conf_res_password.Text)
        {
            //Tjekker username og email stemmer overens
            SqlConnection DBCon = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
            SqlCommand SQLCheck = new SqlCommand("select * from Users where Username = '" + res_Username.Text + "' and Email = '" + res_email.Text + "'", DBCon);
            SQLCheck.Connection.Open();
            SqlDataReader Reader = SQLCheck.ExecuteReader();

            if (Reader.Read())
            {
                SQLCheck.Connection.Close();
                SQLCheck.Connection.Dispose();
                // updatere password i databasen
                SqlConnection DBCon2 = new SqlConnection("Data Source=RDK100938;Initial Catalog=Skole;Integrated Security=True");
                SqlCommand Sqlupdate = new SqlCommand("UPDATE Users SET Userpwd = '" + res_password.Text + "' where Username = '" + res_Username.Text + "' and Email = '" + res_email.Text + "'", DBCon2);
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
                Response.AddHeader("REFRESH", "5;URL=Default.aspx");
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
