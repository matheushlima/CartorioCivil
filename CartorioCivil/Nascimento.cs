using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CartorioCivil
{
    public partial class Nascimento : Form
    {
        public Nascimento()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"URI=file:C:\SQLlite\Cartorio.db";
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO NASCIMENTO (Dt_registro,dt_nascimento,Nm_registrado,Nm_pai,Nm_mae,Dt_nascimento_pai,Dt_nascimento_mae,CPF_pai,CPF_mae)" +
                                    $"VALUES('{txtDataRegistro.Text}', '{txtNascimento.Text}', '{txtNomeRegistro.Text}', '{txtNomePai.Text}', '{txtNomeMae.Text}', '{txtDataPai.Text}', '{txtDataMae.Text}', {txtCPFPai.Text}, {txtCPFMae.Text});";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registro Efetuado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChamarPrincipal acao = new ChamarPrincipal();

            acao.Abrir();
            this.Close();
        }
    }
}
