using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventaRepuestos.Entidades
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public int Codigo { get => _codigo; }
        public string Nombre { get => _nombre; }
        public double Precio { get => _precio; set => _precio = value;}
        public int Stock { get => _stock; set => _stock = value; }
        public Categoria Categoria { get => _categoria; }


        public string ToString()
        {
            return this._nombre;
        }

    }
}
