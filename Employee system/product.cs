//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_system
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public product()
        {
            this.showcase_product = new HashSet<showcase_product>();
            this.salesrecord_product = new HashSet<salesrecord_product>();
        }
    
        public string Name { get; set; }
        public Nullable<int> TenantID { get; set; }
        public int ProductID { get; set; }
        public int ProductFee { get; set; }
        public int Discount { get; set; }
        public bool PrivateLabelItems { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<showcase_product> showcase_product { get; set; }
        public virtual tenant tenant { get; set; }
        public virtual ICollection<salesrecord_product> salesrecord_product { get; set; }
    }
}
