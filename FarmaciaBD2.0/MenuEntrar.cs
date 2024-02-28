using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaBD2._0
{
    public partial class MenuEntrar : Form
    {
        public string cpf;
        
        
        public MenuEntrar()
        {
            InitializeComponent();
            
        }

        private void MenuEntrar_Load(object sender, EventArgs e)
        {

        }//fim menu entrar

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim resposta cpf

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }//fim do voltar

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Aparecer a tela cadastrar
        }//fim do cadastrar

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }//fim do metodo
}//fim do projeto
