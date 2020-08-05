namespace Ejemplo
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB_Id = new System.Windows.Forms.TextBox();
            this.txtB_FechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtB_Apellido = new System.Windows.Forms.TextBox();
            this.txtB_Nombre = new System.Windows.Forms.TextBox();
            this.rdB_Masculino = new System.Windows.Forms.RadioButton();
            this.rdB_Femenino = new System.Windows.Forms.RadioButton();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo";
            // 
            // txtB_Id
            // 
            this.txtB_Id.Location = new System.Drawing.Point(27, 25);
            this.txtB_Id.Name = "txtB_Id";
            this.txtB_Id.Size = new System.Drawing.Size(100, 20);
            this.txtB_Id.TabIndex = 5;
            // 
            // txtB_FechaNacimiento
            // 
            this.txtB_FechaNacimiento.Location = new System.Drawing.Point(27, 172);
            this.txtB_FechaNacimiento.Name = "txtB_FechaNacimiento";
            this.txtB_FechaNacimiento.Size = new System.Drawing.Size(237, 20);
            this.txtB_FechaNacimiento.TabIndex = 6;
            // 
            // txtB_Apellido
            // 
            this.txtB_Apellido.Location = new System.Drawing.Point(27, 123);
            this.txtB_Apellido.Name = "txtB_Apellido";
            this.txtB_Apellido.Size = new System.Drawing.Size(237, 20);
            this.txtB_Apellido.TabIndex = 8;
            // 
            // txtB_Nombre
            // 
            this.txtB_Nombre.Location = new System.Drawing.Point(27, 76);
            this.txtB_Nombre.Name = "txtB_Nombre";
            this.txtB_Nombre.Size = new System.Drawing.Size(237, 20);
            this.txtB_Nombre.TabIndex = 9;
            // 
            // rdB_Masculino
            // 
            this.rdB_Masculino.AutoSize = true;
            this.rdB_Masculino.Checked = true;
            this.rdB_Masculino.Location = new System.Drawing.Point(27, 228);
            this.rdB_Masculino.Name = "rdB_Masculino";
            this.rdB_Masculino.Size = new System.Drawing.Size(73, 17);
            this.rdB_Masculino.TabIndex = 10;
            this.rdB_Masculino.TabStop = true;
            this.rdB_Masculino.Text = "Masculino";
            this.rdB_Masculino.UseVisualStyleBackColor = true;
            // 
            // rdB_Femenino
            // 
            this.rdB_Femenino.AutoSize = true;
            this.rdB_Femenino.Location = new System.Drawing.Point(133, 228);
            this.rdB_Femenino.Name = "rdB_Femenino";
            this.rdB_Femenino.Size = new System.Drawing.Size(71, 17);
            this.rdB_Femenino.TabIndex = 11;
            this.rdB_Femenino.Text = "Femenino";
            this.rdB_Femenino.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(96, 286);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(189, 286);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 13;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 321);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.rdB_Femenino);
            this.Controls.Add(this.rdB_Masculino);
            this.Controls.Add(this.txtB_Nombre);
            this.Controls.Add(this.txtB_Apellido);
            this.Controls.Add(this.txtB_FechaNacimiento);
            this.Controls.Add(this.txtB_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtB_Id;
        private System.Windows.Forms.TextBox txtB_FechaNacimiento;
        private System.Windows.Forms.TextBox txtB_Apellido;
        private System.Windows.Forms.TextBox txtB_Nombre;
        private System.Windows.Forms.RadioButton rdB_Masculino;
        private System.Windows.Forms.RadioButton rdB_Femenino;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
    }
}