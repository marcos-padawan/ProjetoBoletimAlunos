using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Curso
{
    public partial class Form_AdicionarCurso : Form
    {
        public Form_AdicionarCurso()
        {
            InitializeComponent();

            Cmb_SituacaoCurso.Items.Add("Ativo");
            Cmb_SituacaoCurso.Items.Add("Inativo");
        }
    }
}
