using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RXCrud.Domain.Dto
{
    [DisplayName("Cidade")]
    public class CidadeDto
    {
        public CidadeDto()
            => Id = Guid.NewGuid();

        public CidadeDto(string nome, Guid idEstado)
        {
            Nome = nome;
            IdEstado = idEstado;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo 'IdEstado' obrigatório.")]
        public Guid IdEstado { get; set; }

        public EstadoDto Estado { get; set; }
    }
}