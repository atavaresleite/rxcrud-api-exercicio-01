using System;

namespace RXCrud.Domain.Entities
{
    public class Estado : Entity
    {
        public Estado(Guid id, string uF, string nome)
        {
            Id = id;
            UF = uF;
            Nome = nome;
        }

        public Estado(string uF, string nome)
        {
            UF = uF;
            Nome = nome;
            Id = Guid.NewGuid();
        }

        public string UF { get; set; }
        public string Nome { get; set; }

    }
}