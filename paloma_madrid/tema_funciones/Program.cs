using libreriaDeFunciones;

namespace tema_funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //funcion: bloque de codigo que va a resolver una operacion. su objetivo es la simplificacion de codigo en el main
            //tipos: que devuelven algo y que reciben parametros

            //ej:int.Parse(""); 8
            /*
             una funcion para pedir el ingreso de una cadena y retornarla. 
            se pueden hacer afuera del static void
             */

            //int unNumero = 8;
            //int otroNumero = 12;
            //int resultado;

            //resultado=sumarenteros(unNumero, otroNumero);

            int resultado;

            resultado = clase_misFunciones.calculadora(8, 12,'-');

            Console.WriteLine(resultado);


            string direccion;
            string nombre;
            string apellido;

            nombre = clase_misFunciones.pedirCadena("ingrese su nombre: ");
            apellido = clase_misFunciones.pedirCadena("ingrese su apellido: ");
            direccion =clase_misFunciones.pedirCadena("ingrese su direccion: ");
            
            Console.WriteLine($"{nombre} {apellido}, {direccion}");

            //que no devuelven algo y que reciben parametros
            //que devuelven algo y que no reciben parametros
            //que no devuelven algo y que no reciben parametros
            //tipo hacer una operacion que repite y no puedo trabajar con ese resultado


            // ejemplo: static (<-comportamiento) void (<-retorno) Main (<-nombre de la funcion) (string[] args) recibe datos pero como dice void no devuelve nada
            //firma lo que contiene una funcion entre () ejemplo console.readline() (no recibe nada, por eso esta vacio () )

        }

       
    }
}
