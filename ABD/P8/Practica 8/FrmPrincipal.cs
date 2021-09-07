using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace Practica_8
{
    public partial class FrmPrincipal : Form
    {
        ManejadorProducto mp;
        public static EntidadProducto producto;
        public FrmPrincipal()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
            producto = new EntidadProducto();
        }
        void Actualizar()
        {
            //mp.Mostrar(dtgDatos, txtBuscar.Text);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto._idproducto = 0;
            producto._nombre = "";
            producto._descripcion = "";
            producto._precio = 0;
            FrmAdd fa = new FrmAdd();
            fa.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAdd fa = new FrmAdd();
            fa.ShowDialog();
        }
    }
}
