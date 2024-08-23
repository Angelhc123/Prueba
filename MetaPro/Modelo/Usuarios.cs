namespace MetaPro.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            Amigo = new HashSet<Amigos>();
            Amigo1 = new HashSet<Amigos>();
        }

        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(30)]
        public string Nickname { get; set; }

        [Required]
        [StringLength(100)]
        public string Contraseña { get; set; }

        public int IdCriaturita { get; set; }

        public int IdObjetivo { get; set; }

        public int IdEstado { get; set; }

        public int IdCategoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Amigos> Amigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Amigos> Amigo1 { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Criaturitas Criaturita { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual Objetivos Objetivo { get; set; }
    }
}
