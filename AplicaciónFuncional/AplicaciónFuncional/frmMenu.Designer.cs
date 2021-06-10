namespace AplicaciónFuncional
{
    partial class frmMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picCerrarSesion = new System.Windows.Forms.PictureBox();
            this.picEstadisticas = new System.Windows.Forms.PictureBox();
            this.picProductos = new System.Windows.Forms.PictureBox();
            this.picVentas = new System.Windows.Forms.PictureBox();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblBienvenida);
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 178);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(112, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(6, 96);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(315, 79);
            this.lblBienvenida.TabIndex = 18;
            this.lblBienvenida.Text = "Este software \"Contabiliza tu tienda\"\r\nes ideal en tu negocio para llevar tus cue" +
    "ntas claras y facilitar tu trabajo.\r\nPuedes elegir entre las siguientes opciones" +
    ":\r\n";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 391);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrarSesion.Size = new System.Drawing.Size(353, 38);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "             Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(159)))));
            this.pnlMenu.Controls.Add(this.lblUsuario);
            this.pnlMenu.Controls.Add(this.picCerrar);
            this.pnlMenu.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(353, 40);
            this.pnlMenu.TabIndex = 21;
            this.pnlMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.picCerrar.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.cerrar;
            this.picCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Location = new System.Drawing.Point(322, 10);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(20, 20);
            this.picCerrar.TabIndex = 31;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // picCerrarSesion
            // 
            this.picCerrarSesion.BackColor = System.Drawing.Color.Gainsboro;
            this.picCerrarSesion.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.cerrar_sesion;
            this.picCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrarSesion.Location = new System.Drawing.Point(225, 392);
            this.picCerrarSesion.Name = "picCerrarSesion";
            this.picCerrarSesion.Size = new System.Drawing.Size(35, 36);
            this.picCerrarSesion.TabIndex = 19;
            this.picCerrarSesion.TabStop = false;
            this.picCerrarSesion.Click += new System.EventHandler(this.picCerrarSesion_Click);
            // 
            // picEstadisticas
            // 
            this.picEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(32)))));
            this.picEstadisticas.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.estadistica;
            this.picEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEstadisticas.Location = new System.Drawing.Point(271, 314);
            this.picEstadisticas.Name = "picEstadisticas";
            this.picEstadisticas.Size = new System.Drawing.Size(50, 45);
            this.picEstadisticas.TabIndex = 18;
            this.picEstadisticas.TabStop = false;
            this.picEstadisticas.Click += new System.EventHandler(this.picEstadisticas_Click);
            // 
            // picProductos
            // 
            this.picProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(55)))));
            this.picProductos.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.productos;
            this.picProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProductos.Location = new System.Drawing.Point(57, 330);
            this.picProductos.Name = "picProductos";
            this.picProductos.Size = new System.Drawing.Size(46, 44);
            this.picProductos.TabIndex = 17;
            this.picProductos.TabStop = false;
            this.picProductos.Click += new System.EventHandler(this.picProductos_Click);
            // 
            // picVentas
            // 
            this.picVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(131)))));
            this.picVentas.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.ventas;
            this.picVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVentas.Location = new System.Drawing.Point(94, 243);
            this.picVentas.Name = "picVentas";
            this.picVentas.Size = new System.Drawing.Size(60, 50);
            this.picVentas.TabIndex = 16;
            this.picVentas.TabStop = false;
            this.picVentas.Click += new System.EventHandler(this.picVentas_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstadisticas.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.FondoEstadisticas;
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Location = new System.Drawing.Point(151, 308);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(180, 58);
            this.btnEstadisticas.TabIndex = 14;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.FondoProductos;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProductos.Location = new System.Drawing.Point(21, 308);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(119, 72);
            this.btnProductos.TabIndex = 13;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVentas.BackgroundImage = global::AplicaciónFuncional.Properties.Resources.FondoVentas;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(28, 235);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(298, 65);
            this.btnVentas.TabIndex = 12;
            this.btnVentas.Text = "         Nueva Venta";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(10, 10);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 23);
            this.lblUsuario.TabIndex = 32;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 429);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picCerrarSesion);
            this.Controls.Add(this.picEstadisticas);
            this.Controls.Add(this.picProductos);
            this.Controls.Add(this.picVentas);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox picCerrarSesion;
        private System.Windows.Forms.PictureBox picEstadisticas;
        private System.Windows.Forms.PictureBox picProductos;
        private System.Windows.Forms.PictureBox picVentas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label lblUsuario;
    }
}