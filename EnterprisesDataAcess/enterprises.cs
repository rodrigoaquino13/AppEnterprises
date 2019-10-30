//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnterprisesDataAcess
{
    using System;
    using System.Collections.Generic;
    
    public partial class enterprises
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public enterprises()
        {
            this.portfolio = new HashSet<portfolio>();
        }
    
        public int id { get; set; }
        public string enterprise_name { get; set; }
        public string description { get; set; }
        public string email_enterprise { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string linkedin { get; set; }
        public string phone { get; set; }
        public string own_enterprise { get; set; }
        public string photo { get; set; }
        public string value { get; set; }
        public Nullable<double> shares { get; set; }
        public Nullable<double> share_price { get; set; }
        public Nullable<int> own_shares { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public Nullable<int> enterprise_type_id { get; set; }
    
        public virtual enterprise_type enterprise_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<portfolio> portfolio { get; set; }
    }
}