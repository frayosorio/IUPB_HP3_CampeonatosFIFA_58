using CampeonatosFIFA.Core.Repositorios;
using CampeonatosFIFA.Core.Servicios;
using CampeonatosFIFA.Dominio.Entidades;

namespace CampeonatosFIFA.aplicacion.Servicios
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly IUsuarioRepositorio repositorio;

        public UsuarioServicio(IUsuarioRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        public Task<Usuario> Agregar(Usuario Usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> Buscar(int Tipo, string Dato)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Modificar(Usuario Usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> ValidarUsuario(string NombreUsuario, string Clave)
        {
            return await repositorio.ValidarUsuario(NombreUsuario, Clave);
        }
    }
}
