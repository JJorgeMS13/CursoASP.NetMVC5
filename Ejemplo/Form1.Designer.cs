namespace Ejemplo
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
            this.dtG_Alumono = new System.Windows.Forms.DataGridView();
            this.btn_NuevoAlumno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_Alumono)).BeginInit();
            this.SuspendLayout();
            // 
            // dtG_Alumono
            // 
            this.dtG_Alumono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG_Alumono.Location = new System.Drawing.Point(30, 37);
            this.dtG_Alumono.Name = "dtG_Alumono";
            this.dtG_Alumono.Size = new System.Drawing.Size(733, 299);
            this.dtG_Alumono.TabIndex = 0;
            this.dtG_Alumono.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_Alumono_CellContentDoubleClick);
            // 
            // btn_NuevoAlumno
            // 
            this.btn_NuevoAlumno.Location = new System.Drawing.Point(646, 3);
            this.btn_NuevoAlumno.Name = "btn_NuevoAlumno";
            this.btn_NuevoAlumno.Size = new System.Drawing.Size(117, 28);
            this.btn_NuevoAlumno.TabIndex = 1;
            this.btn_NuevoAlumno.Text = "Nuevo Alumno";
            this.btn_NuevoAlumno.UseVisualStyleBackColor = true;
            this.btn_NuevoAlumno.Click += new System.EventHandler(this.btn_NuevoAlumno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alumnos.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NuevoAlumno);
            this.Controls.Add(this.dtG_Alumono);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtG_Alumono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtG_Alumono;
        private System.Windows.Forms.Button btn_NuevoAlumno;
        private System.Windows.Forms.Label label1;
    }
}

