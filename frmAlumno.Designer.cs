namespace AlumnoGUI {
    partial class frmAlumno {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumno));
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtPromGral = new System.Windows.Forms.TextBox();
            this.lblPromGral = new System.Windows.Forms.Label();
            this.lblMayorNombre = new System.Windows.Forms.Label();
            this.lblContadorLibres = new System.Windows.Forms.Label();
            this.lblContadorRegulares = new System.Windows.Forms.Label();
            this.lblContadorPromocionados = new System.Windows.Forms.Label();
            this.lblPorcLibres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPorcReg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPorcPromocionados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMayorProm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLegajo.Location = new System.Drawing.Point(94, 9);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(76, 29);
            this.lblLegajo.TabIndex = 0;
            this.lblLegajo.Text = "Legajo";
            this.lblLegajo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(82, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 29);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNotas.Location = new System.Drawing.Point(115, 157);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(70, 29);
            this.lblNotas.TabIndex = 4;
            this.lblNotas.Text = "Notas";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPromedio.Location = new System.Drawing.Point(69, 217);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(101, 29);
            this.lblPromedio.TabIndex = 8;
            this.lblPromedio.Text = "Promedio";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Location = new System.Drawing.Point(240, 594);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(171, 77);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(177, 217);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(100, 35);
            this.txtPromedio.TabIndex = 9;
            this.txtPromedio.TextChanged += new System.EventHandler(this.txtPromedio_TextChanged);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(186, 150);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(71, 35);
            this.txtNota1.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 35);
            this.txtNombre.TabIndex = 3;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(177, 12);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 35);
            this.txtLegajo.TabIndex = 1;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(322, 150);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(71, 35);
            this.txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(460, 150);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(71, 35);
            this.txtNota3.TabIndex = 7;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContador.Location = new System.Drawing.Point(586, 594);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(25, 29);
            this.lblContador.TabIndex = 11;
            this.lblContador.Text = "0";
            this.lblContador.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtPromGral
            // 
            this.txtPromGral.Location = new System.Drawing.Point(431, 247);
            this.txtPromGral.Name = "txtPromGral";
            this.txtPromGral.ReadOnly = true;
            this.txtPromGral.Size = new System.Drawing.Size(100, 35);
            this.txtPromGral.TabIndex = 12;
            // 
            // lblPromGral
            // 
            this.lblPromGral.AutoSize = true;
            this.lblPromGral.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPromGral.Location = new System.Drawing.Point(411, 205);
            this.lblPromGral.Name = "lblPromGral";
            this.lblPromGral.Size = new System.Drawing.Size(182, 29);
            this.lblPromGral.TabIndex = 13;
            this.lblPromGral.Text = "Promedio General";
            // 
            // lblMayorNombre
            // 
            this.lblMayorNombre.AutoSize = true;
            this.lblMayorNombre.Location = new System.Drawing.Point(305, 296);
            this.lblMayorNombre.Name = "lblMayorNombre";
            this.lblMayorNombre.Size = new System.Drawing.Size(0, 29);
            this.lblMayorNombre.TabIndex = 14;
            // 
            // lblContadorLibres
            // 
            this.lblContadorLibres.AutoSize = true;
            this.lblContadorLibres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContadorLibres.Location = new System.Drawing.Point(68, 390);
            this.lblContadorLibres.Name = "lblContadorLibres";
            this.lblContadorLibres.Size = new System.Drawing.Size(73, 29);
            this.lblContadorLibres.TabIndex = 15;
            this.lblContadorLibres.Text = "Libres";
            this.lblContadorLibres.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblContadorRegulares
            // 
            this.lblContadorRegulares.AutoSize = true;
            this.lblContadorRegulares.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContadorRegulares.Location = new System.Drawing.Point(68, 460);
            this.lblContadorRegulares.Name = "lblContadorRegulares";
            this.lblContadorRegulares.Size = new System.Drawing.Size(105, 29);
            this.lblContadorRegulares.TabIndex = 16;
            this.lblContadorRegulares.Text = "Regulares";
            // 
            // lblContadorPromocionados
            // 
            this.lblContadorPromocionados.AutoSize = true;
            this.lblContadorPromocionados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContadorPromocionados.Location = new System.Drawing.Point(68, 520);
            this.lblContadorPromocionados.Name = "lblContadorPromocionados";
            this.lblContadorPromocionados.Size = new System.Drawing.Size(153, 29);
            this.lblContadorPromocionados.TabIndex = 17;
            this.lblContadorPromocionados.Text = "Promocionados";
            // 
            // lblPorcLibres
            // 
            this.lblPorcLibres.AutoSize = true;
            this.lblPorcLibres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPorcLibres.Location = new System.Drawing.Point(257, 390);
            this.lblPorcLibres.Name = "lblPorcLibres";
            this.lblPorcLibres.Size = new System.Drawing.Size(25, 29);
            this.lblPorcLibres.TabIndex = 18;
            this.lblPorcLibres.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(318, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "0";
            // 
            // lblPorcReg
            // 
            this.lblPorcReg.AutoSize = true;
            this.lblPorcReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPorcReg.Location = new System.Drawing.Point(257, 460);
            this.lblPorcReg.Name = "lblPorcReg";
            this.lblPorcReg.Size = new System.Drawing.Size(25, 29);
            this.lblPorcReg.TabIndex = 20;
            this.lblPorcReg.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(318, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(318, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "0";
            // 
            // lblPorcPromocionados
            // 
            this.lblPorcPromocionados.AutoSize = true;
            this.lblPorcPromocionados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPorcPromocionados.Location = new System.Drawing.Point(257, 511);
            this.lblPorcPromocionados.Name = "lblPorcPromocionados";
            this.lblPorcPromocionados.Size = new System.Drawing.Size(25, 29);
            this.lblPorcPromocionados.TabIndex = 22;
            this.lblPorcPromocionados.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(456, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(471, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(370, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(370, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(370, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(20, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "Mayor Promedio";
            // 
            // txtMayorProm
            // 
            this.txtMayorProm.Location = new System.Drawing.Point(215, 286);
            this.txtMayorProm.Name = "txtMayorProm";
            this.txtMayorProm.ReadOnly = true;
            this.txtMayorProm.Size = new System.Drawing.Size(100, 35);
            this.txtMayorProm.TabIndex = 29;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1651, 768);
            this.Controls.Add(this.txtMayorProm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPorcPromocionados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPorcReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPorcLibres);
            this.Controls.Add(this.lblContadorPromocionados);
            this.Controls.Add(this.lblContadorRegulares);
            this.Controls.Add(this.lblContadorLibres);
            this.Controls.Add(this.lblMayorNombre);
            this.Controls.Add(this.lblPromGral);
            this.Controls.Add(this.txtPromGral);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblLegajo);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "frmAlumno";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtPromGral;
        private System.Windows.Forms.Label lblPromGral;
        private System.Windows.Forms.Label lblMayorNombre;
        private System.Windows.Forms.Label lblContadorLibres;
        private System.Windows.Forms.Label lblContadorRegulares;
        private System.Windows.Forms.Label lblContadorPromocionados;
        private System.Windows.Forms.Label lblPorcLibres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPorcReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPorcPromocionados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMayorProm;

        //Todo lo que creamos aparece referenciado acá
    }
}

