using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaBD2._0
{
    public partial class Cadastrar : Form
    {
        DAO bd;

        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }
        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }//fim do cadastrar
        private void codigoResposta_TextChanged(object sender, EventArgs e)
        {

        }// fim codigo resposta

        private void respostaNome_TextChanged(object sender, EventArgs e)
        {

        }//fim nome

        private void telefoneResposta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim telefone 

        private void rgResposta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim rg resposta

        private void cpfResposta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim cpf
  
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Farma far = new   Farma();
            far.ShowDialog();
            
        }
    }//fim do metodo
}//fim do projeto 