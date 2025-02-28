namespace Examen
{
    partial class Form1
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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnMostrarAlumnos = new System.Windows.Forms.Button();
            this.btnModificarNota = new System.Windows.Forms.Button();
            this.btnMostrarSuspensos = new System.Windows.Forms.Button();
            this.btnMostrarAprobados = new System.Windows.Forms.Button();
            this.btnMostrarCandidatosMH = new System.Windows.Forms.Button();
            this.btnConsultarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnIntroducirAlumno = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(176, 42);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(146, 22);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(328, 42);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(146, 22);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(480, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nota";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(363, 104);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(89, 22);
            this.txtNota.TabIndex = 6;
            this.txtNota.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnMostrarAlumnos
            // 
            this.btnMostrarAlumnos.Location = new System.Drawing.Point(152, 171);
            this.btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            this.btnMostrarAlumnos.Size = new System.Drawing.Size(151, 35);
            this.btnMostrarAlumnos.TabIndex = 10;
            this.btnMostrarAlumnos.Text = "Mostrar Alumnos";
            this.btnMostrarAlumnos.UseVisualStyleBackColor = true;
            this.btnMostrarAlumnos.Click += new System.EventHandler(this.btnMostrarAlumnos_Click);
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.Location = new System.Drawing.Point(338, 231);
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.Size = new System.Drawing.Size(155, 30);
            this.btnModificarNota.TabIndex = 11;
            this.btnModificarNota.Text = "Modificar Nota";
            this.btnModificarNota.UseVisualStyleBackColor = true;
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // btnMostrarSuspensos
            // 
            this.btnMostrarSuspensos.Location = new System.Drawing.Point(529, 231);
            this.btnMostrarSuspensos.Name = "btnMostrarSuspensos";
            this.btnMostrarSuspensos.Size = new System.Drawing.Size(151, 30);
            this.btnMostrarSuspensos.TabIndex = 12;
            this.btnMostrarSuspensos.Text = "Mostrar Suspensos";
            this.btnMostrarSuspensos.UseVisualStyleBackColor = true;
            this.btnMostrarSuspensos.Click += new System.EventHandler(this.btnMostrarSuspensos_Click);
            // 
            // btnMostrarAprobados
            // 
            this.btnMostrarAprobados.Location = new System.Drawing.Point(241, 283);
            this.btnMostrarAprobados.Name = "btnMostrarAprobados";
            this.btnMostrarAprobados.Size = new System.Drawing.Size(167, 31);
            this.btnMostrarAprobados.TabIndex = 13;
            this.btnMostrarAprobados.Text = "Mostrar Aprobados";
            this.btnMostrarAprobados.UseVisualStyleBackColor = true;
            this.btnMostrarAprobados.Click += new System.EventHandler(this.btnMostrarAprobados_Click);
            // 
            // btnMostrarCandidatosMH
            // 
            this.btnMostrarCandidatosMH.Location = new System.Drawing.Point(427, 283);
            this.btnMostrarCandidatosMH.Name = "btnMostrarCandidatosMH";
            this.btnMostrarCandidatosMH.Size = new System.Drawing.Size(187, 31);
            this.btnMostrarCandidatosMH.TabIndex = 14;
            this.btnMostrarCandidatosMH.Text = "Mostrar Candidatos MH";
            this.btnMostrarCandidatosMH.UseVisualStyleBackColor = true;
            this.btnMostrarCandidatosMH.Click += new System.EventHandler(this.btnMostrarCandidatosMH_Click);
            // 
            // btnConsultarAlumno
            // 
            this.btnConsultarAlumno.Location = new System.Drawing.Point(152, 231);
            this.btnConsultarAlumno.Name = "btnConsultarAlumno";
            this.btnConsultarAlumno.Size = new System.Drawing.Size(151, 30);
            this.btnConsultarAlumno.TabIndex = 15;
            this.btnConsultarAlumno.Text = "Consultar Alumno";
            this.btnConsultarAlumno.UseVisualStyleBackColor = true;
            this.btnConsultarAlumno.Click += new System.EventHandler(this.btnConsultarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(529, 171);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(151, 35);
            this.btnEliminarAlumno.TabIndex = 17;
            this.btnEliminarAlumno.Text = "Eliminar Alumno";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnIntroducirAlumno
            // 
            this.btnIntroducirAlumno.Location = new System.Drawing.Point(338, 171);
            this.btnIntroducirAlumno.Name = "btnIntroducirAlumno";
            this.btnIntroducirAlumno.Size = new System.Drawing.Size(155, 35);
            this.btnIntroducirAlumno.TabIndex = 18;
            this.btnIntroducirAlumno.Text = "Introducir Alumno";
            this.btnIntroducirAlumno.UseVisualStyleBackColor = true;
            this.btnIntroducirAlumno.Click += new System.EventHandler(this.btnIntroducirAlumno_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 16;
            this.listBoxResultado.Location = new System.Drawing.Point(261, 338);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(300, 100);
            this.listBoxResultado.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.btnIntroducirAlumno);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnConsultarAlumno);
            this.Controls.Add(this.btnMostrarCandidatosMH);
            this.Controls.Add(this.btnMostrarAprobados);
            this.Controls.Add(this.btnMostrarSuspensos);
            this.Controls.Add(this.btnModificarNota);
            this.Controls.Add(this.btnMostrarAlumnos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnMostrarAlumnos;
        private System.Windows.Forms.Button btnModificarNota;
        private System.Windows.Forms.Button btnMostrarSuspensos;
        private System.Windows.Forms.Button btnMostrarAprobados;
        private System.Windows.Forms.Button btnMostrarCandidatosMH;
        private System.Windows.Forms.Button btnConsultarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnIntroducirAlumno;
        private System.Windows.Forms.ListBox listBoxResultado;
    }
}

