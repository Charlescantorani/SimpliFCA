using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Expressao
    {
        string expressaoLink;
        public string getExpressaoLink()
        {
            return expressaoLink;
        }
        public void setExpressaoLink(string expressaoLink)
        {
            this.expressaoLink = expressaoLink;
        }

        string expressaoTitulo;
        public string getExpressaoTitulo()
        {
            return expressaoTitulo;
        }
        public void setExpressaoTitulo(string expressaoTitulo)
        {
            this.expressaoTitulo = expressaoTitulo;
        }

        string expressaoData;
        public string getExpressaoData()
        {
            return expressaoData;
        }
        public void setExpressaoData(string expressaoData)
        {
            this.expressaoData = expressaoData;
        }

        string expressaoTexto;
        public string getExpressaoTexto()
        {
            return expressaoTexto;
        }
        public void setExpressaoTexto(string expressaoTexto)
        {
            this.expressaoTexto = expressaoTexto;
        }
    }
}
