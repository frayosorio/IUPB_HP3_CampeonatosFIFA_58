﻿using CampeonatosFIFA.Core.Servicios;
using CampeonatosFIFA.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CampeonatosFIFA.Presentacion.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuarioControlador : ControllerBase
    {
        private readonly IUsuarioServicio servicio;

        public UsuarioControlador(IUsuarioServicio servicio)
        {
            this.servicio = servicio;
        }

        [HttpGet("login/{NombreUsuario}/{Clave}")]
        public async Task<Usuario> Login(String NombreUsuario, String Clave)
        {
            return await servicio.ValidarUsuario(NombreUsuario, Clave);
        }
    }
}
