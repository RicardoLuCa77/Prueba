using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace botonsitos
{
    partial class Form1
    {
        private IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelContador;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1 (Solo decorativo)
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Botonsito";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2 (El que suma)
            // 
            this.button2.Location = new System.Drawing.Point(60, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sumar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelContador
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.ForeColor = System.Drawing.Color.Red;
            this.labelContador.Location = new System.Drawing.Point(120, 30);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(70, 13);
            this.labelContador.TabIndex = 2;
            this.labelContador.Text = "Contador: 0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Mi Contador";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
