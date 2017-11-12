using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Colecao
    {
        public MineracaoReclamacoes listarLinks(MineracaoReclamacoes mineracao,
                                                string expressao, string portal, string doc)
        {
            HashSet<string> lista = new HashSet<string>();

            MatchCollection matchCollection = Regex.Matches(doc, expressao, RegexOptions.Singleline);
            foreach (Match match in matchCollection)
            {
                lista.Add(match.Value);
            }

            mineracao.imprimirLink(lista);
            return mineracao;
        }
        public MineracaoReclamacoes listarTitulos(MineracaoReclamacoes mineracao, 
                                                  string expressao, string portal, string doc)
        {
            HashSet<string> lista = new HashSet<string>();

            MatchCollection matchCollection = Regex.Matches(doc, expressao, RegexOptions.Singleline);
            foreach (Match match in matchCollection)
            {
                lista.Add(match.Value);
            }

            mineracao.imprimirTitulo(lista);
            return mineracao;
        }
        public MineracaoReclamacoes listarTexto(MineracaoReclamacoes mineracao,
                                                string expressao, string portal, string doc)
        {
            HashSet<string> lista = new HashSet<string>();

            MatchCollection matchCollection = Regex.Matches(doc, expressao, RegexOptions.Singleline);
            foreach (Match match in matchCollection)
            {
                lista.Add(match.Value);
            }

            mineracao.imprimirTexto(lista);
            return mineracao;
        }
        public MineracaoReclamacoes listarDatas(MineracaoReclamacoes mineracao,
                                               string expressao, string portal, string doc)
        {
            HashSet<string> lista = new HashSet<string>();

            MatchCollection matchCollection = Regex.Matches(doc, expressao, RegexOptions.Singleline);
            foreach (Match match in matchCollection)
            {
                lista.Add(match.Value);
            }

            mineracao.imprimirData(lista);
            return mineracao;
        }
    }
}
