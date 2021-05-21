using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvType2
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TextBox5.Enabled = false;
            TextBox5.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_DENEYIMTableAdapter dt = new DataSet1TableAdapters.TBL_DENEYIMTableAdapter();
                TextBox1.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
                TextBox2.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TextBox3.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TextBox4.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DENEYIMTableAdapter dt = new DataSet1TableAdapters.TBL_DENEYIMTableAdapter();
            dt.DeneyimGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text,Convert.ToInt16(TextBox5.Text));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}