//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RateIt.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContentTransaction
    {
        public long Id { get; set; }
        public long ContentId { get; set; }
        public string TransactionHash { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
    }
}
