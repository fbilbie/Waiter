﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using db_mapping;

public partial class WaiterMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User user = Session["user"] as User;
        if (user != null)
        {
            LogoutHyperLink.Visible = true;

            if (user.Type.Equals("ADMIN"))
            {
                AdminHyperLink.Visible = true;
            }
        }
        Comanda comanda = Session["comanda"] as Comanda;
        Badge.Text = Convert.ToString( (comanda != null) ? comanda.NumarPreparate : 0);
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "Data-toogle", 
            "<script type='text/javascript'>"+
            "$(document).ready(function() {"+
                "Sys.WebForms.PageRequestManager.getInstance().add_endRequest(toogle);"+
                "toogle();"+
            "});"+
            "function toogle(){"+
                "$('[data-toggle=\"tooltip\"]').tooltip();"+
            "}"+
            "</script>");
    }
}
