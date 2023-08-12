namespace Ejercicio1_Poe
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
            this.invertir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tasa = new System.Windows.Forms.TextBox();
            this.Periodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Rcalculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // invertir
            // 
            this.invertir.Location = new System.Drawing.Point(98, 76);
            this.invertir.Name = "invertir";
            this.invertir.Size = new System.Drawing.Size(255, 22);
            this.invertir.TabIndex = 0;
            this.invertir.TextChanged += new System.EventHandler(this.invertir_TextChanged);
            this.invertir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.invertir_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto para invertir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tasa de interes ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tasa
            // 
            this.Tasa.Location = new System.Drawing.Point(99, 169);
            this.Tasa.Name = "Tasa";
            this.Tasa.Size = new System.Drawing.Size(254, 22);
            this.Tasa.TabIndex = 3;
            this.Tasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tasa_KeyPress);
            // 
            // Periodo
            // 
            this.Periodo.Location = new System.Drawing.Point(99, 279);
            this.Periodo.Name = "Periodo";
            this.Periodo.Size = new System.Drawing.Size(254, 22);
            this.Periodo.TabIndex = 4;
            this.Periodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Periodo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Periodo en años";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rcalculo
            // 
            this.Rcalculo.AutoSize = true;
            this.Rcalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rcalculo.Location = new System.Drawing.Point(100, 415);
            this.Rcalculo.Name = "Rcalculo";
            this.Rcalculo.Size = new System.Drawing.Size(253, 20);
            this.Rcalculo.TabIndex = 7;
            this.Rcalculo.Text = "Su interes Compuesto es de:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.Rcalculo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Periodo);
            this.Controls.Add(this.Tasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invertir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox invertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tasa;
        private System.Windows.Forms.TextBox Periodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Rcalculo;
    }
}

