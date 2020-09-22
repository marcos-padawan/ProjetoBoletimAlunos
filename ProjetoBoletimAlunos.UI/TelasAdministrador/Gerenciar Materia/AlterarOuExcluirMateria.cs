using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

