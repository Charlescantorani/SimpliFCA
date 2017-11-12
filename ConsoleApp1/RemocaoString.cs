using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RemocaoString
    {
        public string trocarCharEspeciais(string texto)
        {
            texto = texto.Replace("&quot;", "\"").Replace("&ldquo;", "\"").Replace("&rdquo;", "\"")
                         .Replace("&ndash;", "-").Replace("&ordf;", "ª").Replace("&ordm;", "º")
                         .Replace("&#39;", "").Replace("&mdash;", "—").Replace("&nbsp;", " ")
                         .Replace("&amp;", "&").Replace("'", "");

            texto = texto.Replace("&#34;", "\"")
                        .Replace("&#66;", "B")
                        .Replace("&#98;", "b")
                        .Replace("&#164;", "¤")
                        .Replace("&#196;", "Ä")
                        .Replace("&#228;", "ä")
                        .Replace("&#35;", "#")
                        .Replace("&#67;", "C")
                        .Replace("&#99;", "c")
                        .Replace("&#165;", "¥")
                        .Replace("&#197;", "Å")
                        .Replace("&#229;", "å")
                        .Replace("&#36;", "$")
                        .Replace("&#68;", "D")
                        .Replace("&#100;", "d")
                        .Replace("&#166;", "¦")
                        .Replace("&#198;", "Æ")
                        .Replace("&#230;", "æ")
                        .Replace("&#37;", "%")
                        .Replace("&#69;", "E")
                        .Replace("&#101;", "e")
                        .Replace("&#167;", "§")
                        .Replace("&#199;", "Ç")
                        .Replace("&#231;", "ç")
                        .Replace("&#38;", "&")
                        .Replace("&#70;", "F")
                        .Replace("&#102;", "f")
                        .Replace("&#168;", "¨")
                        .Replace("&#200;", "È")
                        .Replace("&#232;", "è")
                        .Replace("&#39;", "'")
                        .Replace("&#71;", "G")
                        .Replace("&#103;", "g")
                        .Replace("&#169;", "©")
                        .Replace("&#201;", "É")
                        .Replace("&#233;", "é")
                        .Replace("&#40;", "(")
                        .Replace("&#72;", "H")
                        .Replace("&#104;", "h")
                        .Replace("&#170;", "ª")
                        .Replace("&#202;", "Ê")
                        .Replace("&#234;", "ê")
                        .Replace("&#41;", ")")
                        .Replace("&#73;", "I")
                        .Replace("&#105;", "i")
                        .Replace("&#171;", "«")
                        .Replace("&#203;", "Ë")
                        .Replace("&#235;", "ë")
                        .Replace("&#42;", "*")
                        .Replace("&#74;", "J")
                        .Replace("&#106;", "j")
                        .Replace("&#172;", "¬")
                        .Replace("&#204;", "Ì")
                        .Replace("&#236;", "ì")
                        .Replace("&#43;", "+")
                        .Replace("&#75;", "K")
                        .Replace("&#107;", "k")
                        .Replace("&#173;", "")
                        .Replace("&#205;", "Í")
                        .Replace("&#237;", "í")
                        .Replace("&#44;", ",")
                        .Replace("&#76;", "L")
                        .Replace("&#108;", "l")
                        .Replace("&#174;", "®")
                        .Replace("&#206;", "Î")
                        .Replace("&#238;", "î")
                        .Replace("&#45;", "-")
                        .Replace("&#77;", "M")
                        .Replace("&#109;", "m")
                        .Replace("&#175;", "¯")
                        .Replace("&#207;", "Ï")
                        .Replace("&#239;", "ï")
                        .Replace("&#46;", ".")
                        .Replace("&#78;", "N")
                        .Replace("&#110;", "n")
                        .Replace("&#176;", "°")
                        .Replace("&#208;", "Ð")
                        .Replace("&#240;", "ð")
                        .Replace("&#47;", "/")
                        .Replace("&#79;", "O")
                        .Replace("&#111;", "o")
                        .Replace("&#177;", "±")
                        .Replace("&#209;", "Ñ")
                        .Replace("&#241;", "ñ")
                        .Replace("&#48;", "0")
                        .Replace("&#80;", "P")
                        .Replace("&#112;", "p")
                        .Replace("&#178;", "²")
                        .Replace("&#210;", "Ò")
                        .Replace("&#242;", "ò")
                        .Replace("&#49;", "1")
                        .Replace("&#81;", "Q")
                        .Replace("&#113;", "q")
                        .Replace("&#179;", "³")
                        .Replace("&#211;", "Ó")
                        .Replace("&#243;", "ó")
                        .Replace("&#50;", "2")
                        .Replace("&#82;", "R")
                        .Replace("&#114;", "r")
                        .Replace("&#180;", "´")
                        .Replace("&#212;", "Ô")
                        .Replace("&#244;", "ô")
                        .Replace("&#51;", "3")
                        .Replace("&#83;", "S")
                        .Replace("&#115;", "s")
                        .Replace("&#181;", "µ")
                        .Replace("&#213;", "Õ")
                        .Replace("&#245;", "õ")
                        .Replace("&#52;", "4")
                        .Replace("&#84;", "T")
                        .Replace("&#116;", "t")
                        .Replace("&#182;", "¶")
                        .Replace("&#214;", "Ö")
                        .Replace("&#246;", "ö")
                        .Replace("&#53;", "5")
                        .Replace("&#85;", "U")
                        .Replace("&#117;", "u")
                        .Replace("&#183;", "·")
                        .Replace("&#215;", "×")
                        .Replace("&#247;", "÷")
                        .Replace("&#54;", "6")
                        .Replace("&#86;", "V")
                        .Replace("&#118;", "v")
                        .Replace("&#184;", "¸")
                        .Replace("&#216;", "Ø")
                        .Replace("&#248;", "ø")
                        .Replace("&#55;", "7")
                        .Replace("&#87;", "W")
                        .Replace("&#119;", "w")
                        .Replace("&#185;", "¹")
                        .Replace("&#217;", "Ù")
                        .Replace("&#249;", "ù")
                        .Replace("&#56;", "8")
                        .Replace("&#88;", "X")
                        .Replace("&#120;", "x")
                        .Replace("&#186;", "º")
                        .Replace("&#218;", "Ú")
                        .Replace("&#250;", "ú")
                        .Replace("&#57;", "9")
                        .Replace("&#89;", "Y")
                        .Replace("&#121;", "y")
                        .Replace("&#187;", "»")
                        .Replace("&#219;", "Û")
                        .Replace("&#251;", "û")
                        .Replace("&#58;", ":")
                        .Replace("&#90;", "Z")
                        .Replace("&#122;", "z")
                        .Replace("&#188;", "¼")
                        .Replace("&#220;", "Ü")
                        .Replace("&#252;", "ü")
                        .Replace("&#59;", ";")
                        .Replace("&#91;", "[")
                        .Replace("&#123;", "{")
                        .Replace("&#189;", "½")
                        .Replace("&#221;", "Ý")
                        .Replace("&#253;", "ý")
                        .Replace("&#60;", "<")
                        .Replace("&#92;", "\\")
                        .Replace("&#124;", "|")
                        .Replace("&#190;", "¾")
                        .Replace("&#222;", "Þ")
                        .Replace("&#254;", "þ")
                        .Replace("&#61;", "=")
                        .Replace("&#93;", "]")
                        .Replace("&#125;", "}")
                        .Replace("&#191;", "¿")
                        .Replace("&#223;", "ß")
                        .Replace("&#255;", "ÿ")
                        .Replace("&#62;", ">")
                        .Replace("&#94;", "^")
                        .Replace("&#126;", "~")
                        .Replace("&#192;", "À")
                        .Replace("&#224;", "à")
                        .Replace("&#256;", "Ā")
                        .Replace("&#63;", "?")
                        .Replace("&#95;", "_")
                        .Replace("&#161;", "¡")
                        .Replace("&#193;", "Á")
                        .Replace("&#225;", "á")
                        .Replace("&#64;", "@")
                        .Replace("&#96;", "`")
                        .Replace("&#162;", "¢")
                        .Replace("&#194;", "Â")
                        .Replace("&#226;", "â")
                        .Replace("&#227;", "ã");

            return texto.Replace("&ccedil;", "ç").Replace("&Ccedil;", "Ç").Replace("&iacute;", "í")
                        .Replace("&Iacute;", "í").Replace("&atilde;", "ã").Replace("&Atilde;", "Ã")
                        .Replace("&aacute;", "á").Replace("&Aacute;", "Á").Replace("&agrave;", "à")
                        .Replace("&Agrave;", "À").Replace("&otilde;", "õ").Replace("&Otilde;", "Õ")
                        .Replace("&uacute;", "ú").Replace("&Uacute;", "Ú").Replace("&oacute;", "ó")
                        .Replace("&Oacute;", "Ó").Replace("&eacute;", "é").Replace("&Eacute;", "É")
                        .Replace("&acirc;", "â").Replace("&Acirc;", "Â").Replace("&ecirc;", "ê")
                        .Replace("&Ecirc;", "Ê").Replace("&ocirc;", "ô").Replace("&Ocirc;", "Ô")
                        .Replace("&ntilde;", "ñ").Replace("&Ntilde;", "Ñ").Replace("&egrave;", "è")
                        .Replace("&Egrave;", "È").Replace("&sup3;", "³").Replace("&gt;", ">")
                        .Replace("&lt;", "<").Replace("&sup2;", "²");
        }

        public string removerSujeira(string texto)
        {
            texto = texto.Replace("<h1 class=\"main__title\">", "").Replace("<h1", "").Replace("<time class=\"complaint-t:read__item__date\"", "")
                         .Replace("<dl class=\"data-summary__section\">", "").Replace("<dt class=\"data-summary__property\">", "")
                         .Replace("</dt>", "").Replace("<dd class=\"data-summary__value\">", "").Replace("<p class=\"rich-text\">", "")
                         .Replace("</p>", "").Replace("</dd>", "").Replace("</h1>", "").Replace("</time>", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-10-11\">", "")
                         .Replace("Descrição da reclamação", "").Replace("  ", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-10-06\">", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-07-18\">", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-07-31\">", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-07-05\">", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-05-19\">", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-05-12\">", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-05-10\">", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-04-13\">", "")
                         .Replace("<time class=\"complaint-thread__item__date\" datetime=\"2017-03-16\">", "");

            return texto;// = texto.Replace(">", "").Replace("/", "").Replace("\">", "");
        }
        public string removerTags(string texto)
        {
            string strTexto = texto;
            string strTextoFinal;
            int posicaoiniTag, posicaofimTag;
            bool condicao = true;

            while (condicao == true)
            {
                try
                {
                    //Retira a tag <figure>
                    posicaoiniTag = strTexto.IndexOf("<", 0, StringComparison.InvariantCultureIgnoreCase);
                    posicaofimTag = strTexto.IndexOf("</", posicaoiniTag, StringComparison.InvariantCultureIgnoreCase);
                    strTextoFinal = strTexto.Substring(0, posicaoiniTag);
                    strTextoFinal += strTexto.Substring(posicaofimTag, strTexto.Length - posicaofimTag);
                    strTexto = strTextoFinal;
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

                posicaoiniTag = strTexto.IndexOf("<", 0, StringComparison.InvariantCultureIgnoreCase);
                if (posicaoiniTag > 0)
                {
                    condicao = true;
                }
                else
                {
                    condicao = false;
                }
            }
            return strTexto;
        }
    }
}
