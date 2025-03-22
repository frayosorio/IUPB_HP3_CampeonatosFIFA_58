﻿using CampeonatosFIFA.Dominio.Entidades;

namespace CampeonatosFIFA.Core.Repositorios
{
    public interface ICiudadRepositorio
    {
        Task<IEnumerable<Ciudad>> ObtenerTodos();

        Task<Ciudad> Obtener(int Id);

        Task<Ciudad> Agregar(Ciudad Ciudad);

        Task<Ciudad> Modificar(Ciudad Ciudad);

        Task<bool> Eliminar(int Id);

        Task<IEnumerable<Ciudad>> Buscar(int Tipo, string Dato);
    }
}
