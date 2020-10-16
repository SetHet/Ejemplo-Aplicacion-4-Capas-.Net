namespace GUIEscritorio
{
    partial class VentanaListaTransacciones
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
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.DataGridView_Tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(499, 415);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // DataGridView_Tabla
            // 
            this.DataGridView_Tabla.AllowUserToAddRows = false;
            this.DataGridView_Tabla.AllowUserToDeleteRows = false;
            this.DataGridView_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Tabla.Location = new System.Drawing.Point(12, 12);
            this.DataGridView_Tabla.Name = "DataGridView_Tabla";
            this.DataGridView_Tabla.Size = new System.Drawing.Size(562, 397);
            this.DataGridView_Tabla.TabIndex = 1;
            // 
            // VentanaListaTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.DataGridView_Tabla);
            this.Controls.Add(this.Btn_Salir);
            this.Name = "VentanaListaTransacciones";
            this.Text = "Lista de Transacciones de Los Tres Chanchitos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DataGridView DataGridView_Tabla;
    }
}