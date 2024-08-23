namespace MetaPro.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Objetivo")]
    public partial class Objetivos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Objetivos()
        {
            Usuario = new HashSet<Usuarios>();
        }

        [Key]
        public int IdObjetivo { get; set; }

        [Required]
        [StringLength(500)]
        public string Titulo { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Descripcion { get; set; }

        public int Tiempo { get; set; }

        public DateTime FechaC { get; set; }

        public int Avance { get; set; }

        public int IdCategoria { get; set; }

        public virtual Categoria Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuario { get; set; }
    }
}
