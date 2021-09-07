using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorProducto
    {

        AccesoBase ab = new AccesoBase("localhost", "root", "", "tienda2", 3306);
        public string Guardar(EntidadProducto producto)
        {
            return ab.Comando(string.Format("insert into pruducto values(null, '{0}','{1}','{2}')", producto._nombre, producto._descripcion, producto._precio));
        }
    }
}
