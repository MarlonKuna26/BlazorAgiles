using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorAplicacionAgiles.Domain.Entities;


namespace BlazorAplicacionAgiles.Application.Interfaces;

public interface IProductoService
{
    List<Producto> ObtenerTodos();
}
