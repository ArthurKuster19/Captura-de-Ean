using Captura_de_Ean.Classes;
using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Collections.Generic;
using Captura_de_Ean.Metodos;
using Newtonsoft.Json;
//using Microsoft.Office.Interop.Excel;

namespace Captura_de_Ean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas novaConsulta = new Consultas();
            var retornoConsulta = novaConsulta.BuscaEanPrincipal(textBox1.Text);
            richTextBox1.Text = retornoConsulta; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultas novaConsulta = new Consultas();
            var retornoJson = "";
            var retorno = "";
            var retornoConsulta = novaConsulta.BuscarEanAnalise(textBox1.Text);

                if (this.checkBox1.Checked)
            {
                var jsonRetorno = JsonConvert.SerializeObject(retornoConsulta);
                richTextBox1.Text = jsonRetorno.ToString();
            }
            else
            {
                foreach (BuscaEan b in retornoConsulta)
                {
                    retorno += ($"{b.nomeProduto}" + " " + $"{b.preco}" + " " + $"{b.marketplace}" + " " + $"{b.idGoogle}" + "\n");
                }
                richTextBox1.Text = retorno;
            }
        }
    }
}