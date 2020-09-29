using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Aluno
{
    public partial class Form_AlterarOuExcluirAluno : Form
    {
        public Form_AlterarOuExcluirAluno()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_BuscarAluno_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Aluno/BuscaAlunoPorNome";
            var resultRequest = httpClient.GetAsync($"{URL}?nome={txt_NomeAlunoBuscar.Text}" +
                $"&sobrenome={txt_SobrenomeAlunoBuscar.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            foreach (var aluno in data)
            {
                txt_CpfAlunoBuscar.Text = aluno.Cpf;
                txt_NascimentoAlunoBuscar.Text = Convert.ToString(aluno.DataNascimento);
            }
        }
        private void btn_ExcluirAluno_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Aluno/DeleteAluno";
            var resultRequest = httpClient.DeleteAsync($"{URL}?nome={txt_NomeAlunoBuscar.Text}" +
                $"&sobrenome={txt_SobrenomeAlunoBuscar.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            MessageBox.Show("Aluno Removido com Sucesso!");

            txt_NomeAlunoBuscar.Text = "";
            txt_SobrenomeAlunoBuscar.Text = "";
            txt_NascimentoAlunoBuscar.Text = "";
            txt_CpfAlunoBuscar.Text = "";
        }

        private void btn_AlterarAluno_Click(object sender, EventArgs e)
        {
            if (txt_CpfAlunoBuscar.Text.Length == 11)
            {
                Aluno novoAluno = new Aluno()
                {
                    Nome = txt_NovoNome.Text,
                    DataNascimento = Convert.ToDateTime(txt_NascimentoAlunoBuscar.Text),
                    Sobrenome = txt_NovoSobrenome.Text,
                    Cpf = txt_CpfAlunoBuscar.Text
                };
                var novoalunoJson = JsonConvert.SerializeObject(novoAluno);
                StringContent content = new StringContent(novoalunoJson, Encoding.UTF8, "application/json");

                var httpClient = new HttpClient();
                var URL = "https://localhost:44306/Aluno/UpdateAluno";
                var resultRequest = httpClient.PutAsync($"{URL}?nome={txt_NomeAlunoBuscar.Text}" +
                    $"&sobrenome={txt_SobrenomeAlunoBuscar.Text}" +
                    $"&novoNome={novoAluno.Nome}" +
                    $"&novoSobrenome={novoAluno.Sobrenome}" +
                    $"&novoCpf={novoAluno.Cpf}" +
                    $"&novoNascimento={novoAluno.DataNascimento}", content);
                resultRequest.Wait();

                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();

                var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

                MessageBox.Show("Aluno alterado com Sucesso!");

                txt_NovoSobrenome.Text = "";
                txt_SobrenomeAlunoBuscar.Text = "";
                txt_NovoNome.Text = "";
                txt_NomeAlunoBuscar.Text = "";
                txt_NascimentoAlunoBuscar.Text = "";
                txt_CpfAlunoBuscar.Text = "";
            }
            else
            {
                MessageBox.Show("Favor inserir um CPF válido.");
            }
        }
        private class Root
        {
            public List<Aluno> Data { get; set; }
        }
    }
}
