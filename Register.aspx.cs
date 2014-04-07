using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        string username = CreateUserWizard1.UserName;
        string password = CreateUserWizard1.Password;
        string email = CreateUserWizard1.Email;
        string security_Q = CreateUserWizard1.Question;
        string security_A = CreateUserWizard1.Answer;

        
        
        SqlConnection con = new SqlConnection("Data Source=GAURAV-PC\\SQLEXPRESS;Initial Catalog=Manage_My_Migraine;Integrated Security=True");
        con.Open();
        SqlCommand sc = new SqlCommand("INSERT into Login1 values(@username,@password,@email,@security_Q,@security_A)", con);

        sc.Parameters.AddWithValue("@username", username);
        sc.Parameters.AddWithValue("@password", password);
        sc.Parameters.AddWithValue("@email", email);
        sc.Parameters.AddWithValue("@security_Q", security_Q);
        sc.Parameters.AddWithValue("@security_A", security_A);

        object o = sc.ExecuteNonQuery();
        MessageBox.Show(o + ":Record inserted");

        con.Close();

    }
    public static void main(string[] args)
    {
        System.Windows.Forms.Application.Run();
    }
}

