using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Materia
{
    public partial class Form_AlterarOuExcluirMateria : Form
    {
        public Form_AlterarOuExcluirMateria()
        {
            InitializeComponent();
        }

        private void btn_BuscarMateria_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Materia/BuscaMateriaPorDescricao";
            var resultRequest = httpClient.GetAsync($"{URL}?descricao={txt_DescricaoMateriaBuscar.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            foreach (var item in data)
            {
                txt_SituacaoMateriaBuscar.Text = item.Situação;
                txt_DataCadastroMateriaBuscar.Text = Convert.ToString(item.DataCadastro);
            }
        }

        private void btn_ExcluirMateria_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Materia/DeleteMateria";
            var resultRequest = httpClient.DeleteAsync($"{URL}?descricao={txt_DescricaoMateriaBuscar.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            MessageBox.Show("Deu boa campeão!");

            txt_SituacaoMateriaBuscar.Text = "";
            txt_DescricaoMateriaBuscar.Text = "";
            txt_DataCadastroMateriaBuscar.Text = "";

        }
        
        private void btn_AlterarMateria_Click(object sender, EventArgs e)
        {
            Materia novaMatéria = new Materia()
            {
                Descrição = txt_NovoNomeMateria.Text,
                DataCadastro = Convert.ToDateTime(txt_DataCadastroMateriaBuscar.Text),
                Situação = txt_SituacaoMateriaBuscar.Text

            };
            var novaMatériaJson = JsonConvert.SerializeObject(novaMatéria);
            StringContent content = new StringContent(novaMatériaJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Materia/UpdateMateria";
            var resultRequest = httpClient.PutAsync($"{URL}?descricaoMateria={txt_DescricaoMateriaBuscar.Text}" +
                $"&novoMateria={txt_NovoNomeMateria.Text}" +
                $"&novaSituacao={txt_SituacaoMateriaBuscar.Text}" +
                $"&novaData={Convert.ToDateTime(txt_DataCadastroMateriaBuscar.Text)}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            MessageBox.Show("Deu boa campeão!");

            txt_SituacaoMateriaBuscar.Text = "";
            txt_DescricaoMateriaBuscar.Text = "";
            txt_DataCadastroMateriaBuscar.Text = "";
            txt_NovoNomeMateria.Text = "";
        }
        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private class Root
        {
            public List<Materia> Data { get; set; }
        }
    }
}

