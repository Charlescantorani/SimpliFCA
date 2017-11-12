using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ListaLinks
    {
        public List<string> listar(MineracaoReclamacoes mineracao)
        {
            List<string> links = new List<string>();

            if (mineracao.getLink1() != null)
            {
                links.Add(mineracao.getLink1());
            }
            if (mineracao.getLink2() != null)
            {
                links.Add(mineracao.getLink2());
            }
            if (mineracao.getLink3() != null)
            {
                links.Add(mineracao.getLink3());
            }
            if (mineracao.getLink4() != null)
            {
                links.Add(mineracao.getLink4());
            }
            if (mineracao.getLink5() != null)
            {
                links.Add(mineracao.getLink5());
            }
            if (mineracao.getLink6() != null)
            {
                links.Add(mineracao.getLink6());
            }
            if (mineracao.getLink7() != null)
            {
                links.Add(mineracao.getLink7());
            }
            if (mineracao.getLink8() != null)
            {
                links.Add(mineracao.getLink8());
            }
            if (mineracao.getLink9() != null)
            {
                links.Add(mineracao.getLink9());
            }
            if (mineracao.getLink10() != null)
            {
                links.Add(mineracao.getLink10());
            }
            return links;
        }
    }
}
