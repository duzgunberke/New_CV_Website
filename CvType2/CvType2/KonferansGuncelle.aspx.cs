using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvType2
{
    public partial class KonferansGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            txtid.Text = x.ToString();
            txtid.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_DIGERTableAdapter dt = new DataSet1TableAdapters.TBL_DIGERTableAdapter();
                txtekstra.Text = dt.KonferansGetir(Convert.ToInt16(x))[0].EKSTRA;
                txtlınk.Text = dt.KonferansGetir(Convert.ToInt16(x))[0].LINK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DIGERTableAdapter dt = new DataSet1TableAdapters.TBL_DIGERTableAdapter();
            dt.KonferansGuncelle(txtekstra.Text,txtlınk.Text,Convert.ToInt16(txtid.Text));
            Response.Redirect("KonferansListesi.aspx");
        }
    }
}