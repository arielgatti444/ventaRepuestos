using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventaRepuestos.Entidades
{
    public class VentaRepuestos
    {
        private List<Repuesto> _listaProductos;
        private String _nombreComercio;
        private String _direccion;

        public List<Repuesto> ListaProductos { get => _listaProductos;}
        public string NombreComercio { get => _nombreComercio;}
        public String Direccion { get => _direccion;}

        public void AgregarRepuesto(Repuesto r)
        {
            _listaProductos.Add(r);
        }

        public void QuitarRepuesto(int codigo)
        {
            foreach(Repuesto r in _listaProductos)
            {
                if (r.Codigo == codigo)
                {
                    _listaProductos.Remove(r);
                    break;
                }
            }
        }

        public void ModificarPrecio(int codigo, double precioNuevo)
        {
            foreach (Repuesto r in _listaProductos)
            {
                if (r.Codigo == codigo)
                {
                    r.Precio = precioNuevo;
                    break;
                }
            }
        }

        public void AgregarStock(int codigo, int cantidad)
        {
            // Asumo que voy a agregar stock de un repuesto que ya existe

            foreach (Repuesto r in _listaProductos)
            {
                if (r.Codigo == codigo)
                {
                    r.Stock = r.Stock + cantidad;
                    break;
                }
            }
        }

        public void QuitarStock(int codigo, int cantidad)
        {
            foreach (Repuesto r in _listaProductos)
            {
                if (r.Codigo == codigo)
                {
                    r.Stock = r.Stock - cantidad;
                    break;
                }
            }
        }

        public List<Repuesto> TraerPorCategoria(int codigoCat)
        {

        }
    }
}
