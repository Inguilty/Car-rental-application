//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetIdentity.Data.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class OfficeTel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OfficeTel()
        {
            this.Offices = new HashSet<Office>();
        }
    
        public int DefaultTel { get; set; }
        public Nullable<int> Tel1 { get; set; }
        public Nullable<int> Tel2 { get; set; }
        public Nullable<int> Tel3 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Office> Offices { get; set; }
    }
}