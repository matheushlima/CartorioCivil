using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CartorioCivil
{
    public partial class Casamento : Form
    {
        public Casamento()
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            string cs = @"URI=file:" + Directory.GetCurrentDirectory() + @"\SQLite\Cartorio.db";

            if (txtCasamento.Text == "" || txtNomeC1.Text == "" || txtNomeC2.Text == "" || txtNascimentoC1.Text == "" || txtDataC2.Text == "" || txtCpfC1.Text == "" || txtCpfC2.Text == "")
            {
                MessageBox.Show("Favor preencher os campos:\n- Data do casamento\n- Nome\n- CPF\n- Data do nascimento.\n(Cônjuge 1 ou Cônjuge 2)", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    var con = new SQLiteConnection(cs);
                    con.Open();

                    var cmd = new SQLiteCommand(con);

                    //Comando para inserir dados no BD
                    try
                    {
                        cmd.CommandText = "INSERT INTO CASAMENTO (dt_registro, dt_casamento, nome_cg_um, dt_nascimento_cg_um, cpf_cg_um, nome_pai_cg_um, nome_mae_cg_um, dt_nascimento_pai_cg_um," +
                                                               "dt_nascimento_mae_cg_um, cpf_pai_cg_um, cpf_mae_cg_um, nome_cg_dois, dt_nascimento_cg_dois, cpf_cg_dois, nome_pai_cg_dois," +
                                                                "nome_mae_cg_dois, dt_nascimento_pai_cg_dois, dt_nascimento_mae_cg_dois, cpf_pai_cg_dois, cpf_mae_cg_dois)" +
                                                                $"VALUES('{txtDataRegistro.Text}','{txtCasamento.Text}','{txtNomeC1.Text}','{txtNascimentoC1.Text}',{txtCpfC1.Text},'{txtNomePaiC1.Text}'" +
                                                                $",'{txtNomeMaeC1.Text}','{txtDataPaiC1.Text}','{txtDataMaeC1.Text}',{txtCPFPaiC1.Text},{txtCPFMaeC1.Text},'{txtNomeC2.Text}'" +
                                                                $",'{txtDataC2.Text}',{txtCpfC2.Text},'{txtNomePaiC2.Text}','{txtNomeMaeC2.Text}','{txtDataPaiC2.Text}','{txtDataMaeC2.Text}'" +
                                                                $",{txtCPFPaiC2.Text},{txtCPFMaeC2.Text});";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Registro Efetuado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //limpa todos os controles do tipo TextBox
                        if (MessageBox.Show("Deseja fazer um novo registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
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
