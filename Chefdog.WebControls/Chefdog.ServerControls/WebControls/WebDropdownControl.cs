using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chefdog.ServerControls.WebControls
{
    [DefaultProperty("DataToggle"), ParseChildren(true, "DropdownItems"),]
    [ToolboxData("<{0}:WebDropdownControl runat=server></{0}:WebDropdownControl>")]
    public class WebDropdownControl : WebControl
    {
        private WebDropdownItemCollection dropdownItems;

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string DataToggle
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public WebDropdownItemCollection DropdownItems
        {
            get
            {
                if (dropdownItems == null)
                {
                    dropdownItems = new WebDropdownItemCollection();
                }
                return dropdownItems;
            }
        }

        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                return HtmlTextWriterTag.Select;
            }
        }

        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            base.AddAttributesToRender(writer);
            writer.AddAttribute("data-toggle", DataToggle);
        }

        /// <summary>
		/// Required to be able to properly deal with the Collection object
		/// </summary>
		/// <param name="obj"></param>
		protected override void AddParsedSubObject(object obj)
        {
            if (obj is WebDropdownItem)
            {
                this.DropdownItems.Add((WebDropdownItem)obj);
                return;
            }
        }
               

        protected override void RenderContents(HtmlTextWriter writer)
        {
            foreach (WebDropdownItem item in dropdownItems) {
                if (item.IsSelected) {
                    writer.AddAttribute(HtmlTextWriterAttribute.Selected, "selected");
                }
                writer.AddAttribute(HtmlTextWriterAttribute.Value, item.ItemValue);
                writer.RenderBeginTag(HtmlTextWriterTag.Option);
                writer.Write(item.ItemText);
                writer.RenderEndTag();
            }
        }

        public void AddDropdownItem(string Text)
        {
            WebDropdownItem item = new WebDropdownItem();
            item.ItemValue = Text;
            this.AddDropdownItem(item);
        }

        public void AddDropdownItem(WebDropdownItem item)
        {
            this.dropdownItems.Add(item);
        }

    }
}
