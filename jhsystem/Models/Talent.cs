//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace jhsystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Talent
    {
        public bool IsEnable { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string SEO { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<System.DateTime> ShowTime { get; set; }
        public string Url { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string Memo { get; set; }
    }
}