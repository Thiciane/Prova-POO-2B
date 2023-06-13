using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_2b_POO
{
    public partial class Correcao : Form
    {
        public Correcao()
        {
            InitializeComponent();
            lb_acertos.Text = "";
        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
            Acertos();

        }

        /*
         *  Tentativa de ErrorProvider
         *  S
         * public bool valid;
        public bool erroProvider()
        {
            if (txB_questao1.Text == null || txB_questao1.Text == "")
            {
                errorProvider1.Icon() = "erro";
                return false;
            }
            if (txB_questao2.Text == null || txB_questao2.Text == "")
            {
                errorProvider1.GetIconPadding() = "erro";
                return false;
            }
            if (txB_questao3.Text == null || txB_questao3.Text == "")
            {
                errorProvider1.GetIconPadding() = "erro";
                return false;

            }
            if (txB_questao4.Text == null || txB_questao4.Text == "")
            {
                errorProvider1.GetIconPadding() = "erro";
                return false;

            }
            if (txB_questao5.Text == null || txB_questao5.Text == "")
            {
                errorProvider1.GetIconPadding() = "erro";
                return false;

            }
            if (txB_questao6.Text == null || txB_questao6.Text == "")
            {
                errorProvider1.GetIconPadding() = "erro";
                return false;

            }
            if (txB_questao7.Text == null || txB_questao7.Text == "")
            {
                errorProvider1.GetIconPadding() = "erro";
                return false;

            }
            if (txB_questao8.Text == null || txB_questao8.Text == "")
            {
                errorProvider1.GetIconPadding() = "erro";
                return false;

            }
            if (txB_questao9.Text == null || txB_questao9.Text == "")
            {
                errorProvider1.GetIconPadding() = "erro";
                return false;

            }
            if (txB_questao10.Text == null || txB_questao10.Text == "")
            {
                errorProvider1.GetIconPadding() = "erro";
                return false;

            }
            return valid;    
        }*/

        private string Acertos()
        {
            try
            {
                string[] aluno = { $"{txB_questao1.Text}", $"{txB_questao2.Text}", $"{txB_questao3.Text}", $"{txB_questao4.Text}", $"{txB_questao5.Text}", $"{txB_questao6.Text}", $"{txB_questao7.Text}", $"{txB_questao8.Text}", $"{txB_questao9.Text}", $"{txB_questao10.Text}" };
                Gabarito gabarito = new Gabarito();
                return lb_acertos.Text = $"Acertos: {gabarito.Correcaoo(aluno)}";
            }
            catch (Exception ex)
            {
                return $"{MessageBox.Show("erro")}";
            }
            
        }
    }
}
