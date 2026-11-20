using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;


namespace Examen_CafeteriaYindri
{
    public partial class frmPedidos : Form
    {
        // ---------- Constantes de negocio ----------
        private const decimal RecargoTamanoGrande = 25m;
        private const decimal RecargoPorcionExtra = 30m;
        private const decimal TasaDescuentoFrecuente = 0.10m;
        private const decimal CostoEmpaque = 20m;
        private const decimal TasaItbis = 0.18m;

        // ---------- Anchos de columnas del ListBox ----------
        private const int AnchoCantidad = 6;
        private const int AnchoProducto = 24;
        private const int AnchoPrecio = 10;
        private const int AnchoTotal = 12;

        // ---------- Colores de la interfaz ----------
        private static readonly Color ColorMarino = Color.FromArgb(20, 33, 61);
        private static readonly Color ColorTeal = Color.FromArgb(0, 150, 136);
        private static readonly Color ColorFondo = Color.FromArgb(243, 244, 246);
        private static readonly Color ColorGris = Color.FromArgb(107, 114, 128);

        // Acumulador del subtotal del pedido
        private decimal subtotalPedido;

        public frmPedidos()
        {
            InitializeComponent();

            // Eventos (no hagas doble clic en los controles; ya quedan conectados aquí)
            Load += frmPedidos_Load;
            btnAgregar.Click += btnAgregar_Click;
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        // ================= EVENTOS =================

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            AplicarEstilo();
            lblEncabezado.Text = FormatearLinea("Cant", "Producto", "Precio", "Total");
            ReiniciarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text.Trim();

            if (producto.Length == 0)
            {
                MessageBox.Show("Digite el nombre del producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (!TryLeerPrecio(out decimal precioBase) || precioBase <= 0)
            {
                MessageBox.Show("Digite un precio válido mayor que cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                txtPrecio.SelectAll();
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            // Regla 1: precio unitario con recargos
            decimal precioUnitario = precioBase;
            if (rbtGrande.Checked) precioUnitario += RecargoTamanoGrande;
            if (chkPorcionExtra.Checked) precioUnitario += RecargoPorcionExtra;

            // Regla 2: total de línea y subtotal acumulado
            decimal totalLinea = precioUnitario * cantidad;
            subtotalPedido += totalLinea;

            string descripcion = ConstruirDescripcion(producto);
            lstPedido.Items.Add(FormatearLinea(
                cantidad.ToString(),
                descripcion,
                precioUnitario.ToString("F2", CultureInfo.InvariantCulture),
                totalLinea.ToString("F2", CultureInfo.InvariantCulture)));

            lblSubtotal.Text = FormatoMoneda(subtotalPedido);
            ReiniciarControlesProducto();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (subtotalPedido == 0)
            {
                MessageBox.Show("Agregue al menos un producto al pedido.", "Sin productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal descuento = chkFrecuente.Checked ? subtotalPedido * TasaDescuentoFrecuente : 0m;
            decimal empaque = rbtLlevar.Checked ? CostoEmpaque : 0m;
            decimal baseImponible = subtotalPedido - descuento + empaque;
            decimal itbis = Math.Round(baseImponible * TasaItbis, 2);
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = FormatoMoneda(subtotalPedido);
            lblDescuento.Text = FormatoMoneda(descuento);
            lblEmpaque.Text = FormatoMoneda(empaque);
            lblItbis.Text = FormatoMoneda(itbis);
            lblTotal.Text = FormatoMoneda(total);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        // ================= MÉTODOS AUXILIARES =================

        private void ReiniciarFormulario()
        {
            txtCliente.Clear();
            chkFrecuente.Checked = false;
            dtpFecha.Value = DateTime.Now;
            rbtLocal.Checked = true;

            ReiniciarControlesProducto();

            lstPedido.Items.Clear();
            subtotalPedido = 0m;

            lblSubtotal.Text = FormatoMoneda(0m);
            lblDescuento.Text = FormatoMoneda(0m);
            lblEmpaque.Text = FormatoMoneda(0m);
            lblItbis.Text = FormatoMoneda(0m);
            lblTotal.Text = FormatoMoneda(0m);

            txtCliente.Focus();
        }

        private void ReiniciarControlesProducto()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            chkPorcionExtra.Checked = false;
            txtProducto.Focus();
        }

        private bool TryLeerPrecio(out decimal precio)
        {
            string texto = txtPrecio.Text.Trim().Replace(',', '.');
            return decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out precio);
        }

        private string ConstruirDescripcion(string producto)
        {
            string detalle;

            if (rbtGrande.Checked && chkPorcionExtra.Checked) detalle = "Grande, Extra";
            else if (rbtGrande.Checked) detalle = "Grande";
            else if (chkPorcionExtra.Checked) detalle = "Extra";
            else detalle = "Normal";

            return $"{producto} ({detalle})";
        }

        private static string FormatearLinea(string cantidad, string producto, string precio, string total)
        {
            // Si el producto es muy largo, se recorta para no romper las columnas
            if (producto.Length > AnchoProducto - 1)
            {
                producto = producto.Substring(0, AnchoProducto - 1);
            }

            return cantidad.PadRight(AnchoCantidad)
                 + producto.PadRight(AnchoProducto)
                 + precio.PadLeft(AnchoPrecio)
                 + total.PadLeft(AnchoTotal);
        }

        private static string FormatoMoneda(decimal valor)
        {
            return "RD$ " + valor.ToString("N2", CultureInfo.InvariantCulture);
        }

        private void AplicarEstilo()
        {
            BackColor = ColorFondo;
            Font = new Font("Segoe UI", 10F);

            pnlTitulo.BackColor = ColorMarino;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);

            pnlDatos.BackColor = Color.White;
            pnlPedido.BackColor = Color.White;

            Font fuenteLista = new Font("Consolas", 10F);
            lblEncabezado.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblEncabezado.ForeColor = ColorMarino;
            lstPedido.Font = fuenteLista;

            foreach (Button boton in new[] { btnAgregar, btnCalcular, btnLimpiar, btnSalir })
            {
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 0;
                boton.BackColor = ColorTeal;
                boton.ForeColor = Color.White;
                boton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                boton.Cursor = Cursors.Hand;
            }

            btnSalir.BackColor = ColorGris;

            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = ColorTeal;
        }
    }
}
