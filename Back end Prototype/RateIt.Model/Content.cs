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
    
    public partial class Content
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Content()
        {
            this.Activitys = new HashSet<Activity>();
            this.Comments1 = new HashSet<Comment>();
            this.CrowdfundingCampaigns = new HashSet<CrowdfundingCampaign>();
            this.Notifications = new HashSet<Notification>();
            this.Polls = new HashSet<Poll>();
            this.Surveys = new HashSet<Survey>();
            this.UserContentValidations = new HashSet<UserContentValidation>();
        }
    
        public long Id { get; set; }
        public System.DateTime Timestamp { get; set; }
        public long SubDirectoryId { get; set; }
        public bool ExistsOnBlockChain { get; set; }
        public string Comments { get; set; }
        public bool AppliedForPersistence { get; set; }
        public Nullable<System.DateTime> AppliedForPersistencedAt { get; set; }
        public bool EligableForPersistance { get; set; }
        public Nullable<System.DateTime> EligableForPersistanceAt { get; set; }
        public long ContentTypeId { get; set; }
        public Nullable<long> PublisherChannelId { get; set; }
        public int ValidationRunCount { get; set; }
        public bool ReferredViaValidationToAdmin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activitys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments1 { get; set; }
        public virtual ContentType ContentType { get; set; }
        public virtual PublisherChannel PublisherChannel { get; set; }
        public virtual SubDirectory SubDirectory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrowdfundingCampaign> CrowdfundingCampaigns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Poll> Polls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Survey> Surveys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserContentValidation> UserContentValidations { get; set; }
    }
}
