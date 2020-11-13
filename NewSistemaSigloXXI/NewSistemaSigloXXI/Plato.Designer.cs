namespace NewSistemaSigloXXI
{
    partial class Plato
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
            this.btnGet = new System.Windows.Forms.Button();
            this.txtResponce = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreparacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(55, 44);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Buscar";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtResponce
            // 
            this.txtResponce.Location = new System.Drawing.Point(55, 404);
            this.txtResponce.Name = "txtResponce";
            this.txtResponce.Size = new System.Drawing.Size(714, 22);
            this.txtResponce.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(402, 43);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Agregar";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(518, 44);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(83, 23);
            this.btnPut.TabIndex = 3;
            this.btnPut.Text = "Actualizar";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(641, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(52, 133);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 17);
            this.label.TabIndex = 5;
            this.label.Text = "Nombre Plato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor del Plato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tiempo de preparación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preparación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(55, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(219, 108);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 11;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(219, 157);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 22);
            this.txtTiempo.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(381, 108);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(158, 24);
            this.cmbCategoria.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Minutos";
            // 
            // txtPreparacion
            // 
            this.txtPreparacion.Location = new System.Drawing.Point(177, 219);
            this.txtPreparacion.Name = "txtPreparacion";
            this.txtPreparacion.Size = new System.Drawing.Size(578, 22);
            this.txtPreparacion.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Por Id";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 18;
            // 
            // txtVolver
            // 
            this.txtVolver.Location = new System.Drawing.Point(640, 369);
            this.txtVolver.Name = "txtVolver";
            this.txtVolver.Size = new System.Drawing.Size(75, 23);
            this.txtVolver.TabIndex = 19;
            this.txtVolver.Text = "Volver";
            this.txtVolver.UseVisualStyleBackColor = true;
            this.txtVolver.Click += new System.EventHandler(this.txtVolver_Click);
            // 
            // Plato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVolver);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPreparacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtResponce);
            this.Controls.Add(this.btnGet);
            this.Name = "Plato";
            this.Text = "Plato";
            this.Load += new System.EventHandler(this.Plato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtResponce;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreparacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button txtVolver;
    }
}