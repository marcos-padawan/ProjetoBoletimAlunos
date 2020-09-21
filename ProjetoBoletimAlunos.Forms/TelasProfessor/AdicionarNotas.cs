using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.Forms.TelasProfessor
{
    public partial class form_AdicionarNotas : Form
    {
        public form_AdicionarNotas()
        {
            InitializeComponent();
        }

        private void form_AdicionarNotas_Load(object sender, EventArgs e)
        {

        }

        private void btn_AdicionarNota_Click(object sender, EventArgs e)
        {
            //Notas novaNota = new Notas()
            //{
            //    Nota = Convert.ToDecimal(txt_NotaAluno.Text),
            //    Alunos =
            //    {
            //        Nome = txt_NomeAluno.Text,
            //        Sobrenome = txt_SobrenomeAluno.Text
            //    },
            //    Matérias =
            //    {
            //        Descrição = txt_MateriaAluno.Text
            //    }
            //};
            Notas novaNota = new Notas();

            novaNota.Nota = Convert.ToDecimal(txt_NotaAluno.Text);
            novaNota.Alunos.Nome = txt_NomeAluno.Text;
            novaNota.Alunos.Sobrenome = txt_SobrenomeAluno.Text;
            novaNota.Materias.Descrição = txt_MateriaAluno.Text;

            var novaNotaJson = JsonConvert.SerializeObject(novaNota);
            StringContent content = new StringContent(novaNotaJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/BoletimUniversidadePDWN/PostNotas";
            var resultRequest = httpClient.PostAsync($"{URL}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Nota inserida com Sucesso!!!");

            txt_MateriaAluno.Text = "";
            txt_NotaAluno.Text = "";
            txt_NomeAluno.Text = "";
            txt_SobrenomeAluno.Text = "";
        }
    }
}
