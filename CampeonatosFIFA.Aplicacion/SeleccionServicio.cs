using CampeonatosFIFA.Core.Repositorios;
using CampeonatosFIFA.Core.Servicios;
using CampeonatosFIFA.Dominio.Entidades;

namespace CampeonatosFIFA.Aplicacion
{
    public class SeleccionServicio:ISeleccionServicio
    {
        private readonly ISeleccionRepositorio repositorio;

        public SeleccionServicio(ISeleccionRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<Seleccion> Agregar(Seleccion seleccion)
        {
            return await repositorio.Agregar(seleccion);
        }

        public async Task<IEnumerable<Seleccion>> Buscar(int Tipo, string Dato)
        {
            return await repositorio.Buscar(Tipo, Dato);
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
            return await repositorio.Obtener(Id);
        }

        public async Task<IEnumerable<Seleccion>> ObtenerTodos()
        {
            return await repositorio.ObtenerTodos();
        }
    }
}
