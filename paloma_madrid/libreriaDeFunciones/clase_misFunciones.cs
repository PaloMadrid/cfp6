namespace libreriaDeFunciones
{
    public static class clase_misFunciones
    {
        /*se crean archivos que van a ser publicos. refiere a su visibilida dentro de la solucion
         * 1- crear un proyecto en la solucion de tipo libreria >libreria de clases
         * 2- establecer el proyecto como public class, ponerle nombre
         * 3- vincular el proyecto con la libreria con clic derecho > agregar > referencia a proyecto
         * 4-agregar using "nombre proyecto libreria" proyecto tipo consola (el main)
         * 5-establecer la misma clase en ambos archivos (aca los dos son static)
         * 6- agregar la palabra public al principio de cada funcion
         * 7- para llamar la funcion poner el nombre de la libreria al comienzo de la llamada de cada funcion
         * 
         * 
         * */

        public static string pedirCadena1() //no recibe un parametro, tendria que hacer una por cada tipo de cadena que necesito
        {
            string lectura;

            Console.Write("ingrese cadena: ");
            lectura = Console.ReadLine();

            return lectura;
        }
        public static string pedirCadena(string mensaje) //recibe un parametro
        {
            string lectura;

            Console.Write(mensaje);
            lectura = Console.ReadLine();

            return lectura;
        }

        public static int sumarenteros(int numero1, int numero2)//variables se declaran dentro de ()
        {

            return numero1 + numero2;
        }

        public static int calculadora(int numero1, int numero2, char operador)//ingresar operador
        {
            int resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    resultado = numero1 / numero2;
                    break;
            }

            return resultado;
        }
        public static void imprimirArrayAlReves();
    }
}
