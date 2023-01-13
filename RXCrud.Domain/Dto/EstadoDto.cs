using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RXCrud.Domain.Dto
{
    [DisplayName("Estado")]
    public class EstadoDto
    {
        public EstadoDto()
            => Id = Guid.NewGuid();

        public EstadoDto(string uF, string nome)
        {
            Nome = nome;
            UF = uF;
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo 'UF' obrigatório.")]
        public string UF { get; set; }
    }
}