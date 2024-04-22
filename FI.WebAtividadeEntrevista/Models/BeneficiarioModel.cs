using System.ComponentModel.DataAnnotations;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Beneficiario
    /// </summary>
    public class BeneficiarioModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Digite um cpf")]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Digite um nome")]
        public string Nome { get; set; }

        public long IdCliente { get; set; }


    }
}