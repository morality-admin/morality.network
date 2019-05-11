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
    
    public partial class PublisherChannel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PublisherChannel()
        {
            this.Contents = new HashSet<Content>();
        }
    
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UniqueDomain { get; set; }
        public double Tips { get; set; }
        public string PersonalWebsiteUrl { get; set; }
        public int Rating { get; set; }
        public string LogoUrl { get; set; }
    
        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Content> Contents { get; set; }
    }
}
