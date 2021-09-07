using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorProducto
    {

        AccesoBase ab = new AccesoBase("localhost", "root", "", "tienda2", 3306);
        public string Guardar(EntidadProducto producto)
        {
            return ab.Comando(string.Format("insert into pruducto values(null, '{0}','{1}','{2}')", producto._nombre, producto._descripcion, producto._precio));
        }
       

        public void Mostrar(System.Windows.Forms.DataGridView tabla, string dato)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from pruducto where nombre like '%{0}%' or descripcion like '%{0}%'", dato), "pruducto").Tables["pruducto"];
            tabla.AutoResizeColumns();
        }

        public string Editar(EntidadProducto producto)
        {
            return ab.Comando(string.Format("update pruducto set nombre = '{0}', descripcion = '{1}', precio = {2} where idproducto = {3}", producto._nombre,
                producto._descripcion, producto._precio, producto._idproducto));
        }
    }
}
