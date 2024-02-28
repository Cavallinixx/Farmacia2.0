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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }//fim do for 

        private void entrar_Click(object sender, EventArgs e)
        {
            MenuEntrar ent = new MenuEntrar();
            ent.ShowDialog();
          

        }//fim do entrar

        private void cadastrar_Click_1(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Aparecer a tela cadastrar
        }//fim do cadastrar

        private void sair_Click(object sender, EventArgs e)
        {

        }//fim do fim

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }//fim sair

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }//fim do metodo 
}//fim do projeto 

