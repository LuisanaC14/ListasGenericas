namespace GestionCafeteriaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesarPedido_Click(object sender, EventArgs e)
        {
        if (pedidos.Count > 0)
            {
                Cafeteria procesado = pedidos[0];
                pedidos.RemoveAt(0);
                MessageBox.Show($"Pedido de {procesado.Cliente} procesado.");
                ActualizarListaPedidos();
            }
            else
            {
                MessageBox.Show("No hay pedidos para procesar.");
            }

        }

    }
}
