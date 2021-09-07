using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace Practica_8
{
    public partial class FrmAdd : Form
    {
        ManejadorProducto mp;
        public FrmAdd()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
            if (FrmPrincipal.producto._idproducto != 0)
            {
                txtNombre.Text = FrmPrincipal.producto._nombre;
                txtDes.Text = FrmPrincipal.producto._descripcion;
                txtPrecio.Text = FrmPrincipal.producto._precio.ToString();
            }
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            if (FrmPrincipal.producto._idproducto == 0)
            {
                MessageBox.Show(mp.Guardar(new EntidadProducto(FrmPrincipal.producto._idproducto, txtNombre.Text, txtDes.Text, double.Parse(txtPrecio.Text))));
                Close();
            }
            /*else
            {
                MessageBox.Show(mp.Editar(new EntidadProducto(FrmPrincipal.producto._idproducto, txtNombre.Text, txtDes.Text, double.Parse(txtPrecio.Text))));
            }*/
            Close();
        }
    }
}
