using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            formPanel(new FormDgv());
            
        }

        private void formPanel(object FormH)
        {
           if (panelMenu.Controls.Count > 0)
              panelMenu.Controls.RemoveAt(0);
            Form fh = FormH as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(fh);
            panelMenu.Tag = fh;
            fh.Show();
        }


    }
}
