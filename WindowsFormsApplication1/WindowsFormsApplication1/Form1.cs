using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=LENOVO-PC;Initial Catalog=master;Integrated Security=True";



        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string q = "insert into hello values ('" + txt.Text.ToString() + "','12')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            disp();
       }

        public void disp()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string q = "Select * from hello";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();




        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            disp();
        }
    }
}
