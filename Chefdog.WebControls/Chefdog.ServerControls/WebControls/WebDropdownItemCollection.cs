using System.Collections;

namespace Chefdog.ServerControls.WebControls
{
    public class WebDropdownItemCollection : CollectionBase
    {
        public WebDropdownItem this[int index]
        {
            get
            {
                return (WebDropdownItem)this.List[index];
            }
            set
            {
                this.List[index] = value;
            }
        }

        public void Add(WebDropdownItem item)
        {
            this.List.Add(item);
        }

        public void Insert(int index, WebDropdownItem item)
        {
            this.List.Insert(index, item);
        }

        public void Remove(WebDropdownItem item)
        {
            List.Remove(item);
        }

        public bool Contains(WebDropdownItem item)
        {
            return this.List.Contains(item);
        }

        //Collection IndexOf method 
        public int IndexOf(WebDropdownItem item)
        {
            return List.IndexOf(item);
        }

        public void CopyTo(WebDropdownItem[] array, int index)
        {
            List.CopyTo(array, index);
        }
    }
}
