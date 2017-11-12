using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MineracaoReclamacoes
    {
        string[] link = new string[20];

        public void imprimirLink(HashSet<string> lista)
        {
            int i = 0;
            foreach (string item in lista)
            {
                string item2 = item.Replace("\"", "").Replace("</div>\n<a href=", "");
                link[i++] = item2;
                if (link[0] != null)
                {
                    link1 = link[0];
                }
                if (link[1] != null)
                {
                    link2 = link[1];
                }
                if (link[2] != null)
                {
                    link3 = link[2];
                }
                if (link[3] != null)
                {
                    link4 = link[3];
                }
                if (link[4] != null)
                {
                    link5 = link[4];
                }
                if (link[5] != null)
                {
                    link6 = link[5];
                }
                if (link[6] != null)
                {
                    link7 = link[6];
                }
                if (link[7] != null)
                {
                    link8 = link[7];
                }
                if (link[8] != null)
                {
                    link9 = link[8];
                }
                if (link[9] != null)
                {
                    link10 = link[9];
                }
            }
        }

        string link1;
        string link2;
        string link3;
        string link4;
        string link5;
        string link6;
        string link7;
        string link8;
        string link9;
        string link10;

        public string[] getLink()
        {
            return link;
        }
        public string getLink1()
        {
            return link1;
        }
        public void setLink1(string link1)
        {
            this.link1 = link1;
        }
        public string getLink2()
        {
            return link2;
        }
        public string getLink3()
        {
            return link3;
        }
        public string getLink4()
        {
            return link4;
        }
        public string getLink5()
        {
            return link5;
        }
        public string getLink6()
        {
            return link6;
        }
        public string getLink7()
        {
            return link7;
        }
        public string getLink8()
        {
            return link8;
        }
        public string getLink9()
        {
            return link9;
        }
        public string getLink10()
        {
            return link10;
        }

        string titulo;
        public string getTitulo()
        {
            return titulo;
        }
        public void imprimirTitulo(HashSet<string> lista)
        {
            foreach (var item in lista)
            {
                string item2 = item;
                byte[] bytes = Encoding.Default.GetBytes(item2);
                item2 = Encoding.UTF8.GetString(bytes);
                RemocaoString remocaostring = new RemocaoString();
                item2 = remocaostring.trocarCharEspeciais(item2);
                item2 = remocaostring.removerSujeira(item2);
                item2 = item2.TrimStart();
                item2 = item2.TrimEnd();
                titulo = item2;
            }
        }

        string texto;
        public string getTexto()
        {
            return texto;
        }
        public void imprimirTexto(HashSet<string> lista)
        {
            foreach (var item in lista)
            {
                string item2 = item;
                byte[] bytes = Encoding.Default.GetBytes(item2);
                item2 = Encoding.UTF8.GetString(bytes);
                RemocaoString remocaostring = new RemocaoString();
                item2 = remocaostring.trocarCharEspeciais(item2);
                item2 = remocaostring.removerSujeira(item2);
                item2 = item2.Replace("Descrição da reclamação", "");
                item2 = item2.TrimStart();
                item2 = item2.TrimEnd();
                texto = item2;
            }
        }

        string data;
        public string getData()
        {
            return data;
        }
        public void imprimirData(HashSet<string> lista)
        {
            foreach (var item in lista)
            {
                string item2 = item;
                RemocaoString remocaostring = new RemocaoString();
                item2 = remocaostring.removerSujeira(item2);
                item2 = item2.TrimEnd();
                item2 = item2.TrimStart();
                data = item2;
            }
        }
    }
}
