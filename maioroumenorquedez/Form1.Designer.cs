
namespace maioroumenorquedez
{
    partial class frmMaiorouMenorqueDez
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaiorouMenorqueDez = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaiorouMenorqueDez
            // 
            this.txtMaiorouMenorqueDez.Location = new System.Drawing.Point(252, 24);
            this.txtMaiorouMenorqueDez.Name = "txtMaiorouMenorqueDez";
            this.txtMaiorouMenorqueDez.Size = new System.Drawing.Size(203, 20);
            this.txtMaiorouMenorqueDez.TabIndex = 0;
            this.txtMaiorouMenorqueDez.Text = "Valor";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(298, 70);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(114, 46);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmMaiorouMenorqueDez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtMaiorouMenorqueDez);
            this.Name = "frmMaiorouMenorqueDez";
            this.Text = "Maior ou Menor que Dez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaiorouMenorqueDez;
        private System.Windows.Forms.Button btnVerificar;
    }
}

