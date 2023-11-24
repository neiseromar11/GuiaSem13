using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaSem13
{
    public class Pantallas
    {
        public static int[] respuestas = new int[100];
        public static int contador = 0;
        public static int MostarMenu()
        {
            string texto = ("================================\r\n" +
                "Encuestas de Calidad\r\n" +
                "================================\r\n" +
                "1: Realizar Encuesta\r\n" +
                "2: Ver datos registrados\r\n" +
                "3: Eliminar un dato\r\n" +
                "4: Ordenar datos de menor a mayor\r\n" +
                "5: Salir\r\n" +
                "================================\r\n");

            Console.Write(texto);

            return Operaciones.getEntero("Ingrese una opción: ", texto);

        }
       

        public static int NivelSatisfaccion()
        {
            string texto=("===================================\r\n" +
                "Nivel de Satisfacción\r\n" +
                "===================================\r\n" +
                "¿Qué tan satisfecho está con la\r\n" +
                "atención de nuestra tienda?\r\n" +
                "1: Nada satisfecho\r\n" +
                "2: No muy satisfecho\r\n" +
                "3: Tolerable\r\n" +
                "4: Satisfecho\r\n" +
                "5: Muy satisfecho\r\n" +
                "===================================\r\n");
            Console.Write(texto);
            int opcion= Operaciones.getEntero("Ingrese una opción: ", texto);
            if (contador == 100)
            {
                Console.WriteLine("La lista ya esta llena");
            }
            respuestas[contador] = opcion;
            contador++;
          

         
            MostrarAgradecimiento();
            Console.ReadLine();
            Console.Clear();
            return MostarMenu();
        }
        public static void MostrarAgradecimiento()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("¡Gracias por participar!");
            Console.WriteLine("===================================");


            Console.WriteLine("Presione una tecla para regresar al menú ...");
            Console.ReadKey();
        }
        public static int VerDatos()
        {
            string texto = ("===================================\r\n" +
                "Ver datos registrados\r\n" +
                "===================================\r\n");
            Console.Write(texto);
            if (contador == 0)
            {
                Console.WriteLine("No hay datos");
            }
            for (int i = 0; i < contador; i++)
            {
                if (i == contador)
                {
                    Console.Write(respuestas[i] + " [] ");
                }
                else
                {
                    Console.Write("[" + respuestas[i] + "] ");
                }

            }

            int per1 = 0;
            int per2 = 0;
            int per3 = 0;
            int per4 = 0;
            int per5 = 0;
            for (int i = 0; i < contador; i++)
            {
                if (respuestas[i] == 1)
                {
                    per1++;
                }
                else if (respuestas[i] == 2)
                {
                    per2++;
                }
                else if (respuestas[i] == 3)
                {
                    per3++;
                }
                else if (respuestas[i] == 4)
                {
                    per4++;
                }
                else
                {
                    per5++;
                }
            }

            Console.Write("\n" + "0" +per1 + " personas: Nada satisfecho" +
               "\n" + "0" + per2 + " personas: No muy satisfecho" +
               "\n" + "0" + per3 + " personas: Tolerable" +
               "\n" + "0" + per4 + " personas: Satisfecho" +
               "\n" + "0" + per5 + " personas: Muy satisfecho");
            Console.ReadLine();
            Console.Clear();

            return MostarMenu();
        }
        public static int EliminarDato()
        {
            string texto = ("===================================\r\n" +
                "Eliminar un dato\r\n" +
                "===================================\r\n\r\n");

            Console.Write(texto);
            for (int i = 0; i < contador; i++)
            {
                Console.Write("00" + i + ":[" + respuestas[i] + "] ");
            }

            string texto1 = "\n================================" +
                "\nIngrese la posición a eliminar:";
            Console.Write(texto1);
            int posicion = int.Parse(Console.ReadLine());

            string texto2 = "\n================================\n";

            Console.Write(texto2);

            int[] nuevoArreglo = new int[contador - 1];

            for (int i = 0; i < contador - 1; i++)
            {
                if (posicion > i)
                {
                    nuevoArreglo[i] = respuestas[i];
                }
                else
                {
                    nuevoArreglo[i] = respuestas[i + 1];
                }

            }

            respuestas = nuevoArreglo;


            for (int i = 0; i < contador - 1; i++)
            {
                Console.Write("00" + i + ":[" + respuestas[i] + "] ");
            }

            Console.ReadKey();
            Console.Clear();
            return MostarMenu();
        }
        public static int OrdenarDatos()
        {
            string texto = "===================================\n" +
              "Ordenar datos\n" +
              "===================================\n";
            Console.Write(texto);

            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + respuestas[i] + "] ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string texto2 = "\n===================================\n";
            Console.Write(texto2);

            int ordenado = 0;
            while (ordenado == 0)
                ordenado = 1;

            for (int i = 0; i < contador; i++)
            {
                for (int j = 0; j < contador - 1; j++)
                {
                    if (respuestas[j] > respuestas[j + 1])
                    {
                        int aux = respuestas[j + 1];
                        respuestas[j + 1] = respuestas[j];
                        respuestas[j] = aux;
                        ordenado = 0;
                    }
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("No extisten notas");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + respuestas[i] + "]");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string texto3 = "\n===================================\n" +
              "Presione una tecla para regresar ...\n";

            Console.Write(texto3);

            Console.ReadLine();
            Console.Clear();

            return MostarMenu();
        }
    }
}
