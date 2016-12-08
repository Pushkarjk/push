using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{

    public string conString = " Data Source=LENOVO-PC;Initial Catalog = msdb; Integrated Security = True";
    protected void Page_Load(object sender, EventArgs e)
    {

        disp();
    }

    public void disp()
    {
        SqlConnection con = new SqlConnection(conString);
        con.Open();
        string q = "select * from Users";
        SqlCommand cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(dt);
        GridView1.DataSource = dt;
        con.Close();
    }
}