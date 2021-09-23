using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class FormBusqueda : Form
    {

        private List<Articulo> listaArticulo;
        public FormBusqueda()
        {
            InitializeComponent();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbBuscador_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscador.Text != string.Empty)
            {
                btnIr.Enabled = true;
            }
            else
            {
                btnIr.Enabled = false;
            }
        }


        private void btnIr_Click(object sender, EventArgs e)
        {
           
            ArticuloNegocio arti = new ArticuloNegocio();
            if (cbDescripcion.Checked)
            {
                cargarDgv(tbBuscador.Text, cbDescripcion.Text);
            } else if(cbNombre.Checked)
            {
                cargarDgv(tbBuscador.Text, cbNombre.Text);
            }            
         
        }

        public void cargarDgv(string desc, string criterio)
        {
            ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();
            try

            {
                MessageBox.Show(criterio);

                if (criterio.Equals(cbDescripcion.Text))
                {
                    listaArticulo = ArticuloNegocio.buscarDesc(desc);
                }
                else 
                {
                    listaArticulo = ArticuloNegocio.buscarNombre(desc);
                }

                dgvBuscar.RowHeadersVisible = false;
                dgvBuscar.DataSource = listaArticulo;

                dgvBuscar.Columns["Id"].Visible = false;
                dgvBuscar.Columns["Imagen"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        public void cargarDgv(int _id)
        {
            ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();
            try

            {
                listaArticulo = ArticuloNegocio.buscarID(_id);
                dgvBuscar.RowHeadersVisible = false;
                dgvBuscar.DataSource = listaArticulo;


                dgvBuscar.Columns["Id"].Visible = false;
                dgvBuscar.Columns["Imagen"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

    }
}