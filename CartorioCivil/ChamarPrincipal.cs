using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartorioCivil
{
    public class ChamarPrincipal
    {
        Form1 form = new Form1();

        public void Fechar()
        {
            form.Close();
        }

        public void Abrir()
        {
            form.Show();
        }
    }
}
