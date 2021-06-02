namespace AplicaciónFuncional
{
    partial class frmEstadisticas
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
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.grpEstadisticas = new System.Windows.Forms.GroupBox();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.grpEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // picAtras
            // 
            this.picAtras.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.atras;
            this.picAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAtras.Location = new System.Drawing.Point(12, 465);
            this.picAtras.Name = "picAtras";
            this.picAtras.Size = new System.Drawing.Size(35, 35);
            this.picAtras.TabIndex = 24;
            this.picAtras.TabStop = false;
            this.picAtras.Click += new System.EventHandler(this.picAtras_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(159)))));
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.picCerrar);
            this.pnlMenu.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(501, 52);
            this.pnlMenu.TabIndex = 25;
            this.pnlMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.picCerrar.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.cerrar;
            this.picCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Location = new System.Drawing.Point(469, 12);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(20, 20);
            this.picCerrar.TabIndex = 31;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // cmbMes
            // 
            this.cmbMes.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(69, 194);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(90, 23);
            this.cmbMes.TabIndex = 26;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(67, 176);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(31, 15);
            this.lblMes.TabIndex = 27;
            this.lblMes.Text = "Mes";
            // 
            // grpEstadisticas
            // 
            this.grpEstadisticas.Controls.Add(this.lblEnunciado);
            this.grpEstadisticas.Location = new System.Drawing.Point(63, 58);
            this.grpEstadisticas.Name = "grpEstadisticas";
            this.grpEstadisticas.Size = new System.Drawing.Size(375, 84);
            this.grpEstadisticas.TabIndex = 28;
            this.grpEstadisticas.TabStop = false;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(23, 14);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(332, 61);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "En esta ventana podrás visualizr algunas estadísticas de tu negocio mes a mes.\r\nY" +
    " enterarte de como va creciendo.";
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Location = new System.Drawing.Point(39, 242);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.Size = new System.Drawing.Size(422, 147);
            this.dgvEstadisticas.TabIndex = 29;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(217, 176);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(71, 15);
            this.lblProducto.TabIndex = 31;
            this.lblProducto.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(219, 194);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(90, 23);
            this.cmbProducto.TabIndex = 30;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.Black;
            this.btnImportar.Location = new System.Drawing.Point(76, 411);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(83, 40);
            this.btnImportar.TabIndex = 32;
            this.btnImportar.Text = "Importar XLSX";
            this.btnImportar.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Location = new System.Drawing.Point(206, 411);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(82, 40);
            this.btnExportar.TabIndex = 33;
            this.btnExportar.Text = "Exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(332, 411);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 40);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar XLSX";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 512);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.dgvEstadisticas);
            this.Controls.Add(this.grpEstadisticas);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.picAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadisticas";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.grpEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.GroupBox grpEstadisticas;
        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnGuardar;
    }
}