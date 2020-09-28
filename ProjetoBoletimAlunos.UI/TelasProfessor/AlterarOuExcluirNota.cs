using Newtonsoft.Json;
using ProjetoBoletimAlunos.Models;
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

namespace ProjetoBoletimAlunos.UI.TelasProfessor
{
    public partial class Form_AlterarOuExcluirNota : Form
    {
        public Form_AlterarOuExcluirNota()
        {
            InitializeComponent();
            ListarAlunos();
            ListarMaterias();
        }

        private void btn_BuscarNotas_Click(object sender, EventArgs e)
        {
            int.TryParse((Regex.Match(cmb_MateriaAlunoBuscar.Text, @"\d+").Value), out int materiaId);
            int.TryParse((Regex.Match(Cmb_TodosAlunos.Text, @"\d+").Value), out int alunoId);

            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Notas/BuscaNotasPorAlunoEMateria";
            var resultRequest = httpClient.GetAsync($"{URL}?idAluno={alunoId}&idMateria={materiaId}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root3>(result.Result).Data;

            if (data is null)
            {
                txt_NotaAlunoBuscar.Text = "Nota não registrada";
            }
            else
            {
                foreach (var item in data)
                {
                    txt_NotaAlunoBuscar.Text = Convert.ToString(item.Nota);
                }
            }

            MessageBox.Show("Busca Realizada com Sucesso!!!");
        }
        private void btn_AlterarNotas_Click(object sender, EventArgs e)
        {
            int.TryParse((Regex.Match(cmb_MateriaAlunoBuscar.Text, @"\d+").Value), out int materiaId);
            int.TryParse((Regex.Match(Cmb_TodosAlunos.Text, @"\d+").Value), out int alunoId);

            Notas novaNota = new Notas()
            {
                Nota = Convert.ToInt32(txt_NotaAlunoBuscar.Text)
            };
            var novaNotaJson = JsonConvert.SerializeObject(novaNota);
            StringContent content = new StringContent(novaNotaJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Notas/UpdateNotas";
            var resultRequest = httpClient.PutAsync($"{URL}?idAluno={alunoId}" +
                $"&idMateria={materiaId}" +
                $"&novaNota={novaNota.Nota}", content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root3>(result.Result).Data;

            MessageBox.Show("Nota Alterada com Sucesso!!!");

            Cmb_TodosAlunos.Text = "";
            cmb_MateriaAlunoBuscar.Text = "";
            txt_NotaAlunoBuscar.Text = "";
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
                Cmb_TodosAlunos.Items.Add($"{item.Id} - {item.Nome} {item.Sobrenome}");
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
                cmb_MateriaAlunoBuscar.Items.Add($"{item.Id} - {item.Descrição}");
            }
        }
        private void btn_EscluirNotas_Click(object sender, EventArgs e)
        {
            int.TryParse((Regex.Match(cmb_MateriaAlunoBuscar.Text, @"\d+").Value), out int materiaId);
            int.TryParse((Regex.Match(Cmb_TodosAlunos.Text, @"\d+").Value), out int alunoId);

            var httpClient = new HttpClient();
            var URL = "https://localhost:44306/Notas/DeleteNotas";
            var resultRequest = httpClient.DeleteAsync($"{URL}?idAluno={alunoId}&idMateria={materiaId}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root3>(result.Result).Data;

            MessageBox.Show("Nota Removida com Sucesso!!!");

            Cmb_TodosAlunos.Text = "";
            cmb_MateriaAlunoBuscar.Text = "";
            txt_NotaAlunoBuscar.Text = "";
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
            public List<Aluno> Data { get; set; }
        }
        private class Root2
        {
            public List<Materia> Data { get; set; }
        }
        private class Root3
        {
            public List<Notas> Data { get; set; }
        }


    }
}
