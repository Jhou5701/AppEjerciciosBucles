using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEjerciciosBucles.Funcioens
{
    public static class EjemploBucles
    {
        public static string saludar(int limite)
        {
            StringBuilder cad = new StringBuilder("Saludos\n");
            int i = 0;
            while(i<limite)
            {
                i++;
                cad.Append(i.ToString() + ": Hola"+Environment.NewLine);
            }
            return cad.ToString();
        }
        public static long factorial(int num)
        {
            int i = 0;
            long fac = 1;
            if (num == 1 || num == 0)
                return 1;
            do
            {
                i++;
                fac = fac * i;

            } while (i<num);return fac;
        }
        public static long notas(int num)
        {
            Random r = new Random();
            for (int i = 20; i >= 50; i++)
            {
                 num = r.Next(20, 50);
                
            }
            return num;
        }
    }
}
