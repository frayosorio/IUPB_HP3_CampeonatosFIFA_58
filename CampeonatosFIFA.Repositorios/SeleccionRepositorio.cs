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

        public async Task<bool> Eliminar(int Id)
        {
            var seleccionExistente = await context.Selecciones.FindAsync(Id);
            if (seleccionExistente == null)
            {
                return false;
            }
            try
            {
                context.Selecciones.Remove(seleccionExistente);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Seleccion> Modificar(Seleccion seleccion)
        {
            var seleccionExistente = await context.Selecciones.FindAsync(seleccion.Id);
            if (seleccionExistente == null)
            {
                return null;
            }

            context.Entry(seleccionExistente).CurrentValues.SetValues(seleccion);
            await context.SaveChangesAsync();

            return await context.Selecciones.FindAsync(seleccion.Id);
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
