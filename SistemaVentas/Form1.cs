namespace SistemaVentas
{
    public partial class frmSistemaVentas : Form
    {
        // Inicializar lista de productos
        static List<string> productos = new List<string>
        {
            "Teclado", "Impresora", "Monitor", "Bocinas", "Laptop HP", "Mouse"
        };

        Ventas venta = new Ventas();

        public frmSistemaVentas()
        {
            InitializeComponent();
        }

        private void frmSistemaVentas_Load(object sender, EventArgs e)
        {
            MostrarFecha();
            MostrarHora();
            LimpiarCampo();
            LlenarProducto();
            lblMostrarNeto.Text = "$0.00";
        }

        #region Configuraciones Inciales

        private void MostrarFecha()
        {
            lblMostrarFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void MostrarHora()
        {
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void LimpiarCampo()
        {
            txtCliente.Clear();
            cobProducto.Text = "Seleccione un producto";
            lblMostrarPrecio.Text = "$0.00";
            txtCantidad.Clear();
            txtCliente.Focus();
        }

        private void LlenarProducto()
        {
            foreach (var p in productos)
            {
                cobProducto.Items.Add(p);
            }
        }

        #endregion

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Enviar datos a la clase ventas
            venta.Producto = cobProducto.Text;
            venta.Cantidad = decimal.Parse(txtCantidad.Text);

            // Imprimir resultado
            ListViewItem fila = new ListViewItem(venta.Producto);
            fila.SubItems.Add(venta.Cantidad.ToString());
            fila.SubItems.Add(venta.AsignarPrecio().ToString("C"));
            fila.SubItems.Add(venta.CalcularSubtotal().ToString("C"));
            fila.SubItems.Add(venta.CalcularDescuento().ToString("C"));
            fila.SubItems.Add(venta.CalcularNeto().ToString("C"));

            lvDetalles.Items.Add(fila);

            // Suamndo campos
            decimal total = 0;
            total += venta.CalcularNeto();

            lblMostrarNeto.Text = total.ToString();

            LimpiarCampo();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea limpiar campos...?", "Ventas", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                LimpiarCampo();
            }
        }

        private void cobProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            venta.Producto = cobProducto.Text;
            lblMostrarPrecio.Text = venta.AsignarPrecio().ToString("C");
        }

        // Acumula totales

        
    }
}
