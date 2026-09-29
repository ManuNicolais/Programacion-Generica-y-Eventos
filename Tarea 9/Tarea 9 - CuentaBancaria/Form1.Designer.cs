namespace CuentaBancariaApp
{
    partial class Form1
    {
        /// <summary>
        /// Requerido por el diseñador de Windows Forms.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// Método necesario para la compatibilidad con el Diseñador de Windows Forms.
        /// No se puede modificar el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaldoCorriente = new System.Windows.Forms.Label();
            this.lblNumeroCorriente = new System.Windows.Forms.Label();
            this.lblSaldoAhorro = new System.Windows.Forms.Label();
            this.lblNumeroAhorro = new System.Windows.Forms.Label();
            this.btnCobrarComision = new System.Windows.Forms.Button();
            this.btnCalcularIntereses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaldoCorriente
            // 
            this.lblSaldoCorriente.AutoSize = true;
            this.lblSaldoCorriente.Location = new System.Drawing.Point(30, 30);
            this.lblSaldoCorriente.Name = "lblSaldoCorriente";
            this.lblSaldoCorriente.Size = new System.Drawing.Size(108, 17);
            this.lblSaldoCorriente.TabIndex = 0;
            this.lblSaldoCorriente.Text = "Saldo Corriente:";
            // 
            // lblNumeroCorriente
            // 
            this.lblNumeroCorriente.AutoSize = true;
            this.lblNumeroCorriente.Location = new System.Drawing.Point(30, 60);
            this.lblNumeroCorriente.Name = "lblNumeroCorriente";
            this.lblNumeroCorriente.Size = new System.Drawing.Size(123, 17);
            this.lblNumeroCorriente.TabIndex = 1;
            this.lblNumeroCorriente.Text = "Número Corriente:";
            // 
            // lblSaldoAhorro
            // 
            this.lblSaldoAhorro.AutoSize = true;
            this.lblSaldoAhorro.Location = new System.Drawing.Point(30, 120);
            this.lblSaldoAhorro.Name = "lblSaldoAhorro";
            this.lblSaldoAhorro.Size = new System.Drawing.Size(90, 17);
            this.lblSaldoAhorro.TabIndex = 2;
            this.lblSaldoAhorro.Text = "Saldo Ahorro:";
            // 
            // lblNumeroAhorro
            // 
            this.lblNumeroAhorro.AutoSize = true;
            this.lblNumeroAhorro.Location = new System.Drawing.Point(30, 150);
            this.lblNumeroAhorro.Name = "lblNumeroAhorro";
            this.lblNumeroAhorro.Size = new System.Drawing.Size(105, 17);
            this.lblNumeroAhorro.TabIndex = 3;
            this.lblNumeroAhorro.Text = "Número Ahorro:";
            // 
            // btnCobrarComision
            // 
            this.btnCobrarComision.Location = new System.Drawing.Point(30, 90);
            this.btnCobrarComision.Name = "btnCobrarComision";
            this.btnCobrarComision.Size = new System.Drawing.Size(150, 30);
            this.btnCobrarComision.TabIndex = 4;
            this.btnCobrarComision.Text = "Cobrar Comisión";
            this.btnCobrarComision.UseVisualStyleBackColor = true;
            this.btnCobrarComision.Click += new System.EventHandler(this.btnCobrarComision_Click);
            // 
            // btnCalcularIntereses
            // 
            this.btnCalcularIntereses.Location = new System.Drawing.Point(30, 180);
            this.btnCalcularIntereses.Name = "btnCalcularIntereses";
            this.btnCalcularIntereses.Size = new System.Drawing.Size(150, 30);
            this.btnCalcularIntereses.TabIndex = 5;
            this.btnCalcularIntereses.Text = "Calcular Intereses";
            this.btnCalcularIntereses.UseVisualStyleBackColor = true;
            this.btnCalcularIntereses.Click += new System.EventHandler(this.btnCalcularIntereses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnCalcularIntereses);
            this.Controls.Add(this.btnCobrarComision);
            this.Controls.Add(this.lblNumeroAhorro);
            this.Controls.Add(this.lblSaldoAhorro);
            this.Controls.Add(this.lblNumeroCorriente);
            this.Controls.Add(this.lblSaldoCorriente);
            this.Name = "Form1";
            this.Text = "Gestión de Cuentas Bancarias";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSaldoCorriente;
        private System.Windows.Forms.Label lblNumeroCorriente;
        private System.Windows.Forms.Label lblSaldoAhorro;
        private System.Windows.Forms.Label lblNumeroAhorro;
        private System.Windows.Forms.Button btnCobrarComision;
        private System.Windows.Forms.Button btnCalcularIntereses;
    }
}
