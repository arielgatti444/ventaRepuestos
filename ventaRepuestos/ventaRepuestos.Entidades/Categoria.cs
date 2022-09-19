using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventaRepuestos.Entidades
{
    public class Categoria
    {
        private int _codigo ;
        private string _nombre;
        
        public Categoria(int codigo, string nombre)
        {
            _codigo = codigo;
            _nombre = nombre;
        }

        public int Codigo
        {
            get { return _codigo; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }


    }
}
