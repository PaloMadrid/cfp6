using System;
using System.Diagnostics.CodeAnalysis;

namespace tema_arrays
{
    internal class intro_arrays
    {
        static void Main(string[] args)
        {
            //conjunto de datos del mismo tipo

            //static (metodo) void  Main(string[] (tipo de datos que recibe) ( args) (indica que es un punto de entrada de parametros)
            //
            // siempre se definen cpn: el tipo de datos y la cantidad de datos

            //declaracion de arrays

            string[] micadena = new string[4];// guarda conjuntos de palabras "juan" / "14/4/24" / "hoy es un dia soleado" / "15¨*¡=#$%a"
            char[] otracadena = new char[5];// guarda conjuntos de caracteres '4' / 'a' / ' ' / '-'
            int[] arraynumerico = new int[3];// guarda conjuntos de numeros 1 / 2 / 3 / 587 / 1000

            //entrada de valores.
            /* siempre se inicializa en la posicion 0. 
             * la contrabarra (\) se utiliza para directorios y saltos de linea por lo que puede haber conflictos al ingresarla 
             *          \n: intenta gener un salto de linea. \t:inserta una tabulacion 
             */


            //si no se cuantas posiciones tiene mi array? despues lo uso con largo=micadena.Length;
            int largo;

            micadena[0] = "juan";
            micadena[1] = "14/4/24";
            micadena[2] = "hoy es un dia soleado";
            micadena[3] = "15¨*¡=#$%a ";

            // salida de datos
            /* system.string[] -> representa lo que es micadena, dentro de la clase system es un array de string*/


            //Console.WriteLine($"{micadena[0]},{ micadena[1]}, {micadena[2]},{ micadena[3]}");
            //Console.WriteLine(micadena[1]);
            //Console.WriteLine(micadena[2]);
            //Console.WriteLine(micadena[3]);

            //salida de datos sin repeticion de codigo

            largo = micadena.Length;


            //mostrar todos los valores en orden:

            for (int i = 0; i < largo; i++)
            {
                Console.WriteLine($"todas las posiciones i={i}: {micadena[i]}");
            }

            //mostrar solamente los datos de las posiciones pares

            for (int i = 0; i < largo; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"posiciones pares i={i}: {micadena[i]}");
                }
            }

            //mostrar solamente los datos de las posiciones impares

            for (int i = 0; i < largo; i++)
            {
                if (!(i % 2 == 0))
                {
                    Console.WriteLine($"posiciones impares i={i}: {micadena[i]}");
                }
            }

            // cambiar valor de una posicion que cumple alguna condicion
            ///cambia valores
            for (int i = 0; i < largo; i++)
            {
                if (!(i % 2 == 0))
                {
                    micadena[i] = "es una posicion impar";
                }
            }
            ///mostrar datos
            for (int i = 0; i < largo; i++)
            {
                Console.WriteLine($"modificado i={i}: {micadena[i]}");
            }

            //preguntar por un valor en particular

            for (int i = 0; i < largo; i++)
            {
                if (micadena[i] == "juan")
                {
                    Console.WriteLine($"valor i={i}: hola juan");
                }
                else
                {
                    Console.WriteLine($"valor i={i}: {micadena[i]}");
                }
            }

            // arrays + foreach (sirve para mostrar colecciones)

            string[] arrayPalabras = { "milanesa", "lechuga", "rojo", "laura" };

            foreach (string dato in arrayPalabras)
            {
                //trae en cada posicion el valor y lo guarda en la variable dato. no permite controlar posiciones
                Console.WriteLine(dato);

                if (dato == "laura")
                {
                    Console.WriteLine("laura te encontre");
                }
            }

            //array de chars. para verificar que son todos caracteres validos

            char[] cadenadeletras = new char[5];
            cadenadeletras[0] = 'H';
            cadenadeletras[1] = 'o';
            cadenadeletras[2] = 'l';
            cadenadeletras[3] = 'a';

            foreach (char dato in cadenadeletras)
            {
                Console.WriteLine(dato);
            }

            //que el usuario cargue el array con datos

            int[] numeros = new int[5];
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                //Console.Write($"ingrese el {i + 1}° numero: ");
                //numeros[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in numeros)
            {
                suma += item;
            }

            //usamos var para cualqueir tipo de dato
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(suma);

            //contar caracteres de string

            string nombre = "fl0r3nc1@";
            int largo1;

            largo1 = nombre.Length;

            Console.WriteLine($"letras florencia: {largo1}");

            for (int i = 0; i < largo1; i++)
            {
                if (char.IsLetter(nombre[i])) //funcion que pregunta si es una letra, se puede preguntar si es ascci, espacio en blanco, digito (nro), etc.
                {
                    Console.WriteLine($"{nombre[i]} es una letra ");
                }
                else
                {
                    if (char.IsDigit(nombre[i]))
                    {
                        Console.WriteLine($"{nombre[i]} es un numero ");
                    }
                    else
                    {
                        Console.WriteLine($"{nombre[i]} no es una letra ni un digito ");
                    }
                }
            }

            //pedir nombre y validarlo
            
            string nombre1;
            bool esincorrecto;
            string nombreModificado;

            do
            {
                esincorrecto = false;

                Console.WriteLine("ingrese su nombre");
                nombre1 = Console.ReadLine();

                for (int i = 1; i < nombre1.Length; i++)
                {
                    if (!char.IsLetter(nombre1[i]))
                    {
                        Console.WriteLine("el nombre deben ser solo letras");
                        esincorrecto = true;
                        break;
                    }
                }

            } while (esincorrecto);

            for (int i = 0;i < nombre1.Length; i++)
            {
                nombre1[0] = char.ToUpper(nombre[0]);
            }
            

            Console.WriteLine($"nombre ingresado: {nombre1}");

            // arrays de texto, cambiar caracteres

            ////string palabra;

            ////Console.Write("ingrese una palabra: ");
            ////palabra = Console.ReadLine();

            ////declarar array de chars
            /////char[] letras = new char[10];

            ////otra forma
            /////char[] misLestras = { 'a', 'b', 'c' };

            ////char[] letras = palabra.ToCharArray();

            ////for (int i = 0; i < palabra.Length; i++)
            ////{
            ////    if (letras[i]=='a')
            ////    {
            ////        letras[i] = '*';
            ////    }
            ////}

            ////posiblemente actualizacion paralograrlo asi:
            ////Console.Write(letras); 

            ////si da error, forma correcta: 

            ////foreach (char unaLetra in letras)
            ////{
            ////    Console.Write(unaLetra);
            ////}

            //string palabra;
            //string palabraModificada = "";
            //int contador = 0;

            //Console.Write("ingrese una palabra: ");
            //palabra = Console.ReadLine();

            //foreach (char unaLetra in palabra)
            //{
            //    if (contador == 0 && unaLetra != 'a')
            //    {

            //    }
            //    else
            //    {
            //        if (unaLetra == 'a')
            //        {
            //            palabraModificada += '*';
            //        }
            //        else
            //        {
            //            palabraModificada += unaLetra;
            //        }
            //    }

            //}

        }
    }
}
