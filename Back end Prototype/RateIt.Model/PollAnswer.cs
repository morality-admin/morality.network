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
    
    public partial class PollAnswer
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string Comments { get; set; }
        public long PollId { get; set; }
    
        public virtual Poll Poll { get; set; }
    }
}