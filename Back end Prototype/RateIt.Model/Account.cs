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
    
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            this.CreditWallets = new HashSet<CreditWallet>();
            this.Currencys = new HashSet<Currency>();
            this.PublisherChannels = new HashSet<PublisherChannel>();
        }
    
        public long Id { get; set; }
        public string EthereumAddress { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public System.DateTime LastEdit { get; set; }
        public long UserId { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public bool IsAdmin { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditWallet> CreditWallets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Currency> Currencys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PublisherChannel> PublisherChannels { get; set; }
    }
}