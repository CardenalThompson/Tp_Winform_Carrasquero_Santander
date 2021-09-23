
namespace Presentacion
{
    partial class FormDgv
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pbxLista = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLista.Location = new System.Drawing.Point(2, 44);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(786, 148);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            this.dgvLista.SelectionChanged += new System.EventHandler(this.dgvLista_SelectionChanged);
            this.dgvLista.MouseHover += new System.EventHandler(this.dgvLista_MouseHover);
            // 
            // pbxLista
            // 
            this.pbxLista.Location = new System.Drawing.Point(274, 198);
            this.pbxLista.Name = "pbxLista";
            this.pbxLista.Size = new System.Drawing.Size(274, 249);
            this.pbxLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLista.TabIndex = 1;
            this.pbxLista.TabStop = false;
            this.pbxLista.Click += new System.EventHandler(this.pbxLista_Click);
            this.pbxLista.Resize += new System.EventHandler(this.dgvLista_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar registro";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.Location = new System.Drawing.Point(12, 279);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(171, 39);
            this.btnDetalles.TabIndex = 3;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbBuscar.Location = new System.Drawing.Point(12, 10);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(383, 20);
            this.tbBuscar.TabIndex = 4;
            this.tbBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBuscar_KeyUp);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(417, 7);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(69, 23);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // FormDgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pbxLista);
            this.Controls.Add(this.dgvLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDgv";
            this.Text = "FormDgv";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.PictureBox pbxLista;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btBuscar;
    }
}