
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;//operador binario - tabela AND
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            /*CENÁRIO TV50
            *TER      QUI     SAB
            * V   &&   V   =   V
            * V   &&   F   =   F
            * F   &&   V   =   F
            * F   &&   F   =   F
            */

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;//operador binario - tabela OR
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            /*CENÁRIO SORVETE
            *TER      QUI     SAB
            * V   &&   V   =   V
            * V   &&   F   =   V
            * F   &&   V   =   V
            * F   &&   F   =   F
            */

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;//operador binario - - tabela XOR
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            /*CENÁRIO SORVETE XOR OR EXCUSIVO
            *TER      QUI     SAB
            * V   &&   V   =   F
            * V   &&   F   =   V
            * F   &&   V   =   V
            * F   &&   F   =   F
            */

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);//muda o bool de falso para verdadeiro - operador unario
        }
    }
}