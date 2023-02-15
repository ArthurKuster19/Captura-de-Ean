using Captura_de_Ean.Classes;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Captura_de_Ean.Metodos
{
    internal class Consultas
    {
        public string retorno = "";


        public string BuscaEanPrincipal(string ean)
        {
            BuscaEan busca = new BuscaEan();
            busca.ean = ean;
            string url = "https://www.google.com/search?tbm=shop&hl=pt-BR&psb=1&ved=2ahUKEwjb39PAlJX9AhWmVEgAHTzlC7QQu-kFegQIABAL&q=" + busca.ean;
            var navegador = new ChromeDriver();
            navegador.Navigate().GoToUrl(url);
            List<BuscaEan> listaPedidos = new List<BuscaEan>();
            var listaPrecoProdutos = navegador.FindElements(By.ClassName("a8Pemb")).ToList();
            var listaNomeProdutos = navegador.FindElements(By.ClassName("tAxDx")).ToList();
            var listaCanalProdutos = navegador.FindElements(By.ClassName("aULzUe")).ToList();
            var qtdProdutos = listaNomeProdutos.Count();

            for (int i = 0; i < qtdProdutos; i++)
            {
                listaPedidos.Add(new BuscaEan
                {
                    nomeProduto = listaNomeProdutos[i].Text,
                    preco = listaPrecoProdutos[i].Text,
                    marketplace = listaCanalProdutos[i].Text
                });

               retorno += ($"{listaPedidos[i].nomeProduto}" + " " + $"{listaPedidos[i].preco}" + " " + $"{listaPedidos[i].marketplace}" + "\n");

            }

            return retorno;
        }
       
        public string BuscarEanAnalytics(string ean)
        {
            BuscaEan busca = new BuscaEan();            
            busca.ean = ean;
            string url = "https://www.google.com/search?tbm=shop&hl=pt-BR&psb=1&ved=2ahUKEwjb39PAlJX9AhWmVEgAHTzlC7QQu-kFegQIABAL&q=" + busca.ean;
            var navegador = new ChromeDriver();
            navegador.Navigate().GoToUrl(url);
            var entrarAnalise = navegador.FindElements(By.ClassName("iXEZD")).ToList();

            return var;
            
        }
    }
}
