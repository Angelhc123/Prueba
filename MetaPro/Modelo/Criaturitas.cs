namespace MetaPro.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Criaturita")]
    public partial class Criaturitas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Criaturitas()
        {
            Usuario = new HashSet<Usuarios>();
        }

        [Key]
        public int IdCriaturita { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(11)]
        public string Celular { get; set; }

        [Required]
        [StringLength(50)]
        public string Pais { get; set; }

        [StringLength(50)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(11)]
        public string Sexo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuario { get; set; }
    }
}
