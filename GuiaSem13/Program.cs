using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaSem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
     

            int opcion = Pantallas.MostarMenu();
            do
            {

                Console.Clear();
               
               
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.NivelSatisfaccion();
                        break;
                    case 2:
                        opcion = Pantallas.VerDatos();
                        break;
                    case 3:
                        opcion = Pantallas.EliminarDato();
                        break;
                    case 4:
                        opcion = Pantallas.OrdenarDatos();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.MostarMenu();
                        break;

                }
            }while (opcion !=5);


                }

      
    }
}
