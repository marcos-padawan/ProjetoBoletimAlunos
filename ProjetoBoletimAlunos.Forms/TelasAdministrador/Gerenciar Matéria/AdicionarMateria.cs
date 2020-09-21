using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjetoBoletimAlunos.Forms.Models;

namespace ProjetoBoletimAlunos.Forms.TelasAdministrador.Gerenciar_Matéria
{
    public partial class form_AdicionarMateria : Form
    {
        public form_AdicionarMateria()
        {
            InitializeComponent();
        }

        private void btn_SalvarNovaMateria_Click(object sender, EventArgs e)
        {
            Matéria novaMatéria = new Matéria()
            {
                Descrição = txt_NomeMateria.Text,
                DataCadastro = Convert.ToDateTime(txt_DataCadastroMateria.SelectionRange.Start.ToString()),
                Situação = txt_SituacaoMateria.Text
            };
            var novaMatériaJson = JsonConvert.SerializeObject(novaMatéria);
            StringContent content = new StringContent(novaMatériaJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "http://localhost:5000/Matéria/AddMateria";
            var resultRequest = httpClient.PostAsync($"{URL}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Matéria adicionada com sucesso!");

            txt_NomeMateria.Text = "";
            txt_SituacaoMateria.Text = "";
            
        }
    }
}
