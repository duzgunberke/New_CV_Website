using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvType2
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            txtid.Text = x.ToString();
            txtid.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_YETENEKTableAdapter dt = new DataSet1TableAdapters.TBL_YETENEKTableAdapter();

                txtyetenek.Text = dt.YetenekGetir(Convert.ToInt16(x))[0].YETENEK;


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_YETENEKTableAdapter dt = new DataSet1TableAdapters.TBL_YETENEKTableAdapter();
            dt.YetenekGuncelle(txtyetenek.Text, Convert.ToInt16(txtid.Text));
            Response.Redirect("YetenekListesi.aspx");
        }
    }
}