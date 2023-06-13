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
        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
            string[] aluno = {$"{txB_questao1.Text}",$"{txB_questao2.Text}", $"{txB_questao3.Text}", $"{txB_questao4.Text}", $"{txB_questao5.Text}", $"{txB_questao6.Text}", $"{txB_questao7.Text}", $"{txB_questao8.Text}", $"{txB_questao9.Text}", $"{txB_questao10.Text}"};
            Gabarito gabarito = new Gabarito();
            lb_acertos.Text = $"Acertos: {gabarito.Correcaoo(aluno)}";
        }
    }
}
