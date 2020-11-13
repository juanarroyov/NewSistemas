namespace NewSistemaSigloXXI
{
    partial class TotemMesa
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
            this.cnbEstado = new System.Windows.Forms.ComboBox();
            this.cnbMesa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cnbEstado
            // 
            this.cnbEstado.FormattingEnabled = true;
            this.cnbEstado.Location = new System.Drawing.Point(459, 104);
            this.cnbEstado.Name = "cnbEstado";
            this.cnbEstado.Size = new System.Drawing.Size(121, 24);
            this.cnbEstado.TabIndex = 0;
            // 
            // cnbMesa
            // 
            this.cnbMesa.FormattingEnabled = true;
            this.cnbMesa.Location = new System.Drawing.Point(165, 104);
            this.cnbMesa.Name = "cnbMesa";
            this.cnbMesa.Size = new System.Drawing.Size(121, 24);
            this.cnbMesa.TabIndex = 1;
            this.cnbMesa.SelectedIndexChanged += new System.EventHandler(this.cnbMesa_SelectedIndexChanged);
            // 
            // TotemMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnbMesa);
            this.Controls.Add(this.cnbEstado);
            this.Name = "TotemMesa";
            this.Text = "TotemMesa";
            this.Load += new System.EventHandler(this.TotemMesa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cnbEstado;
        private System.Windows.Forms.ComboBox cnbMesa;
    }
}