namespace WindowsFormsApp1
{
    partial class solicitudvacaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(solicitudvacaciones));
            this.lblnombreempleado = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbliddelempleado = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbliniciovacaciones = new System.Windows.Forms.Label();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.lblfinvacaciones = new System.Windows.Forms.Label();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.btnsolicitar = new System.Windows.Forms.Button();
            this.picsolicitudvacaciones = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picsolicitudvacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombreempleado
            // 
            this.lblnombreempleado.AutoSize = true;
            this.lblnombreempleado.Location = new System.Drawing.Point(160, 194);
            this.lblnombreempleado.Name = "lblnombreempleado";
            this.lblnombreempleado.Size = new System.Drawing.Size(110, 13);
            this.lblnombreempleado.TabIndex = 0;
            this.lblnombreempleado.Tag = "lblnombreempleado";
            this.lblnombreempleado.Text = "Nombre del empleado";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(276, 194);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(200, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            // 
            // lbliddelempleado
            // 
            this.lbliddelempleado.AutoSize = true;
            this.lbliddelempleado.Location = new System.Drawing.Point(186, 235);
            this.lbliddelempleado.Name = "lbliddelempleado";
            this.lbliddelempleado.Size = new System.Drawing.Size(84, 13);
            this.lbliddelempleado.TabIndex = 2;
            this.lbliddelempleado.Text = "ID del empleado";
            this.lbliddelempleado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(276, 232);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(200, 20);
            this.txtid.TabIndex = 3;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // lbliniciovacaciones
            // 
            this.lbliniciovacaciones.AutoSize = true;
            this.lbliniciovacaciones.Location = new System.Drawing.Point(165, 275);
            this.lbliniciovacaciones.Name = "lbliniciovacaciones";
            this.lbliniciovacaciones.Size = new System.Drawing.Size(105, 13);
            this.lbliniciovacaciones.TabIndex = 4;
            this.lbliniciovacaciones.Text = "Inicio de vacaciones";
            this.lbliniciovacaciones.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dtpinicio
            // 
            this.dtpinicio.Location = new System.Drawing.Point(276, 275);
            this.dtpinicio.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(200, 20);
            this.dtpinicio.TabIndex = 5;
            this.dtpinicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpinicio_KeyDown);
            // 
            // lblfinvacaciones
            // 
            this.lblfinvacaciones.AutoSize = true;
            this.lblfinvacaciones.Location = new System.Drawing.Point(176, 315);
            this.lblfinvacaciones.Name = "lblfinvacaciones";
            this.lblfinvacaciones.Size = new System.Drawing.Size(94, 13);
            this.lblfinvacaciones.TabIndex = 6;
            this.lblfinvacaciones.Text = "Fin de vacaciones";
            // 
            // dtpfin
            // 
            this.dtpfin.Location = new System.Drawing.Point(276, 315);
            this.dtpfin.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(200, 20);
            this.dtpfin.TabIndex = 7;
            this.dtpfin.Value = new System.DateTime(2023, 5, 26, 16, 4, 0, 0);
           
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.Location = new System.Drawing.Point(300, 357);
            this.btnsolicitar.Name = "btnsolicitar";
            this.btnsolicitar.Size = new System.Drawing.Size(115, 26);
            this.btnsolicitar.TabIndex = 8;
            this.btnsolicitar.Text = "Solicitar vacaciones";
            this.btnsolicitar.UseVisualStyleBackColor = true;
            // 
            // picsolicitudvacaciones
            // 
            this.picsolicitudvacaciones.Image = ((System.Drawing.Image)(resources.GetObject("picsolicitudvacaciones.Image")));
            this.picsolicitudvacaciones.Location = new System.Drawing.Point(139, -136);
            this.picsolicitudvacaciones.Name = "picsolicitudvacaciones";
            this.picsolicitudvacaciones.Size = new System.Drawing.Size(547, 313);
            this.picsolicitudvacaciones.TabIndex = 9;
            this.picsolicitudvacaciones.TabStop = false;
            // 
            // solicitudvacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picsolicitudvacaciones);
            this.Controls.Add(this.btnsolicitar);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.lblfinvacaciones);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbliddelempleado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombreempleado);
            this.Controls.Add(this.lbliniciovacaciones);
            this.Name = "solicitudvacaciones";
            this.Text = "picsolicituddevacaciones";
            ((System.ComponentModel.ISupportInitialize)(this.picsolicitudvacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombreempleado;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbliddelempleado;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbliniciovacaciones;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label lblfinvacaciones;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.Button btnsolicitar;
        private System.Windows.Forms.PictureBox picsolicitudvacaciones;
    }
}

