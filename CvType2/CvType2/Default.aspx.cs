using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvType2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBL_HAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBL_DENEYIMTableAdapter dt2 = new DataSet1TableAdapters.TBL_DENEYIMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBL_EGITIMTableAdapter dt3 = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            Repeater3.DataSource = dt3.EgitimListesi();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBL_YETENEKTableAdapter dt4 = new DataSet1TableAdapters.TBL_YETENEKTableAdapter();
            Repeater4.DataSource = dt4.YetenekListesi();
            Repeater4.DataBind();

            DataSet1TableAdapters.TBL_HOBITableAdapter dt5 = new DataSet1TableAdapters.TBL_HOBITableAdapter();
            Repeater5.DataSource = dt5.HobiListe();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBL_DIGERTableAdapter dt6 = new DataSet1TableAdapters.TBL_DIGERTableAdapter();
            Repeater6.DataSource = dt6.DigerListele();
            Repeater6.DataBind();
        }
    }
}