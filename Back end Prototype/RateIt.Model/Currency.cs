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
    
    public partial class Currency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Currency()
        {
            this.CreditWallets = new HashSet<CreditWallet>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Abi { get; set; }
        public bool IsTest { get; set; }
        public string Network { get; set; }
        public string AdminAddress { get; set; }
        public bool Active { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditWallet> CreditWallets { get; set; }
    }
}
