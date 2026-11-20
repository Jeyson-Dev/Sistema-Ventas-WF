namespace SistemaVentas
{
    partial class frmSistemaVentas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpDatosCliente = new GroupBox();
            txtCliente = new TextBox();
            lblCliente = new Label();
            lblHora = new Label();
            pnlFecha = new Panel();
            lblMostrarHora = new Label();
            lblMostrarFecha = new Label();
            lblFecha = new Label();
            grpDatosVenta = new GroupBox();
            txtCantidad = new TextBox();
            lblMostrarCantidad = new Label();
            lblCantidad = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lblMostrarPrecio = new Label();
            lblPrecio = new Label();
            cobProducto = new ComboBox();
            lblProducto = new Label();
            lvDetalles = new ListView();
            chProducto = new ColumnHeader();
            chCantidad = new ColumnHeader();
            chPrecio = new ColumnHeader();
            chSubtotal = new ColumnHeader();
            chDescuento = new ColumnHeader();
            chNeto = new ColumnHeader();
            lblTotalNeto = new Label();
            lblMostrarNeto = new Label();
            grpDatosCliente.SuspendLayout();
            pnlFecha.SuspendLayout();
            grpDatosVenta.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(344, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(392, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONTROL DE VENTA DE PRODUCTOS";
            // 
            // grpDatosCliente
            // 
            grpDatosCliente.BackColor = SystemColors.ControlLight;
            grpDatosCliente.Controls.Add(txtCliente);
            grpDatosCliente.Controls.Add(lblCliente);
            grpDatosCliente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosCliente.Location = new Point(30, 71);
            grpDatosCliente.Name = "grpDatosCliente";
            grpDatosCliente.Size = new Size(583, 138);
            grpDatosCliente.TabIndex = 1;
            grpDatosCliente.TabStop = false;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(35, 62);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Introduzca nombre del cliente";
            txtCliente.Size = new Size(526, 29);
            txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(35, 25);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(92, 22);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "CLIENTE";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(245, 29);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(65, 22);
            lblHora.TabIndex = 3;
            lblHora.Text = "HORA";
            // 
            // pnlFecha
            // 
            pnlFecha.BackColor = SystemColors.ControlLightLight;
            pnlFecha.BorderStyle = BorderStyle.Fixed3D;
            pnlFecha.Controls.Add(lblMostrarHora);
            pnlFecha.Controls.Add(lblMostrarFecha);
            pnlFecha.Controls.Add(lblFecha);
            pnlFecha.Controls.Add(lblHora);
            pnlFecha.Location = new Point(670, 71);
            pnlFecha.Name = "pnlFecha";
            pnlFecha.Size = new Size(372, 138);
            pnlFecha.TabIndex = 4;
            // 
            // lblMostrarHora
            // 
            lblMostrarHora.AutoSize = true;
            lblMostrarHora.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarHora.Location = new Point(226, 78);
            lblMostrarHora.Name = "lblMostrarHora";
            lblMostrarHora.Size = new Size(75, 22);
            lblMostrarHora.TabIndex = 5;
            lblMostrarHora.Text = "FECHA";
            // 
            // lblMostrarFecha
            // 
            lblMostrarFecha.AutoSize = true;
            lblMostrarFecha.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarFecha.Location = new Point(47, 78);
            lblMostrarFecha.Name = "lblMostrarFecha";
            lblMostrarFecha.Size = new Size(75, 22);
            lblMostrarFecha.TabIndex = 4;
            lblMostrarFecha.Text = "FECHA";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(60, 25);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(75, 22);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "FECHA";
            // 
            // grpDatosVenta
            // 
            grpDatosVenta.BackColor = SystemColors.ControlLight;
            grpDatosVenta.Controls.Add(txtCantidad);
            grpDatosVenta.Controls.Add(lblMostrarCantidad);
            grpDatosVenta.Controls.Add(lblCantidad);
            grpDatosVenta.Controls.Add(btnRegistrar);
            grpDatosVenta.Controls.Add(btnCancelar);
            grpDatosVenta.Controls.Add(lblMostrarPrecio);
            grpDatosVenta.Controls.Add(lblPrecio);
            grpDatosVenta.Controls.Add(cobProducto);
            grpDatosVenta.Controls.Add(lblProducto);
            grpDatosVenta.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosVenta.Location = new Point(31, 257);
            grpDatosVenta.Name = "grpDatosVenta";
            grpDatosVenta.Size = new Size(1012, 197);
            grpDatosVenta.TabIndex = 5;
            grpDatosVenta.TabStop = false;
            grpDatosVenta.Text = "Datos de la Venta";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(464, 91);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "0";
            txtCantidad.Size = new Size(109, 29);
            txtCantidad.TabIndex = 10;
            // 
            // lblMostrarCantidad
            // 
            lblMostrarCantidad.AutoSize = true;
            lblMostrarCantidad.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostrarCantidad.Location = new Point(499, 94);
            lblMostrarCantidad.Name = "lblMostrarCantidad";
            lblMostrarCantidad.Size = new Size(0, 22);
            lblMostrarCantidad.TabIndex = 9;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(464, 52);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(109, 22);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "CANTIDAD";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LightSteelBlue;
            btnRegistrar.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(736, 94);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(258, 76);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(736, 20);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(258, 76);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMostrarPrecio
            // 
            lblMostrarPrecio.AutoSize = true;
            lblMostrarPrecio.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostrarPrecio.Location = new Point(608, 94);
            lblMostrarPrecio.Name = "lblMostrarPrecio";
            lblMostrarPrecio.Size = new Size(83, 22);
            lblMostrarPrecio.TabIndex = 5;
            lblMostrarPrecio.Text = "PRECIO";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(608, 51);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(85, 22);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "PRECIO";
            // 
            // cobProducto
            // 
            cobProducto.FormattingEnabled = true;
            cobProducto.Location = new Point(35, 87);
            cobProducto.Name = "cobProducto";
            cobProducto.Size = new Size(382, 30);
            cobProducto.TabIndex = 2;
            cobProducto.SelectedIndexChanged += cobProducto_SelectedIndexChanged;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(35, 52);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(120, 22);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "PRODUCTO";
            // 
            // lvDetalles
            // 
            lvDetalles.Columns.AddRange(new ColumnHeader[] { chProducto, chCantidad, chPrecio, chSubtotal, chDescuento, chNeto });
            lvDetalles.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvDetalles.Location = new Point(30, 477);
            lvDetalles.Name = "lvDetalles";
            lvDetalles.Size = new Size(1013, 341);
            lvDetalles.TabIndex = 6;
            lvDetalles.UseCompatibleStateImageBehavior = false;
            lvDetalles.View = View.Details;
            // 
            // chProducto
            // 
            chProducto.Text = "PRODUCTO";
            chProducto.Width = 240;
            // 
            // chCantidad
            // 
            chCantidad.Text = "CANT.";
            chCantidad.Width = 90;
            // 
            // chPrecio
            // 
            chPrecio.Text = "PRECIO";
            chPrecio.Width = 180;
            // 
            // chSubtotal
            // 
            chSubtotal.Text = "SUBTOTAL";
            chSubtotal.Width = 180;
            // 
            // chDescuento
            // 
            chDescuento.Text = "DESCUENTO";
            chDescuento.Width = 140;
            // 
            // chNeto
            // 
            chNeto.Text = "NETO";
            chNeto.Width = 180;
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalNeto.Location = new Point(767, 834);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(134, 22);
            lblTotalNeto.TabIndex = 7;
            lblTotalNeto.Text = "TOTAL NETO:";
            // 
            // lblMostrarNeto
            // 
            lblMostrarNeto.AutoSize = true;
            lblMostrarNeto.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostrarNeto.Location = new Point(917, 834);
            lblMostrarNeto.Name = "lblMostrarNeto";
            lblMostrarNeto.Size = new Size(83, 22);
            lblMostrarNeto.TabIndex = 8;
            lblMostrarNeto.Text = "PRECIO";
            // 
            // frmSistemaVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 865);
            Controls.Add(lblMostrarNeto);
            Controls.Add(lblTotalNeto);
            Controls.Add(lvDetalles);
            Controls.Add(grpDatosVenta);
            Controls.Add(pnlFecha);
            Controls.Add(grpDatosCliente);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmSistemaVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ventas";
            Load += frmSistemaVentas_Load;
            grpDatosCliente.ResumeLayout(false);
            grpDatosCliente.PerformLayout();
            pnlFecha.ResumeLayout(false);
            pnlFecha.PerformLayout();
            grpDatosVenta.ResumeLayout(false);
            grpDatosVenta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpDatosCliente;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblHora;
        private Panel pnlFecha;
        private Label label2;
        private Label lblTotalNeto;
        private Label lblFecha;
        private GroupBox grpDatosVenta;
        private Label lblProducto;
        private Button btnCancelar;
        private Label lblMostrarPrecio;
        private Label lblPrecio;
        private ComboBox cobProducto;
        private Label lblMostrarHora;
        private Label lblMostrarFecha;
        private Button btnRegistrar;
        private ListView lvDetalles;
        private ColumnHeader chProducto;
        private ColumnHeader chCantidad;
        private ColumnHeader chPrecio;
        private ColumnHeader chSubtotal;
        private ColumnHeader chDescuento;
        private ColumnHeader chNeto;
        private Label lblMostrarNeto;
        private Label lblMostrarCantidad;
        private Label lblCantidad;
        private TextBox txtCantidad;
    }
}
