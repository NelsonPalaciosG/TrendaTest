using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TrendaTest.Web.Data.Entities;

namespace TrendaTest.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTiendaAsync();
            await CheckProductoAsync();
        }

        private async Task CheckTiendaAsync()
        {
            if (!_context.Tiendas.Any())
            {
                _context.Tiendas.Add(new Tienda { Nombre = "Centro", FechaApertura = DateTime.Now });
                _context.Tiendas.Add(new Tienda { Nombre = "Sabaneta", FechaApertura = DateTime.Now });
                _context.Tiendas.Add(new Tienda { Nombre = "Bello", FechaApertura = DateTime.Now });
                await _context.SaveChangesAsync();
            }
        }

        private async Task<Producto> CheckProductosAsync(

            string nombre,
            string descripcion,
            int valor,
            string picturePath,
            string nombreTienda)
        {
            if (!await _context.Productos.AnyAsync(p => p.Nombre == nombre))
            {
                Producto producto = new Producto
                {
                    Descripcion = descripcion,
                    Nombre = nombre,
                    PicturePath = picturePath,
                    Valor = valor,
                    Tienda = _context.Tiendas.FirstOrDefault(p => p.Nombre == nombreTienda)
                };
                await _context.Productos.AddAsync(producto);
                await _context.SaveChangesAsync();
                return producto;
            }
            return default;
        }

        private async Task CheckProductoAsync()
        {
            await CheckProductosAsync("Mantequilla", "Baja en grasa", 3200, "", "Centro");
            await CheckProductosAsync("Café", "Colcafé", 8500, "", "Sabaneta");
            await CheckProductosAsync("Azúcar", "Morena", 3100, "", "Centro");
            await CheckProductosAsync("Pan", "Tajado horneado", 2500, "", "Sabaneta");
            await CheckProductosAsync("TuttiFruti", "Sabor - Mora", 1800, "", "Centro");
            await CheckProductosAsync("Torta", "Maria luisa", 16000, "", "Bello");
        }

    }
}
