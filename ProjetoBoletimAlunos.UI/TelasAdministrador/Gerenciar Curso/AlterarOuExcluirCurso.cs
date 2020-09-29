using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Curso
{
    public partial class Form_AlterarOuExcluirCurso : Form
    {
        public Form_AlterarOuExcluirCurso()
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

        private void btn_BuscarCurso_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Curso/BuscaCursoPorNome";
            var resultRequest = httpClient.GetAsync($"{URL}?nome={txt_NomeCursoBusca.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            foreach (var item in data)
            {
                txt_SituacaoCursoBusca.Text = item.Situação;
            }
        }

        private void btn_ExcluirCurso_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Curso/DeleteCurso";
            var resultRequest = httpClient.DeleteAsync($"{URL}?nome={txt_NomeCursoBusca.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            MessageBox.Show("Deu boa campeão!");

            txt_NomeCursoBusca.Text = "";
            txt_SituacaoCursoBusca.Text = "";
        }
      
        private void btn_AlterarCurso_Click(object sender, EventArgs e)
        {
            Curso novoCurso = new Curso()
            {
                NomeCurso = txt_NovoNomecurso.Text,
                Situação = txt_SituacaoCursoBusca.Text
            };
            var novoCursoJson = JsonConvert.SerializeObject(novoCurso);
            StringContent content = new StringContent(novoCursoJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Curso/UpdateCurso";
            var resultRequest = httpClient.PutAsync($"{URL}?nomeCurso={txt_NomeCursoBusca.Text}" +
                $"&novoNome={novoCurso.NomeCurso}" +
                $"&novoStatus={novoCurso.Situação}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            MessageBox.Show("Curso Alterado com Sucesso!!!");

            txt_SituacaoCursoBusca.Text = "";
            txt_NomeCursoBusca.Text = "";
            txt_NovoNomecurso.Text = "";
        }
        private class Root
        {
            public List<Curso> Data { get; set; }
        }
    }
}
