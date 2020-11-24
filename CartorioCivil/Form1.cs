using System;
using System.Windows.Forms;

namespace CartorioCivil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Nascimento nascimento = new Nascimento();
        Casamento casamento = new Casamento();
        Relatorio relatorio = new Relatorio();
        Obito obito = new Obito();

        private void btnNascimento_Click(object sender, EventArgs e)
        {
            nascimento.Show();
            this.Hide();
        }

        private void btnCasamento_Click(object sender, EventArgs e)
        {
            casamento.Show();
            this.Hide();
        }

        private void btnObito_Click(object sender, EventArgs e)
        {
            obito.Show();
            this.Hide();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            relatorio.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
