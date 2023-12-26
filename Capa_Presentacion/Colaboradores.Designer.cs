namespace Capa_Presentacion
{
    partial class Colaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colaboradores));
            this.dataGrid_Colaboradores = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipoGenero = new System.Windows.Forms.ComboBox();
            this.txt_apellidosColaborador = new System.Windows.Forms.TextBox();
            this.txt_nombresColaborador = new System.Windows.Forms.TextBox();
            this.txt_nroDocColaborador = new System.Windows.Forms.TextBox();
            this.cmb_tipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_salarioColaborador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_cargoColaborador = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_direccionColaborador = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_celularColaborador = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_fijoColaborador = new System.Windows.Forms.TextBox();
            this.btn_listarColaboradores = new System.Windows.Forms.Button();
            this.btn_actualizarColaborador = new System.Windows.Forms.Button();
            this.btn_eliminarColaborador = new System.Windows.Forms.Button();
            this.btn_limpiarColaborador = new System.Windows.Forms.Button();
            this.btn_editarColaborador = new System.Windows.Forms.Button();
            this.btn_registrarColaborador = new System.Windows.Forms.Button();
            this.txt_buscarColaborador = new System.Windows.Forms.TextBox();
            this.btnBuscarColaborador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Colaboradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Colaboradores
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Colaboradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Colaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Colaboradores.Location = new System.Drawing.Point(13, 394);
            this.dataGrid_Colaboradores.Name = "dataGrid_Colaboradores";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGrid_Colaboradores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Colaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Colaboradores.Size = new System.Drawing.Size(827, 255);
            this.dataGrid_Colaboradores.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "Registro Colaborador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(328, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(328, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(328, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "N° Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tipo Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(575, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Salario:";
            // 
            // cmb_tipoGenero
            // 
            this.cmb_tipoGenero.FormattingEnabled = true;
            this.cmb_tipoGenero.Location = new System.Drawing.Point(410, 105);
            this.cmb_tipoGenero.Name = "cmb_tipoGenero";
            this.cmb_tipoGenero.Size = new System.Drawing.Size(130, 21);
            this.cmb_tipoGenero.TabIndex = 4;
            // 
            // txt_apellidosColaborador
            // 
            this.txt_apellidosColaborador.Location = new System.Drawing.Point(410, 185);
            this.txt_apellidosColaborador.MaxLength = 20;
            this.txt_apellidosColaborador.Name = "txt_apellidosColaborador";
            this.txt_apellidosColaborador.Size = new System.Drawing.Size(130, 20);
            this.txt_apellidosColaborador.TabIndex = 6;
            this.txt_apellidosColaborador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombresColaborador
            // 
            this.txt_nombresColaborador.Location = new System.Drawing.Point(410, 144);
            this.txt_nombresColaborador.MaxLength = 20;
            this.txt_nombresColaborador.Name = "txt_nombresColaborador";
            this.txt_nombresColaborador.Size = new System.Drawing.Size(130, 20);
            this.txt_nombresColaborador.TabIndex = 5;
            this.txt_nombresColaborador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nroDocColaborador
            // 
            this.txt_nroDocColaborador.Location = new System.Drawing.Point(174, 186);
            this.txt_nroDocColaborador.MaxLength = 8;
            this.txt_nroDocColaborador.Name = "txt_nroDocColaborador";
            this.txt_nroDocColaborador.Size = new System.Drawing.Size(121, 20);
            this.txt_nroDocColaborador.TabIndex = 3;
            this.txt_nroDocColaborador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(174, 144);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipoDoc.TabIndex = 2;
            // 
            // txt_salarioColaborador
            // 
            this.txt_salarioColaborador.Location = new System.Drawing.Point(657, 226);
            this.txt_salarioColaborador.MaxLength = 8;
            this.txt_salarioColaborador.Name = "txt_salarioColaborador";
            this.txt_salarioColaborador.Size = new System.Drawing.Size(100, 20);
            this.txt_salarioColaborador.TabIndex = 10;
            this.txt_salarioColaborador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(43, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Cargo Colaborador:";
            // 
            // cmb_cargoColaborador
            // 
            this.cmb_cargoColaborador.FormattingEnabled = true;
            this.cmb_cargoColaborador.Location = new System.Drawing.Point(174, 107);
            this.cmb_cargoColaborador.Name = "cmb_cargoColaborador";
            this.cmb_cargoColaborador.Size = new System.Drawing.Size(121, 21);
            this.cmb_cargoColaborador.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(575, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Direccion:";
            // 
            // txt_direccionColaborador
            // 
            this.txt_direccionColaborador.Location = new System.Drawing.Point(657, 104);
            this.txt_direccionColaborador.MaxLength = 40;
            this.txt_direccionColaborador.Name = "txt_direccionColaborador";
            this.txt_direccionColaborador.Size = new System.Drawing.Size(151, 20);
            this.txt_direccionColaborador.TabIndex = 7;
            this.txt_direccionColaborador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(575, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Celular:";
            // 
            // txt_celularColaborador
            // 
            this.txt_celularColaborador.Location = new System.Drawing.Point(657, 145);
            this.txt_celularColaborador.MaxLength = 9;
            this.txt_celularColaborador.Name = "txt_celularColaborador";
            this.txt_celularColaborador.Size = new System.Drawing.Size(100, 20);
            this.txt_celularColaborador.TabIndex = 8;
            this.txt_celularColaborador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(575, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Fijo:";
            // 
            // txt_fijoColaborador
            // 
            this.txt_fijoColaborador.Location = new System.Drawing.Point(657, 185);
            this.txt_fijoColaborador.MaxLength = 8;
            this.txt_fijoColaborador.Name = "txt_fijoColaborador";
            this.txt_fijoColaborador.Size = new System.Drawing.Size(100, 20);
            this.txt_fijoColaborador.TabIndex = 9;
            this.txt_fijoColaborador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_listarColaboradores
            // 
            this.btn_listarColaboradores.BackColor = System.Drawing.Color.White;
            this.btn_listarColaboradores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarColaboradores.Location = new System.Drawing.Point(46, 348);
            this.btn_listarColaboradores.Name = "btn_listarColaboradores";
            this.btn_listarColaboradores.Size = new System.Drawing.Size(180, 36);
            this.btn_listarColaboradores.TabIndex = 24;
            this.btn_listarColaboradores.Text = "Listar Colaboradores";
            this.btn_listarColaboradores.UseVisualStyleBackColor = false;
            this.btn_listarColaboradores.Click += new System.EventHandler(this.btn_listarColaboradores_Click);
            // 
            // btn_actualizarColaborador
            // 
            this.btn_actualizarColaborador.BackColor = System.Drawing.Color.White;
            this.btn_actualizarColaborador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarColaborador.Location = new System.Drawing.Point(49, 265);
            this.btn_actualizarColaborador.Name = "btn_actualizarColaborador";
            this.btn_actualizarColaborador.Size = new System.Drawing.Size(109, 34);
            this.btn_actualizarColaborador.TabIndex = 26;
            this.btn_actualizarColaborador.Text = "Actualizar";
            this.btn_actualizarColaborador.UseVisualStyleBackColor = false;
            this.btn_actualizarColaborador.Visible = false;
            this.btn_actualizarColaborador.Click += new System.EventHandler(this.btn_actualizarColaborador_Click_1);
            // 
            // btn_eliminarColaborador
            // 
            this.btn_eliminarColaborador.BackColor = System.Drawing.Color.White;
            this.btn_eliminarColaborador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarColaborador.Location = new System.Drawing.Point(293, 264);
            this.btn_eliminarColaborador.Name = "btn_eliminarColaborador";
            this.btn_eliminarColaborador.Size = new System.Drawing.Size(109, 34);
            this.btn_eliminarColaborador.TabIndex = 22;
            this.btn_eliminarColaborador.Text = "Eliminar";
            this.btn_eliminarColaborador.UseVisualStyleBackColor = false;
            this.btn_eliminarColaborador.Click += new System.EventHandler(this.btn_eliminarColaborador_Click);
            // 
            // btn_limpiarColaborador
            // 
            this.btn_limpiarColaborador.BackColor = System.Drawing.Color.White;
            this.btn_limpiarColaborador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiarColaborador.Location = new System.Drawing.Point(421, 264);
            this.btn_limpiarColaborador.Name = "btn_limpiarColaborador";
            this.btn_limpiarColaborador.Size = new System.Drawing.Size(100, 35);
            this.btn_limpiarColaborador.TabIndex = 23;
            this.btn_limpiarColaborador.Text = "Limpiar";
            this.btn_limpiarColaborador.UseVisualStyleBackColor = false;
            this.btn_limpiarColaborador.Click += new System.EventHandler(this.btn_limpiarColaborador_Click);
            // 
            // btn_editarColaborador
            // 
            this.btn_editarColaborador.BackColor = System.Drawing.Color.White;
            this.btn_editarColaborador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarColaborador.Location = new System.Drawing.Point(175, 265);
            this.btn_editarColaborador.Name = "btn_editarColaborador";
            this.btn_editarColaborador.Size = new System.Drawing.Size(100, 34);
            this.btn_editarColaborador.TabIndex = 21;
            this.btn_editarColaborador.Text = "Editar";
            this.btn_editarColaborador.UseVisualStyleBackColor = false;
            this.btn_editarColaborador.Click += new System.EventHandler(this.btn_editarColaborador_Click_1);
            // 
            // btn_registrarColaborador
            // 
            this.btn_registrarColaborador.BackColor = System.Drawing.Color.White;
            this.btn_registrarColaborador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarColaborador.Location = new System.Drawing.Point(46, 265);
            this.btn_registrarColaborador.Name = "btn_registrarColaborador";
            this.btn_registrarColaborador.Size = new System.Drawing.Size(109, 34);
            this.btn_registrarColaborador.TabIndex = 20;
            this.btn_registrarColaborador.Text = "Registrar";
            this.btn_registrarColaborador.UseVisualStyleBackColor = false;
            this.btn_registrarColaborador.Click += new System.EventHandler(this.btn_registrarColaborador_Click);
            // 
            // txt_buscarColaborador
            // 
            this.txt_buscarColaborador.Location = new System.Drawing.Point(612, 358);
            this.txt_buscarColaborador.Name = "txt_buscarColaborador";
            this.txt_buscarColaborador.Size = new System.Drawing.Size(145, 20);
            this.txt_buscarColaborador.TabIndex = 25;
            this.txt_buscarColaborador.TextChanged += new System.EventHandler(this.txt_buscarColaborador_TextChanged);
            // 
            // btnBuscarColaborador
            // 
            this.btnBuscarColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarColaborador.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarColaborador.Image")));
            this.btnBuscarColaborador.Location = new System.Drawing.Point(763, 335);
            this.btnBuscarColaborador.Name = "btnBuscarColaborador";
            this.btnBuscarColaborador.Size = new System.Drawing.Size(56, 53);
            this.btnBuscarColaborador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarColaborador.TabIndex = 53;
            this.btnBuscarColaborador.TabStop = false;
            this.btnBuscarColaborador.Click += new System.EventHandler(this.btnBuscarColaborador_Click);
            // 
            // Colaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(840, 681);
            this.Controls.Add(this.btnBuscarColaborador);
            this.Controls.Add(this.txt_buscarColaborador);
            this.Controls.Add(this.btn_actualizarColaborador);
            this.Controls.Add(this.btn_eliminarColaborador);
            this.Controls.Add(this.btn_limpiarColaborador);
            this.Controls.Add(this.btn_editarColaborador);
            this.Controls.Add(this.btn_registrarColaborador);
            this.Controls.Add(this.btn_listarColaboradores);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_fijoColaborador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_celularColaborador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_direccionColaborador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_cargoColaborador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tipoGenero);
            this.Controls.Add(this.txt_apellidosColaborador);
            this.Controls.Add(this.txt_nombresColaborador);
            this.Controls.Add(this.txt_nroDocColaborador);
            this.Controls.Add(this.cmb_tipoDoc);
            this.Controls.Add(this.txt_salarioColaborador);
            this.Controls.Add(this.dataGrid_Colaboradores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Colaboradores";
            this.Text = "Colaboradores";
            this.Load += new System.EventHandler(this.Colaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Colaboradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarColaborador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Colaboradores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tipoGenero;
        private System.Windows.Forms.TextBox txt_apellidosColaborador;
        private System.Windows.Forms.TextBox txt_nombresColaborador;
        private System.Windows.Forms.TextBox txt_nroDocColaborador;
        private System.Windows.Forms.ComboBox cmb_tipoDoc;
        private System.Windows.Forms.TextBox txt_salarioColaborador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_cargoColaborador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_direccionColaborador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_celularColaborador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_fijoColaborador;
        private System.Windows.Forms.Button btn_listarColaboradores;
        private System.Windows.Forms.Button btn_actualizarColaborador;
        private System.Windows.Forms.Button btn_eliminarColaborador;
        private System.Windows.Forms.Button btn_limpiarColaborador;
        private System.Windows.Forms.Button btn_editarColaborador;
        private System.Windows.Forms.Button btn_registrarColaborador;
        private System.Windows.Forms.TextBox txt_buscarColaborador;
        private System.Windows.Forms.PictureBox btnBuscarColaborador;
    }
}