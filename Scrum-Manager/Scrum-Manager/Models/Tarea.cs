//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scrum_Manager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarea()
        {
            this.Progreso = new HashSet<Progreso>();
        }
    
        public string id_tarea { get; set; }
        public string alias { get; set; }
        public int esfuerzo { get; set; }
        public string historia_fk { get; set; }
        public string usuario_FK { get; set; }
    
        public virtual Historia Historia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Progreso> Progreso { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
