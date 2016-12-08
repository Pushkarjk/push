using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string conString =" Data Source=LENOVO-PC;Initial Catalog = msdb; Integrated Security = True";
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conString);
        con.Open();
        string q = "select * from Users where name='"+uname.Text.ToString()+"' and pwd='"+pwd.Text.ToString()+"';";
        SqlCommand cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Response.Redirect("Default.aspx");

           
        }
        else
        {

            Response.Write("<script LANGUAGE='JavaScript' >alert('Login Failed')</script>");

           
        }
        con.Close();


    }
}