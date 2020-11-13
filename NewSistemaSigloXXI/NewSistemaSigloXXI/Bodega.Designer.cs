namespace NewSistemaSigloXXI
{
    partial class Bodega
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGet.Location = new System.Drawing.Point(40, 34);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 36);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Buscar";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(695, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(608, 34);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(81, 36);
            this.btnPut.TabIndex = 2;
            this.btnPut.Text = "Actualizar";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(527, 34);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 36);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Agregar";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 34);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtId.Size = new System.Drawing.Size(397, 72);
            this.txtId.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 241);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(173, 130);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 22);
            this.txtStock.TabIndex = 7;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(316, 130);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 22);
            this.txtMinimo.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(472, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGet);
            this.Name = "Bodega";
            this.Text = "Bodega";
            this.Load += new System.EventHandler(this.Bodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}