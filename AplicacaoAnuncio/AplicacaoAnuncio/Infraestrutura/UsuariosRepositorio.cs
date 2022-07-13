﻿using AplicacaoAnuncio.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AplicacaoAnuncio.Infraestrutura
{
    public class UsuariosRepositorio
    {
        private readonly IConfiguration _configuration;
        private readonly AnuncioDbContext _anuncioDbContext;

        public UsuariosRepositorio(AnuncioDbContext anuncioDbContext, IConfiguration configuracao)
        {
            _anuncioDbContext = anuncioDbContext;
            _configuration = configuracao;
        }

        public async Task InserirAsync(Usuario usuario, CancellationToken cancellationToken = default)
        {
            await _anuncioDbContext.AddAsync(usuario, cancellationToken);
        }

        public async Task<IEnumerable<Usuario>> RecuperarTodosAsync(CancellationToken cancellationToken = default)
        {
            return await _anuncioDbContext
                .Usuarios
                .ToListAsync(cancellationToken);
        }

        public async Task<Usuario> RecuperarPorIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _anuncioDbContext
                .Usuarios
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
        }

        public async Task CommitAsync(CancellationToken cancellationToken)
        {
            await _anuncioDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<Usuario> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await _anuncioDbContext
                        .Usuarios
                        .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);

            if (result != null)
            {
                _anuncioDbContext.Remove(result);
                await _anuncioDbContext.SaveChangesAsync(cancellationToken);
                return result;
            }

            return result;
        }

        public async Task UpdateAsync(CancellationToken cancellationToken = default)
        {
            await _anuncioDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
