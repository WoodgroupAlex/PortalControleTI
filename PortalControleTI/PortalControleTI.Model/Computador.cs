using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalControleTI.Model
{
    [Table("Computadores")]
    public class Computador
    {
        [MaxLength(50)]
        public string CT { get; set; }

        [MaxLength(50)]
        public string NFe { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [MaxLength(255)]
        public string Fabricante { get; set; }

        [MaxLength(100)]
        public string Modelo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Serial { get; set; }

        [MaxLength(50)]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string ComputerName { get; set; }

        public Status Status { get; set; }

        [MaxLength(20)]
        public string Matricula { get; set; }

        public Tipo Tipo { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataAtualizacao { get; set; }

        [MaxLength(255)]
        public string Obs { get; set; }

        [MaxLength(100)]
        public string Local { get; set; }
    }
}
