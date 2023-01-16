using System;

namespace RXCrud.Domain.Entities
{
    public class Cidade : Entity
    {
        public Cidade(Guid id, string nome, Guid idEstado)
        {
            Id = id;
            Nome = nome;
            IdEstado = idEstado;
        }

        public Cidade(string nome, Guid idEstado)
        {
            Nome = nome;
            Id = Guid.NewGuid();
            IdEstado = idEstado;
        }

        public string Nome { get; set; }

        public Guid IdEstado { get; set; }

        public Estado Estado { get; set; }

    }
}