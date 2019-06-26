using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOJASOM.RELATORIOS
{
    public class relClientes
    {
        public static void relGeralClientes()
        {
            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            List<CAMADAS.MODEL.Cliente> lstClientes = new List<CAMADAS.MODEL.Cliente>();


            lstClientes = dalCli.Select();


            string folder = Funcoes.diretorioPasta();

            string arquivo = folder + @"\RelClientes.html";

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
                sw.WriteLine("<h1>Relatório de Clientes</h1>");
                sw.WriteLine("<hr align=left border: '5px'>");
                sw.WriteLine("<table class='table table - dark'>");
                sw.WriteLine("<tr class='thead-dark'>");
                sw.WriteLine("<th align='left' width='30px'>ID</th>");
                sw.WriteLine("<th align='left' width='150px'>Nome</th>");
                sw.WriteLine("<th align='left' width='180px'>Endereço</th>");
                sw.WriteLine("<th align='left' width='80px'>Telefone</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                foreach (CAMADAS.MODEL.Cliente cliente in lstClientes.ToList())
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-active'>");
                    else sw.WriteLine("<tr class='table-default'>");

                    sw.WriteLine("<td align='left' width='30px'>" + cliente.id + "</th>");
                    sw.WriteLine("<td align='left' width='150px'>" + cliente.nome + "</th>");
                    sw.WriteLine("<td align='left' width='180px'>" + cliente.endereco + "</th>");
                    sw.WriteLine("<td align='left' width='80px'>" + cliente.telefone + "</th>");
                    sw.WriteLine("</tr>");
                    cont++;
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align=left border: '5px'>");
                sw.WriteLine("<h4>Quantidade de Registros Impressos: " + cont.ToString() + "</h4>");
                sw.WriteLine("</body>");
                sw.WriteLine("</HTML>");
            }

            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
