﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarkoDjakDomaci
{
    public partial class izvestaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
              lblRezultat.Text = PreviousPage.ime + " (" + PreviousPage.mejl + "), rođen/a , " + PreviousPage.godina + " godine, ucenik " + PreviousPage.razred + ". razreda, uspesno je popunio obrazac za prijavu...";
        }
    }
}