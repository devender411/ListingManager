//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListingDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Listing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Listing()
        {
            this.AgentListings = new HashSet<AgentListing>();
        }
    
        public int Listing_Id { get; set; }
        public string ListingCode { get; set; }
        public string ListingName { get; set; }
        public string ListingAddress { get; set; }
        public Nullable<System.DateTime> ListingDate { get; set; }
        public string ListingCreatedBy { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentListing> AgentListings { get; set; }
    }
}
