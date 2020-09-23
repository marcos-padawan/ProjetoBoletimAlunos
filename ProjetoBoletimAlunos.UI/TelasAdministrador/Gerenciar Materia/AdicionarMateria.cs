using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Materia
{
    public partial class Form_AdicionarMateria : Form
    {
        public Form_AdicionarMateria()
        {
            InitializeComponent();
            Cmb_SituacaoMateria.Items.Add("Ativo");
            Cmb_SituacaoMateria.Items.Add("Inativo");
        }
        private void btn_SalvarNovaMateria_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(txt_DataCadastroMateria.SelectionRange.Start.ToString()) <= DateTime.Today)
            {
                Materia novaMatéria = new Materia()
                {
                    Descrição = txt_NomeMateria.Text,
                    DataCadastro = Convert.ToDateTime(txt_DataCadastroMateria.SelectionRange.Start.ToString()),
                    Situação = Cmb_SituacaoMateria.Text

                };
                var novaMatériaJson = JsonConvert.SerializeObject(novaMatéria);
                StringContent content = new StringContent(novaMatériaJson, Encoding.UTF8, "application/json");

                var httpClient = new HttpClient();
                var URL = "https://localhost:44306/Materia/AddMateria";
                var resultRequest = httpClient.PostAsync($"{URL}", content);
                resultRequest.Wait();

                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();

                MessageBox.Show("Deu boa campeão!");

                txt_NomeMateria.Text = "";
                Cmb_SituacaoMateria.Text = "";
            }
            else
                MessageBox.Show("Data inserida é superior ao dia de hoje, favor inserir outra.");
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
