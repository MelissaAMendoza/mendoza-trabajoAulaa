
namespace listasEnlazadas
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
            this.btnAgg = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.Label();
            this.listPalabras = new System.Windows.Forms.ListBox();
            this.txtPalabras = new System.Windows.Forms.TextBox();
            this.btnElim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgg
            // 
            this.btnAgg.Location = new System.Drawing.Point(74, 481);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(126, 36);
            this.btnAgg.TabIndex = 0;
            this.btnAgg.Text = "Agregar";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSize = true;
            this.txtNombres.Location = new System.Drawing.Point(59, 24);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(344, 17);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Text = "Escriba aquí la palabra que desea ingresar a la lista :";
            // 
            // listPalabras
            // 
            this.listPalabras.FormattingEnabled = true;
            this.listPalabras.ItemHeight = 16;
            this.listPalabras.Location = new System.Drawing.Point(62, 115);
            this.listPalabras.Name = "listPalabras";
            this.listPalabras.Size = new System.Drawing.Size(335, 308);
            this.listPalabras.TabIndex = 2;
            // 
            // txtPalabras
            // 
            this.txtPalabras.Location = new System.Drawing.Point(74, 62);
            this.txtPalabras.Name = "txtPalabras";
            this.txtPalabras.Size = new System.Drawing.Size(304, 22);
            this.txtPalabras.TabIndex = 3;
            // 
            // btnElim
            // 
            this.btnElim.Location = new System.Drawing.Point(252, 481);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(126, 36);
            this.btnElim.TabIndex = 4;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Para eliminar un elemento de la lista, escriba el nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "y seleccione \"Eliminar\'";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.txtPalabras);
            this.Controls.Add(this.listPalabras);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnAgg);
            this.Name = "Form1";
            this.Text = "Listas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.Label txtNombres;
        private System.Windows.Forms.ListBox listPalabras;
        private System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

