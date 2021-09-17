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
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form menuP = new menuPrincipal() as Form;
            menuP.Show();
            this.Hide();
            //Application.Run(new menuPrincipal());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

            if (txtnombre.Text != string.Empty)
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
            //if (txtnombre.Text.Trim() != String.Empty && txtnombre.Text.All(char.IsLetter)) // si no esta vacio y todas son letras
            //{
            //    btnIngresar.Enabled = true;
            //    errorProvider1.SetError(tbnombre, "");
            //}
            //else
            //{
            //    if (!(txtnombre.Text.All(char.IsLetter)))   // si no son todas letras
            //    {
            //        errorProvider1.SetError(txtnombre, "el nombre solo debe contener letras");
            //    }
            //    else
            //    {
            //        errorProvider1.SetError(txtnombre, "tiene que ingresar un nombre");
            //    }
            //    btnIngresar.Enabled = false;
            //}
        }

   

    }
}
