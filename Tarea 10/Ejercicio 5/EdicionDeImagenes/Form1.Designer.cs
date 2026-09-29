namespace Tarea_10___Act_5___Imagenes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar_Zoom = new System.Windows.Forms.TrackBar();
            this.trackBar_Brillo = new System.Windows.Forms.TrackBar();
            this.Tamanho_Lbl = new System.Windows.Forms.Label();
            this.Brillo_Lbl = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Guardarr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brillo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(279, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 397);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar_Zoom
            // 
            this.trackBar_Zoom.Location = new System.Drawing.Point(60, 137);
            this.trackBar_Zoom.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar_Zoom.Name = "trackBar_Zoom";
            this.trackBar_Zoom.Size = new System.Drawing.Size(146, 45);
            this.trackBar_Zoom.TabIndex = 4;
            this.trackBar_Zoom.Value = 5;
            this.trackBar_Zoom.Scroll += new System.EventHandler(this.trackBar_Zoom_Scroll);
            // 
            // trackBar_Brillo
            // 
            this.trackBar_Brillo.Location = new System.Drawing.Point(60, 314);
            this.trackBar_Brillo.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar_Brillo.Name = "trackBar_Brillo";
            this.trackBar_Brillo.Size = new System.Drawing.Size(146, 45);
            this.trackBar_Brillo.TabIndex = 5;
            this.trackBar_Brillo.Value = 5;
            this.trackBar_Brillo.Scroll += new System.EventHandler(this.trackBar_Brillo_Scroll);
            // 
            // Tamanho_Lbl
            // 
            this.Tamanho_Lbl.AutoSize = true;
            this.Tamanho_Lbl.Location = new System.Drawing.Point(111, 122);
            this.Tamanho_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tamanho_Lbl.Name = "Tamanho_Lbl";
            this.Tamanho_Lbl.Size = new System.Drawing.Size(46, 13);
            this.Tamanho_Lbl.TabIndex = 6;
            this.Tamanho_Lbl.Text = "Tamaño";
            // 
            // Brillo_Lbl
            // 
            this.Brillo_Lbl.AutoSize = true;
            this.Brillo_Lbl.Location = new System.Drawing.Point(119, 299);
            this.Brillo_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Brillo_Lbl.Name = "Brillo_Lbl";
            this.Brillo_Lbl.Size = new System.Drawing.Size(29, 13);
            this.Brillo_Lbl.TabIndex = 7;
            this.Brillo_Lbl.Text = "Brillo";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(100, 54);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 8;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(100, 364);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Aceptar.TabIndex = 9;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Guardarr
            // 
            this.Btn_Guardarr.Location = new System.Drawing.Point(100, 393);
            this.Btn_Guardarr.Name = "Btn_Guardarr";
            this.Btn_Guardarr.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardarr.TabIndex = 10;
            this.Btn_Guardarr.Text = "Guardar";
            this.Btn_Guardarr.UseVisualStyleBackColor = true;
            this.Btn_Guardarr.Click += new System.EventHandler(this.Btn_Guardarr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 487);
            this.Controls.Add(this.Btn_Guardarr);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Brillo_Lbl);
            this.Controls.Add(this.Tamanho_Lbl);
            this.Controls.Add(this.trackBar_Brillo);
            this.Controls.Add(this.trackBar_Zoom);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Editor de foto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar_Zoom;
        private System.Windows.Forms.TrackBar trackBar_Brillo;
        private System.Windows.Forms.Label Tamanho_Lbl;
        private System.Windows.Forms.Label Brillo_Lbl;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Guardarr;
    }
}

