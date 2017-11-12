using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Gravacao
    {
        public void gravarReclamacoes(Expressao expressao, List<string> links, string http, string titulo, string texto, string data)
        {
            string doc;
            string exp;
            string reclamacao;
            int i = 0;
            foreach (string link in links)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(@"C:\\Users\\Anderson\\Documents\\Docs FCA\\" + i++ + ".txt", true, System.Text.Encoding.GetEncoding(1252));
                    MineracaoReclamacoes mineracaoReclamacoes = new MineracaoReclamacoes();
                    Colecao colecao = new Colecao();
                    DownloadHTML dh = new DownloadHTML();
                    string linkCompleto = "https://www.proteste.org.br" + link;
                    dh.baixarHTML(linkCompleto);
                    doc = dh.getHttp();

                    exp = expressao.getExpressaoTitulo();
                    mineracaoReclamacoes = colecao.listarTitulos(mineracaoReclamacoes, exp, linkCompleto, doc);
                    titulo = mineracaoReclamacoes.getTitulo();

                    exp = expressao.getExpressaoTexto();
                    mineracaoReclamacoes = colecao.listarTexto(mineracaoReclamacoes, exp, http, doc);
                    texto = mineracaoReclamacoes.getTexto();

                    exp = expressao.getExpressaoData();
                    mineracaoReclamacoes = colecao.listarDatas(mineracaoReclamacoes, exp, http, doc);
                    data = mineracaoReclamacoes.getData();
                    //.Substring(0, 10) + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ".000";

                    writer.WriteLine(titulo);
                    writer.WriteLine();
                    writer.WriteLine(data);
                    writer.WriteLine();
                    writer.WriteLine(texto);
                    writer.WriteLine();

                    writer.Close();

                    reclamacao = link;
                    
                } catch
                {

                }
            }
        }
    }
}
