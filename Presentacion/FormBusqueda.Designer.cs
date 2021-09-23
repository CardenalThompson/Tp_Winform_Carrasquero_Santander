
namespace Presentacion
{
    partial class FormBusqueda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.cbDescripcion = new System.Windows.Forms.CheckBox();
            this.cbNombre = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBuscador
            // 
            this.tbBuscador.Location = new System.Drawing.Point(559, 17);
            this.tbBuscador.Name = "tbBuscador";
            this.tbBuscador.Size = new System.Drawing.Size(166, 20);
            this.tbBuscador.TabIndex = 8;
            this.tbBuscador.TextChanged += new System.EventHandler(this.tbBuscador_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 17);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(210, 22);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Criterio de Busqueda";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(11, 391);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(156, 47);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnIr
            // 
            this.btnIr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIr.Location = new System.Drawing.Point(731, 12);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(57, 33);
            this.btnIr.TabIndex = 17;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = false;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(11, 61);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(777, 301);
            this.dgvBuscar.TabIndex = 18;
            // 
            // cbDescripcion
            // 
            this.cbDescripcion.AutoSize = true;
            this.cbDescripcion.Location = new System.Drawing.Point(337, 20);
            this.cbDescripcion.Name = "cbDescripcion";
            this.cbDescripcion.Size = new System.Drawing.Size(82, 17);
            this.cbDescripcion.TabIndex = 19;
            this.cbDescripcion.Text = "Descripcion";
            this.cbDescripcion.UseVisualStyleBackColor = true;
            // 
            // cbNombre
            // 
            this.cbNombre.AutoSize = true;
            this.cbNombre.Location = new System.Drawing.Point(246, 20);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(63, 17);
            this.cbNombre.TabIndex = 20;
            this.cbNombre.Text = "Nombre";
            this.cbNombre.UseVisualStyleBackColor = true;
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.cbDescripcion);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.tbBuscador);
            this.Name = "FormBusqueda";
            this.Text = "FormBusqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.CheckBox cbDescripcion;
        private System.Windows.Forms.CheckBox cbNombre;
    }
}