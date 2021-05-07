
namespace Listas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.listas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Al presionar \"Cargar\" se cargaran 25 numeros aleatorios de 1-100";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(192, 60);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(128, 33);
            this.buttonCargar.TabIndex = 1;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // listas
            // 
            this.listas.FormattingEnabled = true;
            this.listas.ItemHeight = 20;
            this.listas.Location = new System.Drawing.Point(83, 111);
            this.listas.Name = "listas";
            this.listas.Size = new System.Drawing.Size(330, 264);
            this.listas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "La suma de los elementos es:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "El promedio de los elementos es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listas);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Listas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.ListBox listas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

