//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaTecnica.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class estados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public estados()
        {
            this.contratoslaborales = new HashSet<contratoslaborales>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string usuariocreacion { get; set; }
        public Nullable<System.DateTime> fechacreacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contratoslaborales> contratoslaborales { get; set; }
    }
}
