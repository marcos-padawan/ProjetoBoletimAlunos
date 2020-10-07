using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;

namespace ProjetoBoletimAlunos.UI.TelasProfessor
{
    public partial class Form_AdicionarNotas : Form
    {
        public Form_AdicionarNotas()
        {
            InitializeComponent();
            ListarAlunos();
            ListarMaterias();
        }
        private void btn_AdicionarNota_Click(object sender, EventArgs e)
        {
            int.TryParse((Regex.Match(Cmb_NomeMateria.Text, @"\d+").Value), out int materiaId);
            int.TryParse((Regex.Match(Cmb_NomeCompleto.Text, @"\d+").Value), out int alunoId);
            Notas novaNota = new Notas()
            {
                Nota = Convert.ToDouble(txt_NotaAluno.Text),
                MateriaId = materiaId,
                AlunoId = alunoId
            };
            var novaNotaJson = JsonConvert.SerializeObject(novaNota);
            StringContent content = new StringContent(novaNotaJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Notas/AddNotas";
            var resultRequest = httpClient.PostAsync($"{URL}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Nota inserida com Sucesso!!!");

            Cmb_NomeMateria.Text = "";
            txt_NotaAluno.Text = "";
            Cmb_NomeCompleto.Text = "";
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public void ListarAlunos()
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Aluno/ListarTodosAlunos";
            var resultRequest = httpClient.GetAsync($"{URL}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            foreach (var item in data)
            {
                Cmb_NomeCompleto.Items.Add($"{item.Id} - {item.Nome} {item.Sobrenome}");
            }
        }
        public void ListarMaterias()
        {
            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Materia/ListarTodasMaterias";
            var resultRequest = httpClient.GetAsync($"{URL}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root2>(result.Result).Data;

            foreach (var item in data)
            {
                Cmb_NomeMateria.Items.Add($"{item.Id} - {item.Descrição}");
            }
        }
        private class Root
        {
            public List<Aluno> Data { get; set; }
        }
        private class Root2
        {
            public List<Materia> Data { get; set; }
        }
    }
}
