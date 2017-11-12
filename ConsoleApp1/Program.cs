using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadHTML dh = new DownloadHTML();
            Expressao expressao = new Expressao();
            Colecao colecao = new Colecao();
            MineracaoReclamacoes mineracaoReclamacoes = new MineracaoReclamacoes();
            ListaLinks listaLinks = new ListaLinks();
            List<string> links = new List<string>();

            string informacoesReclamacao;
            string doc;
            string http;
            string titulo;
            string texto;
            string data;

            http = "https://www.proteste.org.br/reclame/lista-de-reclamacoes-publicas?company=300001006";
            doc = dh.baixarHTML(http);

            expressao.setExpressaoTitulo("<h1 class=\"main__title\">(.+?)</h1>");
            titulo = expressao.getExpressaoTitulo();
            expressao.setExpressaoData("<time class(.+?)</time>");
            data = expressao.getExpressaoData();
            expressao.setExpressaoTexto("<dl class=\"data-summary__section\">(.+?)</dd>");
            texto = expressao.getExpressaoData();
            

            expressao.setExpressaoLink("\"/reclame/lista-de-reclamacoes-publicas/+(.+?)\"");
            informacoesReclamacao = expressao.getExpressaoLink();
            mineracaoReclamacoes = colecao.listarLinks(mineracaoReclamacoes, informacoesReclamacao, http, doc);
            links = listaLinks.listar(mineracaoReclamacoes);



            Gravacao gravacao = new Gravacao();
            gravacao.gravarReclamacoes(expressao, links, http, titulo, texto, data);
        }
    }
}
