//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenArquitectura.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            this.Egreso = new HashSet<Egreso>();
        }
    
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public int Periodos { get; set; }
        public int CostoCurso { get; set; }
        public int IdMaestro { get; set; }
        public int PagoCurso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Egreso> Egreso { get; set; }
        public virtual Maestro Maestro { get; set; }
    }
}
