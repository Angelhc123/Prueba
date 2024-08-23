namespace MetaPro.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_BuscarAmigo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Nickname { get; set; }
    }
}
