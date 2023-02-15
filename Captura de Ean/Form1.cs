using Captura_de_Ean.Classes;
using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Collections.Generic;
using Captura_de_Ean.Metodos;
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
            var retornoConsulta = novaConsulta.BuscarEanAnalytics(textBox1.Text);
            richTextBox1.Text = retornoConsulta;
        }

    }
}