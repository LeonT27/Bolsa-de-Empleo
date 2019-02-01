namespace BolsaEmpleos.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Job
    {
        [Key]
        public int Id_Job { get; set; }

        [Required]
        [StringLength(50)]
        public string Compañia { get; set; }

        public int Tipo { get; set; }

        [StringLength(255)]
        public string Logo { get; set; }

        [StringLength(50)]
        public string URL { get; set; }

        [Required]
        [StringLength(50)]
        public string Posicion { get; set; }

        [StringLength(255)]
        public string Ubicacion { get; set; }

        public int? Id_Categoria { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string Como_Aplicar { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public bool Permisos_Afiliados { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_Inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_Final { get; set; }

        public bool? Estado { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
