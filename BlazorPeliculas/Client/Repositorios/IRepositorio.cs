﻿using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
    public interface IRepositorio
    {
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        List<Pelicula> ObtenerPeliculas();
    }
}
