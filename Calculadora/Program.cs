using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora MiCalculadora = new Calculadora();
        double seguir = 1, opcion = 0;
        double numero = 0;

        do
        {
            Console.Write("\n Ingrese el numero a trabajar:");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n1-sumar \n 2-restar \n 3-multriplicar \n 4-dividir\n Que decision quiere:");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MiCalculadora.Sumar(numero);
                    break;
                case 2:
                    MiCalculadora.Restar(numero);
                    break;
                case 3:
                    MiCalculadora.Multiplicar(numero);
                    break;
                case 4:
                    MiCalculadora.Dividir(numero);
                    break;
                
                default:
                    break;
            }

            Console.WriteLine("El resultado de la operacion es: " + MiCalculadora.Resultado);

            Console.Write("\n 1-Seguir \n0-Salir \nDesea seguir operando:");
            seguir = Console.Read();

        } while (seguir != 0);



    }
}
