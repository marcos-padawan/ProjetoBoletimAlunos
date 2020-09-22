using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Aluno
{
    public partial class Form_AdicionarAluno : Form
    {
        public Form_AdicionarAluno()
        {
            InitializeComponent();
            PoeListaCursos();
        }

        private void btn_SalvarRegistroAluno_Click(object sender, EventArgs e)
        {
            int.TryParse((Regex.Match(Cmb_Cursos.Text, @"\d+").Value), out int cursoId);
            Aluno novoAluno = new Aluno()
            {
                Nome = txt_NomeAluno.Text,
                Sobrenome = txt_SobrenomeAluno.Text,
                DataNascimento = Convert.ToDateTime(txt_NascimentoAluno.SelectionRange.Start.ToString()),
                Cpf = txt_CpfAluno.Text,
                CursoId = cursoId
            };
            var novaMatériaJson = JsonConvert.SerializeObject(novoAluno);
            StringContent content = new StringContent(novaMatériaJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Aluno/AddAluno";
            var resultRequest = httpClient.PostAsync($"{URL}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Deu boa campeão!");

            txt_NomeAluno.Text = "";
            txt_SobrenomeAluno.Text = "";
            txt_CpfAluno.Text = "";
            Cmb_Cursos.Text = "";
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void PoeListaCursos()
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Curso/ListarTodosCursos";
            var resultRequest = httpClient.GetAsync($"{URL}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            foreach(var item in data)
            {
                Cmb_Cursos.Items.Add($"{item.Id} - {item.NomeCurso}");
            }
        }

        private class Root
        {
            public List<Curso> Data { get; set; }
        }
    }
}
