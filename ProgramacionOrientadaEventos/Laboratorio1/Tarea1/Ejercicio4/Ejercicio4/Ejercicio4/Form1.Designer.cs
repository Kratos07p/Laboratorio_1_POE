namespace Ejercicio4
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
            this.palabra = new System.Windows.Forms.TextBox();
            this.Accion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // palabra
            // 
            this.palabra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palabra.Location = new System.Drawing.Point(272, 164);
            this.palabra.Multiline = true;
            this.palabra.Name = "palabra";
            this.palabra.Size = new System.Drawing.Size(192, 68);
            this.palabra.TabIndex = 0;
            this.palabra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.palabra_KeyPress);
            // 
            // Accion
            // 
            this.Accion.Location = new System.Drawing.Point(307, 271);
            this.Accion.Name = "Accion";
            this.Accion.Size = new System.Drawing.Size(119, 33);
            this.Accion.TabIndex = 1;
            this.Accion.Text = "Iniciar";
            this.Accion.UseVisualStyleBackColor = true;
            this.Accion.Click += new System.EventHandler(this.Accion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convertidor de palabras a mayuscula";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Accion);
            this.Controls.Add(this.palabra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox palabra;
        private System.Windows.Forms.Button Accion;
        private System.Windows.Forms.Label label1;
    }
}

