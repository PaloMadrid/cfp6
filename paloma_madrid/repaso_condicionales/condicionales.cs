using System.ComponentModel.Design;

namespace ejercicio02
{
    internal class condicionales
    {
        static void Main(string[] args)
        {
            //Al ingresar una edad menor a 18 años y un estado civil distinto a soltero, mostrar el mensaje: “Es muy pequeño para NO ser soltero”

            int edad;
            string estadoCivil;
            string edadTexto;

            Console.Write("ingrese su edad: ");
            //edadTexto = Console.ReadLine();
            //edad=int.Parse(edadTexto);

            ///16 y 17 simplificados pero se cierra al ingresar no int
            edad = int.Parse(Console.ReadLine());

            Console.Write("ingrese su estado civil: ");
            estadoCivil = Console.ReadLine();

            if (edad < 18 && estadoCivil != "soltero")
            {
                Console.WriteLine("es muy joven para no ser soltero");
            }
            else
            {
                Console.WriteLine("correcto");
            }


            //int edad = 25;
            //string genero = "M";

            ////if (edad < 18 && genero == "F")
            ////{
            ////    Console.WriteLine("es una niña");
            ////}
            ////else 
            ////{
            ////    if (genero== "F")
            ////    {
            ////    Console.WriteLine("una mujer mayor de edad");
            ////    }
            ////    else 
            ///     {
            ////        if (edad >= 18)
            ////        {
            ////            Console.WriteLine("un hombre mayor de edad");
            ////        }
            ////        else
            ////        {
            ////            Console.WriteLine("es un niño");
            ////        }
            ////    }
            //// }

            //if (genero=="mujer")
            //{
            //    if (edad < 18)
            //    {
            //        Console.WriteLine("es una niña");
            //    }
            //    else
            //    {
            //        Console.WriteLine("una mujer mayor de edad");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("no es una mujer");
            //}
        }
    }
}
