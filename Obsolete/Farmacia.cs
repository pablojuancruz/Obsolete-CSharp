using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsolete
{
    public class Farmacia
    {
        public List<string> ListaRemedios{ get; set; }

        [Obsolete("Usar Método ExisteRemedioContains")]
        public bool ExisteRemedio(string nome)
        {
            foreach (var remedio in ListaRemedios)
            {
                if (remedio == nome)
                    return true;
            }

            return false;
        }

        public bool ExisteRemedioContains(string nome)
        {
            return ListaRemedios.Contains(nome);
        }


        
    }
}
