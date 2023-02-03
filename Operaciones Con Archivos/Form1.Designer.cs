namespace Operaciones_Con_Archivos
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tEscribirTexto = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.tAgregarTexto = new System.Windows.Forms.TextBox();
            this.btnAñadirTexto = new System.Windows.Forms.Button();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.btnSumarArchivo = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(421, 143);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(345, 52);
            this.btnLeer.TabIndex = 1;
            this.btnLeer.Text = "Leer de Archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(18, 198);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 15);
            this.lblMensaje.TabIndex = 2;
            // 
            // tEscribirTexto
            // 
            this.tEscribirTexto.Location = new System.Drawing.Point(18, 13);
            this.tEscribirTexto.Name = "tEscribirTexto";
            this.tEscribirTexto.Size = new System.Drawing.Size(386, 23);
            this.tEscribirTexto.TabIndex = 3;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(421, 13);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(345, 23);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "Escribir en Archivo";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // tAgregarTexto
            // 
            this.tAgregarTexto.Location = new System.Drawing.Point(18, 86);
            this.tAgregarTexto.Name = "tAgregarTexto";
            this.tAgregarTexto.Size = new System.Drawing.Size(386, 23);
            this.tAgregarTexto.TabIndex = 5;
            // 
            // btnAñadirTexto
            // 
            this.btnAñadirTexto.Location = new System.Drawing.Point(421, 86);
            this.btnAñadirTexto.Name = "btnAñadirTexto";
            this.btnAñadirTexto.Size = new System.Drawing.Size(345, 23);
            this.btnAñadirTexto.TabIndex = 6;
            this.btnAñadirTexto.Text = "Añadir a Archivo";
            this.btnAñadirTexto.UseVisualStyleBackColor = true;
            this.btnAñadirTexto.Click += new System.EventHandler(this.btnAñadirTexto_Click);
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.BackColor = System.Drawing.Color.IndianRed;
            this.btnReestablecer.Location = new System.Drawing.Point(421, 42);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(345, 23);
            this.btnReestablecer.TabIndex = 7;
            this.btnReestablecer.Text = "Reestablecer Archivo";
            this.btnReestablecer.UseVisualStyleBackColor = false;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // btnSumarArchivo
            // 
            this.btnSumarArchivo.Location = new System.Drawing.Point(18, 143);
            this.btnSumarArchivo.Name = "btnSumarArchivo";
            this.btnSumarArchivo.Size = new System.Drawing.Size(386, 52);
            this.btnSumarArchivo.TabIndex = 8;
            this.btnSumarArchivo.Text = "Sumar";
            this.btnSumarArchivo.UseVisualStyleBackColor = true;
            this.btnSumarArchivo.Click += new System.EventHandler(this.btnSumarArchivo_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(193, 52);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(15, 15);
            this.lblSuma.TabIndex = 9;
            this.lblSuma.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnSumarArchivo);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnAñadirTexto);
            this.Controls.Add(this.tAgregarTexto);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.tEscribirTexto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnLeer);
            this.Name = "Form1";
            this.Text = "Operaciones con Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLeer;
        private Label lblMensaje;
        private TextBox tEscribirTexto;
        private Button btnEscribir;
        private TextBox tAgregarTexto;
        private Button btnAñadirTexto;
        private Button btnReestablecer;
        private Button btnSumarArchivo;
        private Label lblSuma;
    }
}