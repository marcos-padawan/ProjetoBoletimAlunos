using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
using System;
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
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Materia>(result.Result);
            //List<Materia> lista = BuscarMateriaPorNome(txt_DescricaoMateriaBuscar.Text);

           // foreach (var pokemon in data)
            {
           //     lista.Add(pokemon);
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
    }
}
