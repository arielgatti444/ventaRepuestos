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

        }

        public void QuitarRepuesto(int codigo)
        {

        }

        public void ModificarPrecio(int codigo, double precioNuevo)
        {

        }

        public void AgregarStock(int codigo, int cantidad)
        {

        }

        public void QuitarStock(int codigo, int cantidad)
        {

        }

        public List<Repuesto> TraerPorCategoria(int codigoCat)
        {

        }
    }
}
