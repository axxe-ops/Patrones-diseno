namespace Composite
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearCarpeta = new System.Windows.Forms.Button();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.trvEstructura = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(78, 61);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(104, 20);
            this.txtTamaño.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño";
            // 
            // btnCrearCarpeta
            // 
            this.btnCrearCarpeta.Location = new System.Drawing.Point(78, 98);
            this.btnCrearCarpeta.Name = "btnCrearCarpeta";
            this.btnCrearCarpeta.Size = new System.Drawing.Size(219, 60);
            this.btnCrearCarpeta.TabIndex = 4;
            this.btnCrearCarpeta.Text = "Crear Carpeta";
            this.btnCrearCarpeta.UseVisualStyleBackColor = true;
            this.btnCrearCarpeta.Click += new System.EventHandler(this.btnCrearCarpeta_Click);
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Location = new System.Drawing.Point(303, 98);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(118, 60);
            this.btnCrearArchivo.TabIndex = 5;
            this.btnCrearArchivo.Text = "Crear Archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // trvEstructura
            // 
            this.trvEstructura.Location = new System.Drawing.Point(78, 186);
            this.trvEstructura.Name = "trvEstructura";
            this.trvEstructura.Size = new System.Drawing.Size(343, 330);
            this.trvEstructura.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 561);
            this.Controls.Add(this.trvEstructura);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.btnCrearCarpeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearCarpeta;
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.TreeView trvEstructura;
    }
}

