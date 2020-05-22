using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Atleta2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        Atleta obj = new Atleta();

        private void btn_calc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados Obtidos: " + obj.ImprimeDados() + "\nIMC: " + obj.CalcularIMC().ToString());
            lbl_imc.Text = obj.CalcularIMC().ToString("0.00");

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txtNome.Text;
                obj.Altura = double.Parse(txtAltura.Text);
                obj.Idade = int.Parse(txtIdade.Text);
                obj.Peso = double.Parse(txtPeso.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro de execução.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
