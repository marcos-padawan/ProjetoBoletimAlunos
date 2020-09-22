using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasProfessor
{
    public partial class Form_MenuGerenciarNotas : Form
    {
        public Form_MenuGerenciarNotas()
        {
            InitializeComponent();
        }
       
        private void btn_AddNota_Click(object sender, EventArgs e)
        {
            var addNotas= new Form_AdicionarNotas();
            this.Hide();
            addNotas.ShowDialog();
            this.Show();
        }

        private void btn_AlterarOuExcluirNota_Click(object sender, EventArgs e)
        {
            var gerenciarNotas = new Form_AlterarOuExcluirNota();
            this.Hide();
            gerenciarNotas.ShowDialog();
            this.Show();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
