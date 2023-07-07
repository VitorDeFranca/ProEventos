using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
         public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo {0} é obrigatório.")]
        // [MinLength(3, ErrorMessage = "O campo {0} deve possuir no mínimo 3 caracteres.")]
        // [MaxLength(50, ErrorMessage = "O campo {0} deve possuir no máximo 50 caracteres.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo {0} deve possuir de 3 a 50 caracteres.")]
        public string Tema { get; set; }

        [Display(Name = "quantidade de pessoas")]
        [Range(1, 120000, ErrorMessage = "A {0} não pode ser menor que 1 ou maior que 120.000.")]
        public int QtdPessoas { get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$",
                           ErrorMessage = "Formato de imagem inválida. (gif|jpg|jpeg|bmp|png)")]
        public string ImagemURL { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo {0} é obrigatório.")]
        [Phone(ErrorMessage = "O {0} deve ser válido.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo {0} é obrigatório.")]
        [Display(Name = "e-mail")]
        [EmailAddress(ErrorMessage = "O {0} deve ser válido.")]
        public string Email { get; set; }
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrante { get; set; }
    }
}