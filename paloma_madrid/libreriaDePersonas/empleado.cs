namespace libreriaDePersonas
{
    public class empleado
    {
        //atributos-> son los campos que definen mi objeto "persona". si son privados no se tiene acceso (ejemplo en plataforma de streaming tenemos los datos de usuario publicos y peliculas privado)

        public int legajo; 
        string nombre;
        string apellido;
        string areaDeTrabajo;
        double sueldo;

        //metodo set (agrega valor ) y get (muestra datos)

        public double Getsueldo()
        {
            return sueldo;//solo muestra el dato
        }

        public void Setsueldo(double sueldo)
        {
            if (sueldo>0 && sueldo<10000000)//al no ponerla publica y usar set me da la ventaja de que puedo hacer validaciones dentro de los metodos
            {
                this.sueldo = sueldo;
                //puedo modificarlo
            }
        }

        //propiedades-> propio de objetos pero solo es para c#. son una mezcla entre los atributos y/o metodos (get y set)


        //constructor-> es un metodo que permite crear (instanciar o crear instancia objetos de mi clase
        /*pasos:
         * visibilidad -> publica privada
         * comportamiento -> statico o de instancia (para ser static debe decirlo explisitamente, de lo contrario es de instancia)
         * retorno
         * nombre
         * cantidad de parametros
         * 
         * no necesito seguir un orden para ingresar los datos
         */

        //con datos completos
        public empleado(int legajo, string nombre, string apellido, double sueldo, string area)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
            this.areaDeTrabajo = area; //this hace referencia al objeto que estoy creando
        }

        //solo los datos que me interesan para trabaajar
        public empleado(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = 0;
            this.areaDeTrabajo = string.Empty; //this hace referencia al objeto que estoy creando
        }

        ///no puede haber dos constructores con los mismos tipos de datos, no podria crear otro que tenga un intero y dos string, a menos que cambie el orden, porque asi la firma cambio

        //metodos-> son los comportamientos de mi clase, por lo general se usan para comunicar info
        /*visibilidad
       * comportamiento
       * nunca tienen retorno
       * nombre siempre el mismo que la clase
       * parametros
       * 
       * no son obligatorios, pero por lo general siempre por lo menos tenemos un metodo
       * el mas frecuente: para mostrar todos o algunos valores
       */

        public string informarDatos()
        {
            return $"legajo: {legajo}.\nnombre: {apellido}, {nombre}. \npuesto: {areaDeTrabajo}. \nsueldo: ${sueldo}";
        }
    }
}
