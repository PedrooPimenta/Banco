using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Busca
{
    internal class GeradorDeDevedores
    {
        public List<string> Geralist()
        {
            List <string> nomes = new List<string>();
            for(int i = 0; i < 30000; i++)
            {
                nomes.Add("Devedor " + i);
            }
            return nomes;
        }
    }
}
