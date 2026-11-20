namespace SistemaVentas
{
    public partial class frmSistemaVentas : Form
    {
        public frmSistemaVentas()
        {
            InitializeComponent();
        }

        private void frmSistemaVentas_Load(object sender, EventArgs e)
        {
            MostrarFecha();
            MostrarHora();
            LimpiarCampo();
        }

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
    }
}
