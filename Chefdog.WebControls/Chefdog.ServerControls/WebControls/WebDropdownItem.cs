using System;
using System.ComponentModel;
using System.Web.UI;

namespace Chefdog.ServerControls.WebControls
{
    [ToolboxData("<{0}:WebDropdownItem runat=server></{0}:WebDropdownItem>")]
    public class WebDropdownItem
    {
        private string _itemText;
        private string _itemValue;
        private bool _itemSelected;

        [
        Category("Behavior"),
        DefaultValue(""),
        Description("Value of the option."),
        NotifyParentProperty(true),
        ]
        public virtual String ItemValue
        {
            get
            {
                return _itemValue;
            }
            set
            {
                _itemValue = value;
            }
        }

        [
        Category("Behavior"),
        DefaultValue(""),
        Description("Text of the option."),
        NotifyParentProperty(true),
        ]
        public virtual String ItemText
        {
            get
            {
                return _itemText;
            }
            set
            {
                _itemText = value;
            }
        }

        [
        Category("Behavior"),
        DefaultValue(""),
        Description("Selected Value of the option."),
        NotifyParentProperty(true),
        ]
        public virtual bool IsSelected
        {
            get
            {
                return _itemSelected;
            }
            set
            {
                _itemSelected = value;
            }
        }
    }
}
