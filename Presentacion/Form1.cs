﻿using System;
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
    public partial class FormDgv : Form
    {
        private string IMAGEN_DEFAULT = @"https://i.ytimg.com/vi/-6vnomecItA/maxresdefault.jpg";
        
        public FormDgv()
        {
            InitializeComponent();
            cargarDgv();
        }

        private List<Articulo> listaArticulo;

        public void cargarDgv()
        {
            ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();
            try

            {
                listaArticulo = ArticuloNegocio.ArmarLista();
                dgvLista.RowHeadersVisible = false;
                dgvLista.DataSource = listaArticulo;

               
                dgvLista.Columns["Id"].Visible = false;
                dgvLista.Columns["Imagen"].Visible = false;

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());

            }
        }

        public void ImgRowSelection ()
        {

        }

        private void dgvLista_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void RecargarImg(string imagen = null)
        {
            try
            {
                pbxLista.Load(imagen);
            }
            catch (Exception)
            {
                pbxLista.Load(IMAGEN_DEFAULT);
            }
        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvLista.CurrentRow.DataBoundItem;



            RecargarImg(seleccionado.imagen);
        }

        private void pbxLista_Click(object sender, EventArgs e)
        {

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var algo = sender;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }
    }
}
