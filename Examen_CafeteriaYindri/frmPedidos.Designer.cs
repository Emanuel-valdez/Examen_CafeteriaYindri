namespace Examen_CafeteriaYindri
{
    partial class frmPedidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTitulo = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlDatos = new Panel();
            lblCliente = new Label();
            txtCliente = new TextBox();
            chkFrecuente = new CheckBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblProducto = new Label();
            txtProducto = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            gbTamano = new GroupBox();
            rbtNormal = new RadioButton();
            rbtGrande = new RadioButton();
            gbServicio = new GroupBox();
            rbtLocal = new RadioButton();
            rbtLlevar = new RadioButton();
            chkPorcionExtra = new CheckBox();
            btnAgregar = new Button();
            pnlPedido = new Panel();
            lblEncabezado = new Label();
            lstPedido = new ListBox();
            lblTextoSubtotal = new Label();
            lblTextoDescuento = new Label();
            lblTextoEmpaque = new Label();
            lblTextoItbis = new Label();
            lblTextoTotal = new Label();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblEmpaque = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            gbTamano.SuspendLayout();
            gbServicio.SuspendLayout();
            pnlPedido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(0, 80, 200);
            pnlTitulo.Controls.Add(pictureBox1);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1440, 163);
            pnlTitulo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1440, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Stencil", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Location = new Point(738, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(521, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cafetería El Buen Sabor – Pedidos";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = SystemColors.ButtonHighlight;
            pnlDatos.Controls.Add(lblCliente);
            pnlDatos.Controls.Add(txtCliente);
            pnlDatos.Controls.Add(chkFrecuente);
            pnlDatos.Controls.Add(lblFecha);
            pnlDatos.Controls.Add(dtpFecha);
            pnlDatos.Controls.Add(lblProducto);
            pnlDatos.Controls.Add(txtProducto);
            pnlDatos.Controls.Add(lblPrecio);
            pnlDatos.Controls.Add(txtPrecio);
            pnlDatos.Controls.Add(lblCantidad);
            pnlDatos.Controls.Add(nudCantidad);
            pnlDatos.Controls.Add(gbTamano);
            pnlDatos.Controls.Add(gbServicio);
            pnlDatos.Controls.Add(chkPorcionExtra);
            pnlDatos.Controls.Add(btnAgregar);
            pnlDatos.Location = new Point(57, 200);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(622, 521);
            pnlDatos.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(20, 24);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(76, 28);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(120, 18);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(309, 34);
            txtCliente.TabIndex = 1;
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Location = new Point(110, 56);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(184, 32);
            chkFrecuente.TabIndex = 2;
            chkFrecuente.Text = "Cliente frecuente";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(20, 98);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 28);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(120, 92);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(309, 34);
            dtpFecha.TabIndex = 4;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(20, 138);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(97, 28);
            lblProducto.TabIndex = 5;
            lblProducto.Text = "Producto:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(120, 135);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(309, 34);
            txtProducto.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(20, 178);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(70, 28);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(120, 172);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(309, 34);
            txtPrecio.TabIndex = 8;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(20, 218);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(95, 28);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(121, 215);
            nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(80, 34);
            nudCantidad.TabIndex = 10;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gbTamano
            // 
            gbTamano.Controls.Add(rbtNormal);
            gbTamano.Controls.Add(rbtGrande);
            gbTamano.Location = new Point(20, 255);
            gbTamano.Name = "gbTamano";
            gbTamano.Size = new Size(222, 90);
            gbTamano.TabIndex = 11;
            gbTamano.TabStop = false;
            gbTamano.Text = "Tamaño";
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Checked = true;
            rbtNormal.Location = new Point(15, 28);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(103, 32);
            rbtNormal.TabIndex = 0;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(15, 58);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(191, 32);
            rbtGrande.TabIndex = 1;
            rbtGrande.Text = "Grande (+RD$25)";
            // 
            // gbServicio
            // 
            gbServicio.Controls.Add(rbtLocal);
            gbServicio.Controls.Add(rbtLlevar);
            gbServicio.Location = new Point(263, 255);
            gbServicio.Name = "gbServicio";
            gbServicio.Size = new Size(239, 97);
            gbServicio.TabIndex = 12;
            gbServicio.TabStop = false;
            gbServicio.Text = "Servicio";
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Checked = true;
            rbtLocal.Location = new Point(15, 29);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(192, 32);
            rbtLocal.TabIndex = 0;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "Consumir en local";
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(15, 58);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(216, 32);
            rbtLlevar.TabIndex = 1;
            rbtLlevar.Text = "Para llevar (+RD$20)";
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Location = new Point(20, 358);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(242, 32);
            chkPorcionExtra.TabIndex = 13;
            chkPorcionExtra.Text = "Porción extra (+RD$30)";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(20, 405);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(360, 40);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar al pedido";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // pnlPedido
            // 
            pnlPedido.BackColor = SystemColors.ButtonHighlight;
            pnlPedido.Controls.Add(lblEncabezado);
            pnlPedido.Controls.Add(lstPedido);
            pnlPedido.Controls.Add(lblTextoSubtotal);
            pnlPedido.Controls.Add(lblTextoDescuento);
            pnlPedido.Controls.Add(lblTextoEmpaque);
            pnlPedido.Controls.Add(lblTextoItbis);
            pnlPedido.Controls.Add(lblTextoTotal);
            pnlPedido.Controls.Add(lblSubtotal);
            pnlPedido.Controls.Add(lblDescuento);
            pnlPedido.Controls.Add(lblEmpaque);
            pnlPedido.Controls.Add(lblItbis);
            pnlPedido.Controls.Add(lblTotal);
            pnlPedido.Controls.Add(btnCalcular);
            pnlPedido.Controls.Add(btnLimpiar);
            pnlPedido.Controls.Add(btnSalir);
            pnlPedido.Location = new Point(685, 200);
            pnlPedido.Name = "pnlPedido";
            pnlPedido.Size = new Size(704, 521);
            pnlPedido.TabIndex = 0;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(15, 15);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(139, 28);
            lblEncabezado.TabIndex = 0;
            lblEncabezado.Text = "lblEncabezado";
            // 
            // lstPedido
            // 
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(15, 40);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(672, 144);
            lstPedido.TabIndex = 1;
            // 
            // lblTextoSubtotal
            // 
            lblTextoSubtotal.AutoSize = true;
            lblTextoSubtotal.Location = new Point(13, 229);
            lblTextoSubtotal.Name = "lblTextoSubtotal";
            lblTextoSubtotal.Size = new Size(87, 28);
            lblTextoSubtotal.TabIndex = 2;
            lblTextoSubtotal.Text = "Subtotal";
            // 
            // lblTextoDescuento
            // 
            lblTextoDescuento.AutoSize = true;
            lblTextoDescuento.Location = new Point(13, 259);
            lblTextoDescuento.Name = "lblTextoDescuento";
            lblTextoDescuento.Size = new Size(104, 28);
            lblTextoDescuento.TabIndex = 3;
            lblTextoDescuento.Text = "Descuento";
            // 
            // lblTextoEmpaque
            // 
            lblTextoEmpaque.AutoSize = true;
            lblTextoEmpaque.Location = new Point(13, 289);
            lblTextoEmpaque.Name = "lblTextoEmpaque";
            lblTextoEmpaque.Size = new Size(94, 28);
            lblTextoEmpaque.TabIndex = 4;
            lblTextoEmpaque.Text = "Empaque";
            // 
            // lblTextoItbis
            // 
            lblTextoItbis.AutoSize = true;
            lblTextoItbis.Location = new Point(13, 319);
            lblTextoItbis.Name = "lblTextoItbis";
            lblTextoItbis.Size = new Size(114, 28);
            lblTextoItbis.TabIndex = 5;
            lblTextoItbis.Text = "ITBIS (18 %)";
            // 
            // lblTextoTotal
            // 
            lblTextoTotal.AutoSize = true;
            lblTextoTotal.Location = new Point(13, 361);
            lblTextoTotal.Name = "lblTextoTotal";
            lblTextoTotal.Size = new Size(151, 28);
            lblTextoTotal.TabIndex = 6;
            lblTextoTotal.Text = "TOTAL A PAGAR";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(213, 225);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(200, 26);
            lblSubtotal.TabIndex = 7;
            lblSubtotal.Text = "RD$ 0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(213, 255);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(200, 26);
            lblDescuento.TabIndex = 8;
            lblDescuento.Text = "RD$ 0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmpaque
            // 
            lblEmpaque.Location = new Point(213, 285);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(200, 26);
            lblEmpaque.TabIndex = 9;
            lblEmpaque.Text = "RD$ 0.00";
            lblEmpaque.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItbis
            // 
            lblItbis.Location = new Point(213, 315);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(200, 26);
            lblItbis.TabIndex = 10;
            lblItbis.Text = "RD$ 0.00";
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(213, 355);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(200, 32);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "RD$ 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(14, 405);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 40);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(149, 405);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 40);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Nuevo pedido";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(284, 405);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 40);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 625);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1430, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 625);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 32, 40);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 775);
            panel3.Name = "panel3";
            panel3.Size = new Size(1420, 13);
            panel3.TabIndex = 5;
            // 
            // frmPedidos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1440, 788);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlPedido);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafetería El Buen Sabor – Pedidos";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            gbTamano.ResumeLayout(false);
            gbTamano.PerformLayout();
            gbServicio.ResumeLayout(false);
            gbServicio.PerformLayout();
            pnlPedido.ResumeLayout(false);
            pnlPedido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox chkFrecuente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.GroupBox gbTamano;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtGrande;
        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.RadioButton rbtLocal;
        private System.Windows.Forms.RadioButton rbtLlevar;
        private System.Windows.Forms.CheckBox chkPorcionExtra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Label lblTextoSubtotal;
        private System.Windows.Forms.Label lblTextoDescuento;
        private System.Windows.Forms.Label lblTextoEmpaque;
        private System.Windows.Forms.Label lblTextoItbis;
        private System.Windows.Forms.Label lblTextoTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblEmpaque;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
    }
}
