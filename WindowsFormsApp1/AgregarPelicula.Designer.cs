namespace WindowsFormsApp1
{
    partial class AgregarPelicula
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbFranquicia = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbDuración = new System.Windows.Forms.TextBox();
            this.tbProductora = new System.Windows.Forms.TextBox();
            this.tbActores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(236, 303);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Género:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Franquicia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pais producción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Año estreno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Duración(min):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Compañía productora:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Actores:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(205, 24);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(150, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(205, 52);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(150, 20);
            this.tbGenero.TabIndex = 11;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(205, 79);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(150, 20);
            this.tbDirector.TabIndex = 12;
            // 
            // tbFranquicia
            // 
            this.tbFranquicia.Location = new System.Drawing.Point(205, 108);
            this.tbFranquicia.Name = "tbFranquicia";
            this.tbFranquicia.Size = new System.Drawing.Size(150, 20);
            this.tbFranquicia.TabIndex = 13;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(205, 142);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(150, 20);
            this.tbPais.TabIndex = 14;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(205, 176);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(150, 20);
            this.tbAño.TabIndex = 15;
            // 
            // tbDuración
            // 
            this.tbDuración.Location = new System.Drawing.Point(205, 202);
            this.tbDuración.Name = "tbDuración";
            this.tbDuración.Size = new System.Drawing.Size(150, 20);
            this.tbDuración.TabIndex = 16;
            // 
            // tbProductora
            // 
            this.tbProductora.Location = new System.Drawing.Point(205, 238);
            this.tbProductora.Name = "tbProductora";
            this.tbProductora.Size = new System.Drawing.Size(150, 20);
            this.tbProductora.TabIndex = 17;
            // 
            // tbActores
            // 
            this.tbActores.Location = new System.Drawing.Point(205, 267);
            this.tbActores.Name = "tbActores";
            this.tbActores.Size = new System.Drawing.Size(150, 20);
            this.tbActores.TabIndex = 18;
            // 
            // AgregarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 342);
            this.Controls.Add(this.tbActores);
            this.Controls.Add(this.tbProductora);
            this.Controls.Add(this.tbDuración);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbFranquicia);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "AgregarPelicula";
            this.Text = "AgregarPelicula";
            this.Load += new System.EventHandler(this.AgregarPelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.TextBox tbFranquicia;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.TextBox tbDuración;
        private System.Windows.Forms.TextBox tbProductora;
        private System.Windows.Forms.TextBox tbActores;
    }
}