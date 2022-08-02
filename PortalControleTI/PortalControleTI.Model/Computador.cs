using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalControleTI.Model
{
    [Table("Computadores")]
    public class Computador
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string CT { get; set; }

        [Required]
        [Key]
        [MaxLength(50)]
        public string Serial { get; set; }

        [Required]
        [MaxLength(100)]
        public string Fabricante { get; set; }

        [Required]
        [MaxLength(100)]
        public string Modelo { get; set; }

        [MaxLength(255)]
        public string Processador { get; set; }

        [MaxLength(50)]
        public string HD { get; set; }

        [MaxLength(50)]
        public string Memoria { get; set; }

        [Required]
        public Tipo Tipo { get; set; }

        [Required]
        public Status Status { get; set; }

        [MaxLength(20)]
        public string Matricula { get; set; }

        [MaxLength(50)]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string ComputerName { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNfe { get; set; }

        [MaxLength(50)]
        public string NFe { get; set; }

        [MaxLength(100)]
        public string Local { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataAtualizacao { get; set; }

        public string Obs { get; set; }
    }
}
