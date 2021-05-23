using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvType2
{
    public partial class KonferansListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DIGERTableAdapter dt = new DataSet1TableAdapters.TBL_DIGERTableAdapter();
            Repeater1.DataSource = dt.DigerListele();
            Repeater1.DataBind();
        }
    }
}