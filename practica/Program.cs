using System;
using System.Collections.Generic;

/*Enunciado Práctica:

1.1 - Solicitar al usuario que introduzca una cadena de al menos 40 caracteres. Si la longitud de la cadena es menor de 40 caracteres, se mostrará un aviso al usuario, informándole de la longitud actual, y solicitándole que vuelva a introducir una nueva cadena. Por ejemplo: "La cadena introducida posee únicamente XX caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres: ".

1.2 - Una vez tengamos la cadena con el tamaño mínimo deseado, aparecerá un menú para:

•Sustituir una palabra por otra. Para ello, se solicitará introducir, separadas por un espacio, la palabra a sustituir, y la sustituta, mostrándose por pantalla el resultado final.

•Buscar texto en la cadena. Para ello, se solicitará introducir un texto para comprobar si existe o no.

•Buscar texto de inicio en la cadena. Para ello, se solicitará introducir un texto para comprobar si la cadena comienza por el mismo.

1.3- Una vez haya terminado la acción seleccionada del menú, volvemos a solicitar una nueva cadena.
*/
namespace practica

{
    class Program
    {
        static void Main(string[] args)
        {
            String descripcion ="";
            bool descripcionExists = false;
            while (!descripcionExists)
            {
                Console.WriteLine("Introduce una descripción de al menos 40 carácteres");
                descripcion = Console.ReadLine();
                if (descripcion != null && descripcion.Length > 39)
                {
                    descripcionExists = true;
                }

            }
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("********************");
            Console.WriteLine("* Select an action *");
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("1: Cambiar palabras");
            Console.WriteLine("2: Comprobar una palabra");
            Console.WriteLine("3: Comprobar inicio");
            Console.WriteLine("4: Quitar aplicaion");

            String menuSelect = Console.ReadLine();
            
            switch (menuSelect)
            {
                case "1":
                   cambiarPalabra(descripcion);
                    break;
                case "2":
                   comprobarPalabra(descripcion);
                        
                    break;
                case "3":
                   comprobarInicio(descripcion);
                    break;
                case "4": break;
                default:
                    Console.WriteLine("Selección no válid. Elige una opción del 1 al 4.");
                    break;
            }
        }
        private static void cambiarPalabra(String descripcion)
        {
            String result;
            Console.WriteLine("Introduce la palabra sustituta y la palabra a sustituir en el siguiente formato:" +
                "palabra_sustituta palabra_a_sustituir");
            //Tratar inputs no válidos
            String input  = Console.ReadLine();
            String[] palabras = input.Split(' ');
            Console.WriteLine("Palabra sustituta " + palabras[0]);
            Console.WriteLine("Palabra a sustituir " + palabras[1]);
            String sustituta = palabras[0];
            String sustituida = palabras[1];
            result = descripcion.Replace(sustituida, sustituta);
            Console.WriteLine(result);
           
        }
        private static void comprobarPalabra(String descripcion)
        {
            Boolean result;
            Console.WriteLine("Introduce la palabra que quiere buscar");
            String palabra = Console.ReadLine();

            result = descripcion.Contains(palabra);
            if (result)
            {
                Console.WriteLine("La palabra " + palabra + " se encuentra en el texto");
            }
            else
            {
                Console.WriteLine("La palabra " + palabra + " no se encuentra en el texto");
            }
        }
        private static void comprobarInicio(String descripcion)
        {
            Boolean result;
            Console.WriteLine("Introduce la palabra que quiere comprobar si es el inicio");
            String palabra = Console.ReadLine();
            result = descripcion.StartsWith(palabra);
            if (result)
            {
                Console.WriteLine("La descripcion comienza con " + palabra);
            }
            else
            {
                Console.WriteLine("La descripcion no comienza con " + palabra);
            }
        }

    }
    }
