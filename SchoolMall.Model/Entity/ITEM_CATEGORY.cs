//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolMall.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ITEM_CATEGORY
    {
        public ITEM_CATEGORY()
        {
            this.ITEM_DETAIL = new HashSet<ITEM_DETAIL>();
        }
    
        public int Item_Categroy_Id { get; set; }
        public string Item_Category_Name { get; set; }
        public Nullable<bool> Activated { get; set; }
    
        public virtual ICollection<ITEM_DETAIL> ITEM_DETAIL { get; set; }
    }
}
