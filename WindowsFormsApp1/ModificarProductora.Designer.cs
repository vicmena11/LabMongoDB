namespace WindowsFormsApp1
{
    partial class ModificarProductora
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
            this.tbNombreBusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombreBusqueda
            // 
            this.tbNombreBusqueda.Location = new System.Drawing.Point(166, 14);
            this.tbNombreBusqueda.Name = "tbNombreBusqueda";
            this.tbNombreBusqueda.Size = new System.Drawing.Size(150, 20);
            this.tbNombreBusqueda.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Nombre productora modificar:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(166, 90);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(150, 20);
            this.tbDireccion.TabIndex = 59;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(166, 55);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(150, 20);
            this.tbAño.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Página web:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Año fundación:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(197, 135);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 45;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ModificarProductora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 193);
            this.Controls.Add(this.tbNombreBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModificar);
            this.Name = "ModificarProductora";
            this.Text = "ModificarProductora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombreBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModificar;
    }
}