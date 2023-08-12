namespace Ejercicio3
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
            this.Numero1 = new System.Windows.Forms.Label();
            this.Numero2 = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.TextBox();
            this.N2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Numero1
            // 
            this.Numero1.AutoSize = true;
            this.Numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero1.Location = new System.Drawing.Point(243, 76);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(247, 24);
            this.Numero1.TabIndex = 0;
            this.Numero1.Text = "Ingrese el primer numero";
            // 
            // Numero2
            // 
            this.Numero2.AutoSize = true;
            this.Numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero2.Location = new System.Drawing.Point(243, 199);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(269, 24);
            this.Numero2.TabIndex = 1;
            this.Numero2.Text = "Ingrese el segundo numero";
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(279, 124);
            this.N1.Multiline = true;
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(183, 56);
            this.N1.TabIndex = 2;
            this.N1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N1_KeyPress);
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(281, 244);
            this.N2.Multiline = true;
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(183, 62);
            this.N2.TabIndex = 3;
            this.N2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "INICIAR DIVISION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1;
        private System.Windows.Forms.Label Numero2;
        private System.Windows.Forms.TextBox N1;
        private System.Windows.Forms.TextBox N2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

