using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvType2
{
    public partial class KonferansEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DIGERTableAdapter dt = new DataSet1TableAdapters.TBL_DIGERTableAdapter();
            dt.KonferansEkle(TextBox1.Text, TextBox2.Text);
            Response.Redirect("KonferansListesi.aspx");
        }
    }
}