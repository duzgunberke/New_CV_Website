using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvType2
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TextBox5.Enabled = false;
            TextBox5.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_EGITIMTableAdapter dt = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
                TextBox1.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
                TextBox2.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TextBox3.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                txtgenelnot.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].GNOT;
                TextBox4.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH;
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_EGITIMTableAdapter dt = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            dt.EgitimGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, txtgenelnot.Text, TextBox4.Text,Convert.ToInt16(TextBox5.Text));
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}