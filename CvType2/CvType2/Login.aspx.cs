using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CvType2
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-IT01AUN;Initial Catalog=CVweb;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * from TBL_ADMIN where KULLANICI=@p1 and SIFRE=@p2", bgl);
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("Hakkımda.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            bgl.Close();
        }
    }
}