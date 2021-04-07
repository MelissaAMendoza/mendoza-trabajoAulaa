
namespace COLAS
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
            this.ListaColas = new System.Windows.Forms.ListBox();
            this.btnINSERTAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaColas
            // 
            this.ListaColas.FormattingEnabled = true;
            this.ListaColas.ItemHeight = 16;
            this.ListaColas.Location = new System.Drawing.Point(51, 74);
            this.ListaColas.Name = "ListaColas";
            this.ListaColas.Size = new System.Drawing.Size(346, 260);
            this.ListaColas.TabIndex = 0;
            // 
            // btnINSERTAR
            // 
            this.btnINSERTAR.Location = new System.Drawing.Point(88, 370);
            this.btnINSERTAR.Name = "btnINSERTAR";
            this.btnINSERTAR.Size = new System.Drawing.Size(95, 35);
            this.btnINSERTAR.TabIndex = 1;
            this.btnINSERTAR.Text = "Insertar";
            this.btnINSERTAR.UseVisualStyleBackColor = true;
            this.btnINSERTAR.Click += new System.EventHandler(this.btnINSERTAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(265, 370);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(95, 35);
            this.btnELIMINAR.TabIndex = 2;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnINSERTAR);
            this.Controls.Add(this.ListaColas);
            this.Name = "Form1";
            this.Text = "Colas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaColas;
        private System.Windows.Forms.Button btnINSERTAR;
        private System.Windows.Forms.Button btnELIMINAR;
    }
}

