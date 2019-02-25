using System;
using System.Web.UI;

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