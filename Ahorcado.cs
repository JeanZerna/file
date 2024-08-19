using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhorcadoPalabras;


namespace ahorcadoString
{
    class Program
    {
        static void Main(string[] args)
        {

            ahorcado();

            


            Console.ReadKey();
        }

        public static void ahorcado()
        {
            int cont = 7;

            GeneradorPalabras palabra = new GeneradorPalabras();

            String palabraGenerada = palabra.SiguientePalabra;
            StringBuilder adivinar = new StringBuilder(palabraGenerada);
            

            int longitud = palabraGenerada.Length;
            longitud = longitud / 2;

            palabraGenerada.ToCharArray();


            for (int i = 0; i < palabraGenerada.Length; i++)
            {
                if (i == longitud || i == palabraGenerada.Length - 1)
                {
                    adivinar[i] = palabraGenerada[i];
                }
                else
                {
                    adivinar[i] = '_';
                }

            }

            Console.WriteLine("Palabra a adivinar: ");
            for (int i = 0; i < palabraGenerada.Length; i++)
            {
                Console.Write(" {0}", adivinar[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            while (cont > 0)
            {
                Console.WriteLine("Dame una letra");
                char letra = Convert.ToChar(Console.ReadLine());
                bool esIgual = false;

                for (int i = 0; i < palabraGenerada.Length; i++)
                {
                    if(letra == palabraGenerada[i])
                    {
                        adivinar[i] = letra;
                        esIgual = true;
                    }
                }

                if (esIgual)
                {
                    Console.WriteLine("Acertaste!");
                    for (int i = 0; i < palabraGenerada.Length; i++)
                    {
                        Console.Write(" {0}", adivinar[i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("No has acertado");
                    cont--;
                }

                bool terminoElJuego = true;
                for(int i = 0; i < palabraGenerada.Length; i++)
                {
                    if(adivinar[i] == '_')
                    {
                        terminoElJuego = false;
                    }
                }

                if (terminoElJuego)
                {
                    Console.WriteLine("GANASTE!!");
                    break;

                }

            }

        }
    }
}
