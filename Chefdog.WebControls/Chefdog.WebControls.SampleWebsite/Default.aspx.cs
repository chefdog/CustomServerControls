﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chefdog.WebControls.SampleWebsite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) {
                string parameter = Request["__EVENTARGUMENT"];
                var data = sender;
            }
        }
    }
}