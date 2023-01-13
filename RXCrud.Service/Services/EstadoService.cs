using AutoMapper;
using AutoMapper.QueryableExtensions;
using RXCrud.Domain.Dto;
using RXCrud.Domain.Entities;
using RXCrud.Domain.Exception;
using RXCrud.Domain.Interfaces.Data;
using RXCrud.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace RXCrud.Service.Services
{
    public class EstadoService : IEstadoService
    {
        private readonly IMapper _mapper;
        private readonly IEstadoRepository _usuarioRepository;

        public EstadoService(IMapper mapper, IEstadoRepository usuarioRepository)
        {
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
        }

        public void Criar(EstadoDto usuarioDto)
            => _usuarioRepository.Criar(_mapper.Map<Estado>(usuarioDto));
        

        public void Atualizar(EstadoDto usuarioDto)
            => _usuarioRepository.Atualizar(_mapper.Map<Estado>(usuarioDto));
        

        public void Remover(EstadoDto usuarioDto)
            => _usuarioRepository.Remover(_mapper.Map<Estado>(usuarioDto));

        public IQueryable<EstadoDto> ObterTodos()
            => _usuarioRepository.ObterTodos().ProjectTo<EstadoDto>(_mapper.ConfigurationProvider);

        public EstadoDto PesquisarPorId(Guid id)
            => _mapper.Map<EstadoDto>(_usuarioRepository.PesquisarPorId(id));
    }
}