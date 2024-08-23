namespace MetaPro.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Amigo")]
    public partial class Amigos
    {
        [Key]
        public int IdAmigo { get; set; }

        public int IdUsuario { get; set; }

        public int IdAmigoUsuario { get; set; }

        public virtual Usuarios Usuario { get; set; }

        public virtual Usuarios Usuario1 { get; set; }
    }
}
