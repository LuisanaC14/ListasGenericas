namespace GestionCafeteriaWF
{
    partial class Form1
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
            lbPedidos = new Label();
            lbCliente = new Label();
            lbProducto = new Label();
            lbCantidad = new Label();
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            txtProducto = new TextBox();
            btnAgregarPedido = new Button();
            btnProcesarPedido = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbPedidos
            // 
            lbPedidos.AutoSize = true;
            lbPedidos.BackColor = SystemColors.ButtonShadow;
            lbPedidos.ForeColor = SystemColors.ActiveCaptionText;
            lbPedidos.Location = new Point(310, 60);
            lbPedidos.Name = "lbPedidos";
            lbPedidos.Size = new Size(157, 20);
            lbPedidos.TabIndex = 0;
            lbPedidos.Text = "GESTION DE PEDIDOS";
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.BackColor = SystemColors.ActiveCaption;
            lbCliente.Location = new Point(66, 120);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(142, 20);
            lbCliente.TabIndex = 1;
            lbCliente.Text = "Nombre del Cliente:";
            lbCliente.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbProducto
            // 
            lbProducto.AutoSize = true;
            lbProducto.BackColor = SystemColors.ActiveCaption;
            lbProducto.Location = new Point(66, 158);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(72, 20);
            lbProducto.TabIndex = 2;
            lbProducto.Text = "Producto:";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(66, 196);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(72, 20);
            lbCantidad.TabIndex = 3;
            lbCantidad.Text = "Cantidad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(261, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(261, 196);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 5;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(261, 158);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 6;
            // 
            // btnAgregarPedido
            // 
            btnAgregarPedido.Location = new Point(30, 297);
            btnAgregarPedido.Name = "btnAgregarPedido";
            btnAgregarPedido.Size = new Size(152, 29);
            btnAgregarPedido.TabIndex = 7;
            btnAgregarPedido.Text = "Agregar Pedido";
            btnAgregarPedido.UseVisualStyleBackColor = true;
            btnAgregarPedido.Click += btnAgregarPedido_Click;
            // 
            // btnProcesarPedido
            // 
            btnProcesarPedido.Location = new Point(256, 297);
            btnProcesarPedido.Name = "btnProcesarPedido";
            btnProcesarPedido.Size = new Size(146, 29);
            btnProcesarPedido.TabIndex = 8;
            btnProcesarPedido.Text = "Procesar Pedido";
            btnProcesarPedido.UseVisualStyleBackColor = true;
            btnProcesarPedido.Click += btnProcesarPedido_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(471, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnProcesarPedido);
            Controls.Add(btnAgregarPedido);
            Controls.Add(txtProducto);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Controls.Add(lbCantidad);
            Controls.Add(lbProducto);
            Controls.Add(lbCliente);
            Controls.Add(lbPedidos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPedidos;
        private Label lbCliente;
        private Label lbProducto;
        private Label lbCantidad;
        private TextBox txtNombre;
        private TextBox txtCantidad;
        private TextBox txtProducto;
        private Button btnAgregarPedido;
        private Button btnProcesarPedido;
        private DataGridView dataGridView1;
    }
}
