namespace Capa_Presentacion
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Colaborador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantidadP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrid_ClienteVenta = new System.Windows.Forms.DataGridView();
            this.txt_buscarClienteVenta = new System.Windows.Forms.TextBox();
            this.btnBuscarClienteVenta = new System.Windows.Forms.PictureBox();
            this.dataGrid_Venta = new System.Windows.Forms.DataGridView();
            this.dataGrid_DetalleVenta = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGrid_Almacen = new System.Windows.Forms.DataGridView();
            this.btn_registrarVenta = new System.Windows.Forms.Button();
            this.btn_editarVenta = new System.Windows.Forms.Button();
            this.btn_actualizarVenta = new System.Windows.Forms.Button();
            this.btn_eliminarVenta = new System.Windows.Forms.Button();
            this.btn_limpiarVenta = new System.Windows.Forms.Button();
            this.dateTimeP_Venta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarVenta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ClienteVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarClienteVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Almacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Registro Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Colaborador:";
            // 
            // cmb_Colaborador
            // 
            this.cmb_Colaborador.FormattingEnabled = true;
            this.cmb_Colaborador.Location = new System.Drawing.Point(138, 79);
            this.cmb_Colaborador.Name = "cmb_Colaborador";
            this.cmb_Colaborador.Size = new System.Drawing.Size(158, 21);
            this.cmb_Colaborador.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Producto:";
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(138, 119);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.Size = new System.Drawing.Size(158, 21);
            this.cmb_Producto.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cantidad";
            // 
            // txt_cantidadP
            // 
            this.txt_cantidadP.Location = new System.Drawing.Point(138, 159);
            this.txt_cantidadP.MaxLength = 8;
            this.txt_cantidadP.Name = "txt_cantidadP";
            this.txt_cantidadP.Size = new System.Drawing.Size(158, 20);
            this.txt_cantidadP.TabIndex = 45;
            this.txt_cantidadP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "Venta";
            // 
            // dataGrid_ClienteVenta
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_ClienteVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_ClienteVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ClienteVenta.Location = new System.Drawing.Point(10, 242);
            this.dataGrid_ClienteVenta.Name = "dataGrid_ClienteVenta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGrid_ClienteVenta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_ClienteVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_ClienteVenta.Size = new System.Drawing.Size(544, 112);
            this.dataGrid_ClienteVenta.TabIndex = 48;
            this.dataGrid_ClienteVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_ClienteVenta_CellContentClick);
            // 
            // txt_buscarClienteVenta
            // 
            this.txt_buscarClienteVenta.Location = new System.Drawing.Point(138, 206);
            this.txt_buscarClienteVenta.MaxLength = 15;
            this.txt_buscarClienteVenta.Name = "txt_buscarClienteVenta";
            this.txt_buscarClienteVenta.Size = new System.Drawing.Size(158, 20);
            this.txt_buscarClienteVenta.TabIndex = 49;
            this.txt_buscarClienteVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_buscarClienteVenta.TextChanged += new System.EventHandler(this.txt_buscarClienteVenta_TextChanged);
            // 
            // btnBuscarClienteVenta
            // 
            this.btnBuscarClienteVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarClienteVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClienteVenta.Image")));
            this.btnBuscarClienteVenta.Location = new System.Drawing.Point(328, 180);
            this.btnBuscarClienteVenta.Name = "btnBuscarClienteVenta";
            this.btnBuscarClienteVenta.Size = new System.Drawing.Size(56, 53);
            this.btnBuscarClienteVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarClienteVenta.TabIndex = 54;
            this.btnBuscarClienteVenta.TabStop = false;
            // 
            // dataGrid_Venta
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Venta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Venta.Location = new System.Drawing.Point(10, 411);
            this.dataGrid_Venta.Name = "dataGrid_Venta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGrid_Venta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Venta.Size = new System.Drawing.Size(544, 147);
            this.dataGrid_Venta.TabIndex = 55;
            this.dataGrid_Venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Venta_CellContentClick);
            // 
            // dataGrid_DetalleVenta
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_DetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_DetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DetalleVenta.Location = new System.Drawing.Point(10, 603);
            this.dataGrid_DetalleVenta.Name = "dataGrid_DetalleVenta";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGrid_DetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_DetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_DetalleVenta.Size = new System.Drawing.Size(445, 69);
            this.dataGrid_DetalleVenta.TabIndex = 57;
            this.dataGrid_DetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DetalleVenta_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 56;
            this.label5.Text = "Detalle Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(625, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 58;
            this.label6.Text = "Almacén";
            // 
            // dataGrid_Almacen
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Almacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_Almacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Almacen.Location = new System.Drawing.Point(454, 83);
            this.dataGrid_Almacen.Name = "dataGrid_Almacen";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGrid_Almacen.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_Almacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Almacen.Size = new System.Drawing.Size(365, 153);
            this.dataGrid_Almacen.TabIndex = 59;
            // 
            // btn_registrarVenta
            // 
            this.btn_registrarVenta.BackColor = System.Drawing.Color.White;
            this.btn_registrarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarVenta.Location = new System.Drawing.Point(692, 256);
            this.btn_registrarVenta.Name = "btn_registrarVenta";
            this.btn_registrarVenta.Size = new System.Drawing.Size(109, 34);
            this.btn_registrarVenta.TabIndex = 60;
            this.btn_registrarVenta.Text = "Registrar";
            this.btn_registrarVenta.UseVisualStyleBackColor = false;
            this.btn_registrarVenta.Click += new System.EventHandler(this.btn_registrarVenta_Click);
            // 
            // btn_editarVenta
            // 
            this.btn_editarVenta.BackColor = System.Drawing.Color.White;
            this.btn_editarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarVenta.Location = new System.Drawing.Point(569, 303);
            this.btn_editarVenta.Name = "btn_editarVenta";
            this.btn_editarVenta.Size = new System.Drawing.Size(109, 34);
            this.btn_editarVenta.TabIndex = 61;
            this.btn_editarVenta.Text = "Editar";
            this.btn_editarVenta.UseVisualStyleBackColor = false;
            this.btn_editarVenta.Click += new System.EventHandler(this.btn_editarVenta_Click);
            // 
            // btn_actualizarVenta
            // 
            this.btn_actualizarVenta.BackColor = System.Drawing.Color.White;
            this.btn_actualizarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarVenta.Location = new System.Drawing.Point(692, 303);
            this.btn_actualizarVenta.Name = "btn_actualizarVenta";
            this.btn_actualizarVenta.Size = new System.Drawing.Size(109, 34);
            this.btn_actualizarVenta.TabIndex = 62;
            this.btn_actualizarVenta.Text = "Actualizar";
            this.btn_actualizarVenta.UseVisualStyleBackColor = false;
            this.btn_actualizarVenta.Visible = false;
            this.btn_actualizarVenta.Click += new System.EventHandler(this.btn_actualizarVenta_Click);
            // 
            // btn_eliminarVenta
            // 
            this.btn_eliminarVenta.BackColor = System.Drawing.Color.White;
            this.btn_eliminarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarVenta.Location = new System.Drawing.Point(569, 353);
            this.btn_eliminarVenta.Name = "btn_eliminarVenta";
            this.btn_eliminarVenta.Size = new System.Drawing.Size(109, 34);
            this.btn_eliminarVenta.TabIndex = 63;
            this.btn_eliminarVenta.Text = "Eliminar";
            this.btn_eliminarVenta.UseVisualStyleBackColor = false;
            this.btn_eliminarVenta.Click += new System.EventHandler(this.btn_eliminarVenta_Click);
            // 
            // btn_limpiarVenta
            // 
            this.btn_limpiarVenta.BackColor = System.Drawing.Color.White;
            this.btn_limpiarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiarVenta.Location = new System.Drawing.Point(692, 353);
            this.btn_limpiarVenta.Name = "btn_limpiarVenta";
            this.btn_limpiarVenta.Size = new System.Drawing.Size(109, 34);
            this.btn_limpiarVenta.TabIndex = 64;
            this.btn_limpiarVenta.Text = "Limpiar";
            this.btn_limpiarVenta.UseVisualStyleBackColor = false;
            this.btn_limpiarVenta.Click += new System.EventHandler(this.btn_limpiarVenta_Click);
            // 
            // dateTimeP_Venta
            // 
            this.dateTimeP_Venta.Location = new System.Drawing.Point(569, 465);
            this.dateTimeP_Venta.Name = "dateTimeP_Venta";
            this.dateTimeP_Venta.Size = new System.Drawing.Size(200, 20);
            this.dateTimeP_Venta.TabIndex = 66;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarVenta.Image")));
            this.btnBuscarVenta.Location = new System.Drawing.Point(775, 446);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(56, 53);
            this.btnBuscarVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarVenta.TabIndex = 65;
            this.btnBuscarVenta.TabStop = false;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(840, 681);
            this.Controls.Add(this.dateTimeP_Venta);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.btn_limpiarVenta);
            this.Controls.Add(this.btn_eliminarVenta);
            this.Controls.Add(this.btn_actualizarVenta);
            this.Controls.Add(this.btn_editarVenta);
            this.Controls.Add(this.btn_registrarVenta);
            this.Controls.Add(this.dataGrid_Almacen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGrid_DetalleVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGrid_Venta);
            this.Controls.Add(this.btnBuscarClienteVenta);
            this.Controls.Add(this.txt_buscarClienteVenta);
            this.Controls.Add(this.dataGrid_ClienteVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cantidadP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Colaborador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Producto);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ClienteVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarClienteVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Almacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Colaborador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidadP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGrid_ClienteVenta;
        private System.Windows.Forms.TextBox txt_buscarClienteVenta;
        private System.Windows.Forms.PictureBox btnBuscarClienteVenta;
        private System.Windows.Forms.DataGridView dataGrid_Venta;
        private System.Windows.Forms.DataGridView dataGrid_DetalleVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGrid_Almacen;
        private System.Windows.Forms.Button btn_registrarVenta;
        private System.Windows.Forms.Button btn_editarVenta;
        private System.Windows.Forms.Button btn_actualizarVenta;
        private System.Windows.Forms.Button btn_eliminarVenta;
        private System.Windows.Forms.Button btn_limpiarVenta;
        private System.Windows.Forms.DateTimePicker dateTimeP_Venta;
        private System.Windows.Forms.PictureBox btnBuscarVenta;
    }
}