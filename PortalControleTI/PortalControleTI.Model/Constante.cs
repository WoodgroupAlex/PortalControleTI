using System.ComponentModel.DataAnnotations;

namespace PortalControleTI.Model
{
    public enum Tipo
    {
        [Display(Name = "Sem Especificação")]
        Unspecified = 0,

        [Display(Name = "Desktop")]
        Desktop = 1,

        [Display(Name = "Notebook")]
        Mobile = 2,

        [Display(Name = "Estação de Trabalho")]
        Workstation = 3,

        [Display(Name = "Servidor")]
        EnterpriseServer = 4,

        [Display(Name = "Servidor SOHO")]
        SOHOServer = 5,

        [Display(Name = "Servidor de Performance")]
        PerformanceServer = 7
    }
    public enum Status
    {
        [Display(Name = "Sem Status")]
        SemStatus = 0,

        [Display(Name = "Em Estoque")]
        Estoque = 1,

        [Display(Name = "Acesso Remoto")]
        Remoto = 2,

        [Display(Name = "Em Uso")]
        Uso = 3,

        [Display(Name = "Extraviado")]
        Extraviado = 4,

        [Display(Name = "Reparo")]
        Reparo = 5,

        [Display(Name = "Roubado")]
        Roubado = 6,

        [Display(Name = "Devolvido")]
        Devolvido = 7
    }
}
