using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CartorioCivil
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        string path = Directory.GetCurrentDirectory();
        public void Voltartela()
        {
            Form1 acao = new Form1();

            acao.Show();
            this.Close();
        }

        private void btnRelatTXT_Click(object sender, EventArgs e)
        {
            StreamWriter z = File.CreateText(Directory.GetCurrentDirectory() + "\\Dados.txt") ;

            string cs = @"URI=file:" + Directory.GetCurrentDirectory() + @"\SQLite\Cartorio.db";

            if (txtDataRegistro.Text == "" || txtDataRegistroAte.Text == "")
            {
                MessageBox.Show("Favor preencher os campos:\n- Data De\n- Data Ate", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    var con = new SQLiteConnection(cs);
                    con.Open();

                    var cmd = new SQLiteCommand(con);

                    cmd.CommandText = $"select * from nascimento where dt_nascimento between '{txtDataRegistro.Text}' and '{txtDataRegistroAte.Text}';";

                    SQLiteDataReader select = cmd.ExecuteReader();

                    z.WriteLine("ID".PadRight(3) + "Nome Registrado".PadRight(52) + "Nome Pai".PadRight(52) + "Nome Mãe".PadRight(52) + "CPF Pai".PadRight(13) + "CPF Mae\n");
                    try
                    {
                        while (select.Read())
                        {
                            z.WriteLine(select["id"].ToString().PadRight(3) + select["nome_registrado"].ToString().PadRight(52) + select["nome_pai"].ToString().PadRight(52) +
                                        select["nome_mae"].ToString().PadRight(52) + select["cpf_pai"].ToString().PadRight(13) + select["cpf_mae"].ToString());
                        }
                        z.Close();
                        con.Close();
                        MessageBox.Show("Relatorio Gerado", "Geração Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error 500:\nConversão do tipo DateTime com erro", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
