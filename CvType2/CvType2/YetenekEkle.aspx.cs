﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvType2
{
    public partial class YetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_YETENEKTableAdapter dt = new DataSet1TableAdapters.TBL_YETENEKTableAdapter();
            dt.YetenekEkle(TextBox1.Text);
            Response.Redirect("YetenekListesi.aspx");
        }
    }
}