using libreriaDePersonas;

namespace testeoEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            empleado primerEmpleado= new empleado(1, "Juan", "Perez");
            empleado segundoEmpleado = new empleado(2, "Analia", "Sanchez",230000,"gerencia");

            ////modificacion de registro, solo se pueden modificar los campos publicos. conlleva un riesgo de seguridad

            //primerEmpleado.legajo = 8;

            // mostrar todos los datos de un empleado
            Console.WriteLine(primerEmpleado.informarDatos());

            //mostrar un dato especifico
            Console.WriteLine($"consulto sueldo empleado 2 {segundoEmpleado.Getsueldo()}");
            Console.WriteLine($"consulto sueldo empleado 1 {primerEmpleado.Getsueldo()}");

            //modificar el valor desde el proyecto principal
            primerEmpleado.Setsueldo(200000);

            Console.WriteLine($"consulto sueldo empleado 1  despues de set {primerEmpleado.Getsueldo()}");

        }
    }
}
