namespace string05
{
    internal class mayusculas
    {
        static void Main(string[] args)
        {
            //            5.Pedir el ingreso de nombre y apellido separado por un espacio, guardar cada
            //            dato en una variable diferente y asegurarse de que respete el formato de la
            //            primera letra en mayúscula y el resto en minúsculas, mostrar el apellido
            //            y el nombre por separado.
            //ej: juAN ROBles(primero nombre luego apelido)
            //imprimir:
            //        Apellido: Robles.
            //        Nombre: Juan.

            string apeNom;
            int finNombre=0;
            int inicioApellido = 0;
            

            Console.WriteLine("ingrese su nombre y apellido separado por un espacio");
            apeNom = Console.ReadLine();

            char[] letras =apeNom.ToCharArray();
            
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == ' ')
                {
                    finNombre = i;
                    inicioApellido = i+1;
                }
            }

            char[] nombre = new char[finNombre];
            char[] apellido=new char[letras.Length];

            for (int i = 0;i < finNombre;i++)
            {
                if (i == 0)
                {
                    nombre[i] = char.ToUpper(apeNom[i]);
                }
                else
                {
                    nombre[i] = apeNom[i];
                }
            }

            foreach(char c in nombre)
            {
                Console.Write(c);
            }

            for (int i = inicioApellido; i < letras.Length; i++)
            {
                if (i == inicioApellido)
                {
                    apellido[i] = char.ToUpper(apeNom[i]);
                }
                else
                {
                    apellido[i] = apeNom[i];
                }
            }

            foreach (char c in apellido)
            {
                Console.Write(c);
            }
        }
    }
}
