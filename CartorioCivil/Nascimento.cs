using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CartorioCivil
{
    public partial class Nascimento : Form
    {
        public Nascimento()
        {
            InitializeComponent();
            txtDataRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void Voltartela()
        {
            Form1 acao = new Form1();

            acao.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"URI=file:" + Directory.GetCurrentDirectory() + @"\SQLite\Cartorio.db";

            //Trava para campos obrigatorios não ficarem vazios
            if (txtNascimento.Text == "" || txtNomeRegistro.Text == "")
            {
                MessageBox.Show("Favor preencher os campos:\n- Data do nascimento\n- Nome do registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Tentativa de conexão
                try
                {
                    var con = new SQLiteConnection(cs);
                    con.Open();

                    var cmd = new SQLiteCommand(con);

                    //Comando para inserir no banco de dados
                    try
                    {
                        cmd.CommandText = "INSERT INTO NASCIMENTO (dt_registro,dt_nascimento,nome_registrado,nome_pai,nome_mae,dt_nascimento_pai,dt_nascimento_mae,cpf_pai,cpf_mae)" +
                                            $"VALUES('{txtDataRegistro.Text}', '{txtNascimento.Text}', '{txtNomeRegistro.Text}', '{txtNomePai.Text}', '{txtNomeMae.Text}', '{txtDataPai.Text}', '{txtDataMae.Text}', {txtCPFPai.Text}, {txtCPFMae.Text});";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Registro Efetuado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Mensagem para realizar outro registro ou voltar para tela principal
                        if (MessageBox.Show("Deseja fazer um novo registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //limpa todos os controles do tipo TextBox
                            foreach (Control item in this.Controls)
                            {
                                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(MaskedTextBox))
                                {
                                    item.Text = string.Empty;
                                    txtDataRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                                }
                            }
                        }
                        else
                        {
                            Voltartela();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error 500:\nQuery com erro", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Error 500:\nConexão com o banco não efetuada", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Voltartela();
        }
    }
}
