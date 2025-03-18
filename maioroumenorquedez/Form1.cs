using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class frmMaiorouMenorqueDez : Form
    {
        public frmMaiorouMenorqueDez()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int Valor = (int.Parse(txtMaiorouMenorqueDez.Text));

            if (Valor > 10)
            {
                MessageBox.Show("O valor é maior que 10", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Valor < 10)
            {
                MessageBox.Show("O valor é menor que 10", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if ( Valor == 10)
            {
                MessageBox.Show("O valor é igual a 10", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else 
            {
                MessageBox.Show("Por favor, digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }
    } 
}
