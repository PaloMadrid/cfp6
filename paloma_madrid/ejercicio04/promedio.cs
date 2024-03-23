namespace ejercicio04
{
    internal class promedio
    {
        static void Main(string[] args)
        {
            float numero;
            float promedio;
            float suma=0;
            int i=0;


            while (i<5)
            {
                i = i + 1;

                Console.WriteLine($"ingrese el {i}° numero: ");
                numero = float.Parse(Console.ReadLine());

                suma = suma +numero;
            }

            promedio = suma / i;

            Console.WriteLine($"suma = {suma}");
            Console.WriteLine($"promedio = {promedio}");

        }
    }
}
