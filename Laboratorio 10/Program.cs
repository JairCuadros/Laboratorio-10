using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int opcion = Boddy.inicio();

            do
            {
                switch (opcion)
                {
                    case 0: Boddy.inicio(); break;
                    case 1: Boddy.ventasMPhone3000(); break;
                    case 2: Boddy.ventasMPhone3500(); break;
                    case 3: Boddy.ventasMPhone3800(); break;
                    case 4: Boddy.ventasMPhone8000(); break;
                    case 5: Boddy.five(); break;
                }
            } while (opcion != 5);
        }
        
    }
}
