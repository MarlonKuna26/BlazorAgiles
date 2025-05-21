using BlazorAplicacionAgiles.Application.Interfaces;
using BlazorAplicacionAgiles.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAplicacionAgiles.Infrastructure.Services
{
    public class ProductoService : IProductoService
    {
        public List<Producto> ObtenerTodos()
        {
            return new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Teclado", Precio = 120.99m },
                new Producto { Id = 2, Nombre = "Mouse", Precio = 89.50m }
            };
        }
    }
    }
