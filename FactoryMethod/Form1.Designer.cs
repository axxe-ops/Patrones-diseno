namespace FactoryMethod
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
            this.cmbPizzeria = new System.Windows.Forms.ComboBox();
            this.cmbTipoPizza = new System.Windows.Forms.ComboBox();
            this.btnOrdenarPizza = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPizzeria
            // 
            this.cmbPizzeria.FormattingEnabled = true;
            this.cmbPizzeria.Location = new System.Drawing.Point(171, 45);
            this.cmbPizzeria.Name = "cmbPizzeria";
            this.cmbPizzeria.Size = new System.Drawing.Size(184, 21);
            this.cmbPizzeria.TabIndex = 0;
            // 
            // cmbTipoPizza
            // 
            this.cmbTipoPizza.FormattingEnabled = true;
            this.cmbTipoPizza.Location = new System.Drawing.Point(382, 45);
            this.cmbTipoPizza.Name = "cmbTipoPizza";
            this.cmbTipoPizza.Size = new System.Drawing.Size(184, 21);
            this.cmbTipoPizza.TabIndex = 1;
            // 
            // btnOrdenarPizza
            // 
            this.btnOrdenarPizza.Location = new System.Drawing.Point(260, 110);
            this.btnOrdenarPizza.Name = "btnOrdenarPizza";
            this.btnOrdenarPizza.Size = new System.Drawing.Size(228, 49);
            this.btnOrdenarPizza.TabIndex = 2;
            this.btnOrdenarPizza.Text = "Ordenar";
            this.btnOrdenarPizza.UseVisualStyleBackColor = true;
            this.btnOrdenarPizza.Click += new System.EventHandler(this.btnOrdenarPizza_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(171, 204);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(114, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado de la orden:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnOrdenarPizza);
            this.Controls.Add(this.cmbTipoPizza);
            this.Controls.Add(this.cmbPizzeria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPizzeria;
        private System.Windows.Forms.ComboBox cmbTipoPizza;
        private System.Windows.Forms.Button btnOrdenarPizza;
        private System.Windows.Forms.Label lblResultado;
    }
}

