using CampeonatosFIFA.Core.Repositorios;
using CampeonatosFIFA.Dominio.Entidades;
using CampeonatosFIFA.Infraestructura.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFIFA.Repositorios
{
    public class SeleccionRepositorio : ISeleccionRepositorio
    {
        private readonly CampeonatosFifaContext context;

        public SeleccionRepositorio(CampeonatosFifaContext context)
        {
            this.context = context;
        }


        public async Task<Seleccion> Agregar(Seleccion seleccion)
        {
            context.Selecciones.Add(seleccion);
            await context.SaveChangesAsync();
            return seleccion;
        }

        public async Task<IEnumerable<Seleccion>> Buscar(int Tipo, string Dato)
        {
            return await context.Selecciones
                .Where(item => (Tipo == 0 && item.Nombre.Contains(Dato))
                || Tipo == 1 && item.Entidad.Contains(Dato))
                .ToArrayAsync(); 
        }

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Seleccion> Modificar(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        public async Task<Seleccion> Obtener(int Id)
        {
            return await context.Selecciones.FindAsync(Id);
        }

        public async Task<IEnumerable<Seleccion>> ObtenerTodos()
        {
            return await context.Selecciones.ToArrayAsync();
        }
    }
}
