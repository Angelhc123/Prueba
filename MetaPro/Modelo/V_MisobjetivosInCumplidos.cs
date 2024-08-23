namespace MetaPro.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_MisobjetivosInCumplidos
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(500)]
        public string Titulo { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "text")]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tiempo { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime FechaC { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Avance { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string Dificultad { get; set; }
    }
}
