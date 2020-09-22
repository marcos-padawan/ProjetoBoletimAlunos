using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
using System;
using System.Net.Http;
using System.Text;
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
        private void btn_SalvarRegistroCurso_Click(object sender, EventArgs e)
        {
            
                Curso novoCurso = new Curso()
                {
                    NomeCurso = txt_NomeCurso.Text,
                    Situação = Cmb_SituacaoCurso.Text
                };
                var novoCursoJson = JsonConvert.SerializeObject(novoCurso);
                StringContent content = new StringContent(novoCursoJson, Encoding.UTF8, "application/json");

                var httpClient = new HttpClient();
                var URL = "https://localhost:44306/Curso/AddCurso";
                var resultRequest = httpClient.PostAsync($"{URL}", content);
                resultRequest.Wait();

                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();


                MessageBox.Show("Deu boa campeão!");

                txt_NomeCurso.Text = "";
                Cmb_SituacaoCurso.Text = "";
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
