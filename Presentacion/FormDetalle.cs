using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{

    public partial class FormDetalle : Form
    {
        Articulo _arti = new Articulo();

        public FormDetalle(Articulo articulo)
        {
            InitializeComponent();
            _arti = articulo;
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                lbCodigo.Text = _arti.codigo;
                lbNombre.Text = _arti.nombre;
                lbDescripcion.Text = _arti.descripcion;
                lbMarca.Text = _arti.marca.nombre;
                lbCategoria.Text = _arti.categoria.nombre;
                lbPrecio.Text = Convert.ToString(_arti.precio);
                pbImagen.Load(_arti.imagen); 
            }
            catch
            {
                pbImagen.Load("https://i.ytimg.com/vi/-6vnomecItA/maxresdefault.jpg");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormUpdate editar = new FormUpdate(_arti);
            editar.ShowDialog();
            this.Close();
        }
    }
}
