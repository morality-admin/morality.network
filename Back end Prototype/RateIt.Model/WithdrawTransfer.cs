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
    
    public partial class WithdrawTransfer
    {
        public long Id { get; set; }
        public string ExternalTransactionId { get; set; }
        public double Amount { get; set; }
        public long UserId { get; set; }
        public double TransferFee { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual User User { get; set; }
    }
}
