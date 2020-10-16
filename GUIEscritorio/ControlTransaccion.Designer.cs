namespace GUIEscritorio
{
    partial class ControlTransaccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Rut = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Estatura = new System.Windows.Forms.TextBox();
            this.Txt_Peso = new System.Windows.Forms.TextBox();
            this.Txt_IMC = new System.Windows.Forms.TextBox();
            this.Txt_Resultado = new System.Windows.Forms.TextBox();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IMC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resultado";
            // 
            // Txt_Rut
            // 
            this.Txt_Rut.Location = new System.Drawing.Point(101, 33);
            this.Txt_Rut.MaxLength = 15;
            this.Txt_Rut.Name = "Txt_Rut";
            this.Txt_Rut.Size = new System.Drawing.Size(212, 20);
            this.Txt_Rut.TabIndex = 6;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(101, 87);
            this.Txt_Nombre.MaxLength = 40;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(212, 20);
            this.Txt_Nombre.TabIndex = 7;
            // 
            // Txt_Estatura
            // 
            this.Txt_Estatura.Location = new System.Drawing.Point(101, 141);
            this.Txt_Estatura.Name = "Txt_Estatura";
            this.Txt_Estatura.Size = new System.Drawing.Size(212, 20);
            this.Txt_Estatura.TabIndex = 8;
            this.Txt_Estatura.TextChanged += new System.EventHandler(this.Txt_Estatura_TextChanged);
            // 
            // Txt_Peso
            // 
            this.Txt_Peso.Location = new System.Drawing.Point(101, 195);
            this.Txt_Peso.Name = "Txt_Peso";
            this.Txt_Peso.Size = new System.Drawing.Size(212, 20);
            this.Txt_Peso.TabIndex = 9;
            this.Txt_Peso.TextChanged += new System.EventHandler(this.Txt_Peso_TextChanged);
            // 
            // Txt_IMC
            // 
            this.Txt_IMC.Location = new System.Drawing.Point(101, 249);
            this.Txt_IMC.Name = "Txt_IMC";
            this.Txt_IMC.ReadOnly = true;
            this.Txt_IMC.Size = new System.Drawing.Size(212, 20);
            this.Txt_IMC.TabIndex = 10;
            this.Txt_IMC.TextChanged += new System.EventHandler(this.Txt_IMC_TextChanged);
            // 
            // Txt_Resultado
            // 
            this.Txt_Resultado.Location = new System.Drawing.Point(101, 303);
            this.Txt_Resultado.Name = "Txt_Resultado";
            this.Txt_Resultado.ReadOnly = true;
            this.Txt_Resultado.Size = new System.Drawing.Size(212, 20);
            this.Txt_Resultado.TabIndex = 11;
            this.Txt_Resultado.TextChanged += new System.EventHandler(this.Txt_Resultado_TextChanged);
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.Location = new System.Drawing.Point(30, 381);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Grabar.TabIndex = 12;
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            this.Btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(181, 381);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mostrar.TabIndex = 13;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(332, 381);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 14;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // ControlTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Mostrar);
            this.Controls.Add(this.Btn_Grabar);
            this.Controls.Add(this.Txt_Resultado);
            this.Controls.Add(this.Txt_IMC);
            this.Controls.Add(this.Txt_Peso);
            this.Controls.Add(this.Txt_Estatura);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_Rut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ControlTransaccion";
            this.Text = "Hospital Los Tres Chanchitos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Rut;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Estatura;
        private System.Windows.Forms.TextBox Txt_Peso;
        private System.Windows.Forms.TextBox Txt_IMC;
        private System.Windows.Forms.TextBox Txt_Resultado;
        private System.Windows.Forms.Button Btn_Grabar;
        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.Button Btn_Salir;
    }
}