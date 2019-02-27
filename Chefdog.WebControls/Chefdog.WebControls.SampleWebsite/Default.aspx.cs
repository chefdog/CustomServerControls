using Chefdog.ServerControls.WebControls;
using System;
using System.Web.UI;

namespace Chefdog.WebControls.SampleWebsite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sessionParam = (string)Session["selectedOption"];
            string eventParam = Request["__EVENTARGUMENT"];
            
            if (IsPostBack)
            {
                //set to default
                if (string.IsNullOrEmpty(eventParam) && string.IsNullOrEmpty(sessionParam)) {
                    setSelectedItem("Test02");
                    Session["selectedOption"] = "Test02";
                }

                //set to session
                if (string.IsNullOrEmpty(eventParam) && !string.IsNullOrEmpty(sessionParam))
                {
                    setSelectedItem(sessionParam);
                    Session["selectedOption"] = sessionParam;
                }

                //set to event
                if (!string.IsNullOrEmpty(eventParam) && !string.IsNullOrEmpty(sessionParam))
                {
                    setSelectedItem(eventParam);
                    Session["selectedOption"] = eventParam;
                }
            }
            else {
                //set to default
                cfgDropdown.DropdownItems[1].IsSelected = true;
                Session["selectedOption"] = "Test02";
            }
        }


        private void setSelectedItem(string itemValue) {
            for (int x = 0; x < cfgDropdown.DropdownItems.Count; x++)
            {
                cfgDropdown.DropdownItems[x].IsSelected = false;
                if (cfgDropdown.DropdownItems[x].ItemValue == itemValue) {
                    cfgDropdown.DropdownItems[x].IsSelected = true;
                }
            }
        }
    }
}