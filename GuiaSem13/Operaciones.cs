using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaSem13
{
    public class Operaciones
    {
        
        public static int getEntero(string prefijo, string reemplazo)
        {

            int respuesta = 0;
            bool correcto = false;

            do
            {
                string numeroTexto = getTextoPantalla(prefijo);
                correcto = int.TryParse(numeroTexto, out respuesta);
                if (!correcto)
                {
                    Console.Clear();
                    Console.Write(reemplazo);
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);

            return respuesta;

        }

        public static float getDecimal(string prefijo)
        {
            float respuesta = 0;
            bool correcto = false;

            do
            {
                string numeroTexto = getTextoPantalla(prefijo);
                correcto = float.TryParse(numeroTexto, out respuesta);
                if (!correcto)
                {
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);

            return respuesta;
        }

        public static string getTextoPantalla(string prefijo)
        {
            Console.Write(prefijo);
            return Console.ReadLine();
        }

        public static int ObtenerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                Console.Write("Ingrese una opción: ");
            }
            return opcion;
        }
    }
}
