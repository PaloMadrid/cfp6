namespace repaso_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // segun - condicional multiple

            string color="verde";
            
            switch (color)
            {
                case "rojo":
                    Console.WriteLine("no puede avanzar");
                    break;

                case "amarillo":
                    Console.WriteLine("avance con precaucion");
                    break;

                case "verde":
                    Console.WriteLine("puede avanzar");
                    break;

                default:
                    Console.WriteLine("no es un color valido del semaforo");
                    break;
            }

            //practicar lamparitas con switch
        }
    }
}
