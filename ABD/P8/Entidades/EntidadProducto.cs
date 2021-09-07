using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadProducto
    {
        public EntidadProducto()
        {
        }

        public EntidadProducto(int idproducto, string nombre, string descripcion, double precio)
        {
            _idproducto = idproducto;
            _nombre = nombre;
            _descripcion = descripcion;
            _precio = precio;
        }

        public int _idproducto { get; set; }
        public string _nombre { get; set; }
        public string _descripcion { get; set; }
        public double _precio { get; set; }
    }
}
