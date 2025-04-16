namespace InterfazGUI.Views
{
    partial class ClientesForm
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
            gridClientes = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            lblNombre = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblIdDireccion = new System.Windows.Forms.Label();
            txtNombre = new DevExpress.XtraEditors.TextEdit();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            txtIdDireccion = new DevExpress.XtraEditors.TextEdit();
            btnCargar = new System.Windows.Forms.Button();
            btnCrear = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNombre.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIdDireccion.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridClientes
            // 
            gridClientes.Location = new System.Drawing.Point(12, 170);
            gridClientes.MainView = gridView1;
            gridClientes.Name = "gridClientes";
            gridClientes.Size = new System.Drawing.Size(595, 322);
            gridClientes.TabIndex = 0;
            gridClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridClientes;
            gridView1.Name = "gridView1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(21, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 13);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(21, 45);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblIdDireccion
            // 
            lblIdDireccion.AutoSize = true;
            lblIdDireccion.Location = new System.Drawing.Point(21, 71);
            lblIdDireccion.Name = "lblIdDireccion";
            lblIdDireccion.Size = new System.Drawing.Size(54, 13);
            lblIdDireccion.TabIndex = 3;
            lblIdDireccion.Text = "Direccion:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(78, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(181, 20);
            txtNombre.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(78, 42);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(181, 20);
            txtEmail.TabIndex = 5;
            // 
            // txtIdDireccion
            // 
            txtIdDireccion.Location = new System.Drawing.Point(78, 68);
            txtIdDireccion.Name = "txtIdDireccion";
            txtIdDireccion.Size = new System.Drawing.Size(181, 20);
            txtIdDireccion.TabIndex = 6;
            // 
            // btnCargar
            // 
            btnCargar.Location = new System.Drawing.Point(21, 116);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new System.Drawing.Size(75, 23);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(102, 116);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(75, 23);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new System.Drawing.Point(183, 116);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(75, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(264, 116);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(619, 504);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(btnCargar);
            Controls.Add(txtIdDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(lblIdDireccion);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Controls.Add(gridClientes);
            Name = "ClientesForm";
            Text = "ClientesForm";
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNombre.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIdDireccion.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdDireccion;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtIdDireccion;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}