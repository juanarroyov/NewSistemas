namespace NewSistemaSigloXXI
{
    partial class Cocina
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
            this.txtPlatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlatos
            // 
            this.txtPlatos.Location = new System.Drawing.Point(713, 12);
            this.txtPlatos.Name = "txtPlatos";
            this.txtPlatos.Size = new System.Drawing.Size(75, 23);
            this.txtPlatos.TabIndex = 0;
            this.txtPlatos.Text = "Platos";
            this.txtPlatos.UseVisualStyleBackColor = true;
            this.txtPlatos.Click += new System.EventHandler(this.txtPlatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedidos";
            // 
            // btnReceta
            // 
            this.btnReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnReceta.Location = new System.Drawing.Point(713, 57);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(75, 23);
            this.btnReceta.TabIndex = 2;
            this.btnReceta.Text = "Recetas";
            this.btnReceta.UseVisualStyleBackColor = true;
            this.btnReceta.Click += new System.EventHandler(this.btnReceta_Click);
            // 
            // Cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReceta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlatos);
            this.Name = "Cocina";
            this.Text = "Cocina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtPlatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceta;
    }
}