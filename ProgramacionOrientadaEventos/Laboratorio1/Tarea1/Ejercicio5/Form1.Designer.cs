namespace ejercicio5_poe
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
            this.num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(50, 103);
            this.num.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(117, 20);
            this.num.TabIndex = 0;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un  numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calculadora de raices cuadradas ";
            // 
            // cal
            // 
            this.cal.BackColor = System.Drawing.Color.White;
            this.cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal.Location = new System.Drawing.Point(50, 159);
            this.cal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 32);
            this.cal.TabIndex = 3;
            this.cal.Text = "Calcular";
            this.cal.UseVisualStyleBackColor = false;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.BackColor = System.Drawing.Color.White;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(56, 225);
            this.res.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(266, 13);
            this.res.TabIndex = 4;
            this.res.Text = "La raiz cuadrada del numero ingresado es de:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.res);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Label res;
    }
}

