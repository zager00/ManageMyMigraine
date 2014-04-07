using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Collections.ObjectModel;
using System.Collections.Generic;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Microsoft.Health;
using Microsoft.Health.Web;
using Microsoft.Health.ItemTypes;
using Microsoft.Health.PatientConnect;
using Microsoft.Health.Authentication;
using Microsoft.Health.Web.Authentication;
using Microsoft.Health.Package;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      


    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string SqlConnection_string = "Data Source=GAURAV-PC\\SQLEXPRESS;Initial Catalog=Manage_My_Migraine;Integrated Security=True";

        string username = Login1.UserName;
        string password = Login1.Password;

        
        SqlConnection con = new SqlConnection(SqlConnection_string);
        
        string querystring = "select Username,password from Login1";

        using(SqlConnection conn = new SqlConnection(SqlConnection_string))
        using(SqlCommand command = conn.CreateCommand())
        {
            conn.Open();
            command.CommandText = querystring;
            

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    string DB_username  = reader["Username"].ToString();
                    string DB_password = reader["password"].ToString();

                    if (username == DB_username && password == DB_password)
                    {
                        Session["UserAuthenticate"] = username;
                        Session.Timeout = 1;
                        Response.Redirect("Physician.aspx");
                       
                    }
                    else 
                    {
                        Session["UserAuthenticate"] = "";
                    }
                    
                }
                
            }
        }


        //object o = sc.ExecuteNonQuery();
        //MessageBox.Show(o + ":Record inserted");

        con.Close();
    }

    
}



