using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5___Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Veiculo v = new Veiculo();
            v.Ano = 2025;

            int x = v.QuantosKms(23);


            Carro c = new Carro();
            c.QuantosKms(23);
            c.QuantasPortas();

            Carro2 c2 = new Carro2();
            float dist = c2.QuantosKms(23);

            Garagem g = new Garagem();  //200 lugares

            g.Estaciona(c2);
            g.Estaciona(c);
       

        }
    }
}
