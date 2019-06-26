using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOJASOM.RELATORIOS
{
    public class relProdutos
    {
        public static void relGeralProdutos()
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            List<CAMADAS.MODEL.Produto> lstProdutos = new List<CAMADAS.MODEL.Produto>();


            lstProdutos = bllProd.Select();


            string folder = Funcoes.diretorioPasta();

            string arquivo = folder + @"\RelProdutos.html";

            //IMPRIMIR O RELATÓRIO - GERAR O HTML
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<HTML>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html'; " +
                             "charset='utf-8'>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css' integrity='sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO' crossorigin='anonymous'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório de Produtos</h1>");
                sw.WriteLine("<hr align=left border: '5px'>");
                sw.WriteLine("<table class='table table - dark'>");
                sw.WriteLine("<tr class='thead-dark'>");
                sw.WriteLine("<th align='left' width='30px'>ID</th>");
                sw.WriteLine("<th align='left' width='150px'>Descricao</th>");
                sw.WriteLine("<th align='left' width='120px'>Marca</th>");
                sw.WriteLine("<th align='left' width='60px'>Quantidade</th>");
                sw.WriteLine("<th align='left' width='60px'>Preço</th>");
                sw.WriteLine("<th align='left' width='60px'>Total</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                float totalGeral = 0;
                foreach (CAMADAS.MODEL.Produto produto in lstProdutos.Where(p => p.quantidade < 15).OrderByDescending(p => p.total).ToList())
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-active'>");
                    else sw.WriteLine("<tr class='table-default'>");

                    sw.WriteLine("<td align='left' width='30px'>" + produto.id + "</th>");
                    sw.WriteLine("<td align='left' width='150px'>" + produto.descricao + "</th>");
                    sw.WriteLine("<td align='left' width='120px'>" + produto.marca + "</th>");
                    sw.WriteLine("<td align='left' width='60px'>" + produto.quantidade + "</th>");
                    sw.WriteLine("<td align='letf' width='60px'>" + string.Format("{0:C2}", produto.preco) + "</th>");
                    totalGeral += produto.total;
                    sw.WriteLine("<td align='left' width='60px'>" + string.Format("{0:C2}", produto.total) + "</th>");
                    sw.WriteLine("</tr>");
                    cont++;
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align=left border: '5px'>");
                sw.WriteLine("<h4>Total Geral: " + string.Format("{0:C2}", totalGeral) + "</h4>");
                sw.WriteLine("<br>");
                sw.WriteLine("<h4>Quantidade de Registros Impressos: " + cont.ToString() + "</h4>");
                sw.WriteLine("</body>");
                sw.WriteLine("</HTML>");
            }

            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
