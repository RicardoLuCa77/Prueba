using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace botonsito
{
    partial class UserControl1 : UserControl
    {   
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Campo para llevar el contador
        private int contador = 0;

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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1 (arriba izquierda, azul)
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Botonsito";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2 (grande en el centro)
            // 
            this.button2.Location = new System.Drawing.Point(60, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sumar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelContador (roja)
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.ForeColor = System.Drawing.Color.Red;
            this.labelContador.Location = new System.Drawing.Point(120, 30);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(70, 13);
            this.labelContador.TabIndex = 2;
            this.labelContador.Text = "Contador: 0";
            // 
            // UserControl1
            // 
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(250, 200);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelContador;

        // Manejador de evento para el botón "Sumar"
        private void button2_Click(object sender, EventArgs e)
        {
            contador++;
            labelContador.Text = $"Contador: {contador}";
        }
    }
}
