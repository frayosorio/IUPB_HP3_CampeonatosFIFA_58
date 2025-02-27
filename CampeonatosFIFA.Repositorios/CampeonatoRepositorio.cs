using CampeonatosFIFA.Core.Repositorios;
using CampeonatosFIFA.Dominio.Entidades;
using CampeonatosFIFA.Infraestructura.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFIFA.Repositorios
{
    public class CampeonatoRepositorio : ICampeonatoRepositorio
    {
        private readonly CampeonatosFifaContext context;
        public CampeonatoRepositorio(CampeonatosFifaContext context)
        {
            this.context = context;
        }

        public Task<Campeonato> Agregar(Campeonato Campeonato)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Campeonato>> Buscar(int Tipo, string Dato)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Campeonato> Modificar(Campeonato Campeonato)
        {
            throw new NotImplementedException();
        }

        public async Task<Campeonato> Obtener(int Id)
        {
            return await context.Campeonatos.FindAsync(Id);
        }

        public async Task<IEnumerable<Campeonato>> ObtenerTodos()
        {
            return await context.Campeonatos.ToArrayAsync();
        }
    }
}
