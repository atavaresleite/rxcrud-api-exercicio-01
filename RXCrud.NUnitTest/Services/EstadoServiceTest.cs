using AutoMapper;
using Moq;
using NUnit.Framework;
using RXCrud.Domain.Dto;
using RXCrud.Domain.Entities;
using RXCrud.Domain.Exception;
using RXCrud.Domain.Interfaces.Data;
using RXCrud.Domain.Interfaces.Services;
using RXCrud.NUnitTest.Common;
using RXCrud.Service.Services;
using System.Collections.Generic;
using System.Linq;

namespace RXCrud.NUnitTest.Services
{
    public class EstadoServiceTest
    {
        private IMapper _mapper;
        private Estado _estado;
        private IEstadoService _estadoService;
        private Mock<IEstadoRepository> _mockEstadoRepository;

        public EstadoServiceTest()
        {
            _mapper = Utilitarios.GetMapper();
            _mockEstadoRepository = new Mock<IEstadoRepository>();
            _estadoService = new EstadoService(_mapper, _mockEstadoRepository.Object);
            _estado = new Estado("CE", "Ceará");
        }

        [Test]
        public void CriarComConstrutorTest() => Assert.IsNotNull(new EstadoDto());

        [Test]
        public void CriarTest() => Assert.DoesNotThrow(() => _estadoService.Criar(new EstadoDto("CE", "Ceará")));

        [Test]
        public void AtualizarTest() => Assert.DoesNotThrow(() => _estadoService.Atualizar(new EstadoDto("CE", "Ceará")));

        [Test]
        public void RemoverTest() => Assert.DoesNotThrow(() => _estadoService.Remover(new EstadoDto("CE", "Ceará")));

        [Test]
        public void ObterTodosTest()
        {
            IList<Estado> estadosList = new List<Estado>();
            estadosList.Add(_estado);

            _mockEstadoRepository.Setup(r => r.ObterTodos()).Returns(estadosList.AsQueryable());
            Assert.IsNotNull(_estadoService.ObterTodos());
        }

        [Test]
        public void PesquisarPorIdTest()
        {
            _mockEstadoRepository.Setup(r => r.PesquisarPorId(_estado.Id)).Returns(_estado);
            Assert.IsNotNull(_estadoService.PesquisarPorId(_estado.Id));
        }
    }
}