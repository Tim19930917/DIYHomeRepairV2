//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIY_v2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Detail
    {
        public int SerialNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string OrderID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<short> ProductPrice { get; set; }
        public Nullable<short> OrderQuantity { get; set; }
        public string OrderStatus { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Product Product { get; set; }
    }
}