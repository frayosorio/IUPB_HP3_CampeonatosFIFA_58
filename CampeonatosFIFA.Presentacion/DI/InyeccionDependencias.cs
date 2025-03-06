using CampeonatosFIFA.Aplicacion;
using CampeonatosFIFA.Core.Repositorios;
using CampeonatosFIFA.Core.Servicios;
using CampeonatosFIFA.Infraestructura.Persistencia.Contexto;
using CampeonatosFIFA.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFIFA.Presentacion.DI
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AgregarDependencias(this IServiceCollection servicios,
                                                            IConfiguration configuracion)
        {
            servicios.AddDbContext<CampeonatosFifaContext>(opciones =>
            {
                opciones.UseSqlServer(configuracion.GetConnectionString("CampeonatosFIFA"));
            });

            //agregar repositorios
            servicios.AddTransient<ISeleccionRepositorio, SeleccionRepositorio>();

            //agregar servicios
            servicios.AddTransient<ISeleccionServicio, SeleccionServicio>();

            return servicios;
        }
    }
}
