using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeitorPolicial.Hackathon
{
    public partial class Form1 : Form
    {
        IList<string> arquivos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dialogResult = folderBrowser.ShowDialog();

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                txbPasta.Text = folderBrowser.SelectedPath;
                lblArquivosEncontrados.Text = EnumerarArquivos(folderBrowser.SelectedPath);
            }
        }

        private string EnumerarArquivos(string path)
        {
            List<string> arquivosLocal = new List<string>();

            foreach (string caminhoEncontrado in Directory.GetFiles(path, "*.csv", SearchOption.TopDirectoryOnly))
            {

                if (!String.IsNullOrEmpty(caminhoEncontrado))
                    arquivosLocal.Add(caminhoEncontrado);
            }

            arquivos = arquivosLocal;
            return String.Format("Arquivos encontrados: {0}", arquivos.Count);
        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbPasta.Text))
            {
                try
                {
                    IList<DPTotal> total = CalcularTodasDP(arquivos);
                    string json = JsonConvert.SerializeObject(total);
                    GravaArquivo(txbPasta.Text, json);

                    MessageBox.Show("Foi!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Deu pau!");
                }

            }
        }

        private void GravaArquivo(string caminho, string json)
        {
            using (StreamWriter writer = new StreamWriter(String.Format("{0}.json", caminho), false, Encoding.UTF8))
            {
                writer.AutoFlush = true;
                writer.Write(json);
                writer.Close();
            }

        }

        private IList<DPTotal> CalcularTodasDP(IList<string> arquivos)
        {
            List<DPTotal> totalDP = new List<DPTotal>();
            foreach (string caminhoArquivo in arquivos)
            {
                DPTotal DPTotal = CalculaDP(caminhoArquivo);
                totalDP.Add(DPTotal);
            }


            if (totalDP.Count <= 0)
                throw new Exception("Nenhuma ocorrencia encontrada");
            else
                return totalDP;
        }

        private DPTotal CalculaDP(string caminhoArquivo)
        {
            int pularLinhas = 2;
            List<string> linhas = new List<string>();

            using (StreamReader reader = new StreamReader(caminhoArquivo, Encoding.Unicode))
            {
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    if (!String.IsNullOrEmpty(linha))
                        linhas.Add(linha);
                }

                if (pularLinhas > 0)
                    linhas.RemoveRange(0, pularLinhas);
            }

            int ocorrencias = 0;
            foreach (string linha in linhas)
            {
                var mingau = linha.Split(';');
                //tem que ser -2 e o replace pra tirar o ponto
                ocorrencias += Convert.ToInt32(mingau[mingau.Length - 2].Replace(".", ""));
            }

            int id = Convert.ToInt32(caminhoArquivo.Split(' ')[1]);

            return new DPTotal { dp = id, total = ocorrencias };
        }

    }
}
