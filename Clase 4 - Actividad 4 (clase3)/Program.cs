namespace actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Ingrese un número entero positivo: ");
                int numero = int.Parse(Console.ReadLine());

                if (esPrimo(numero))
                {
                    Console.WriteLine(numero + " es primo.");
                }
                else
                {
                    Console.WriteLine(numero + " no es primo.");
                }

                continuar = PreguntaContinuar();
            }
        }

        static bool esPrimo(int numero)
        {
            bool esPrimo = true;

            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            return esPrimo;
        }

        static bool PreguntaContinuar()
        {
            bool respuestaValida = false;
            bool continuar = false;

            while (!respuestaValida)
            {
                Console.WriteLine("¿Desea calcular otro numero");
                string respuesta = Console.ReadLine();

                //Excepcion si se ingresa respuesta != si o no
                try
                {
                    if (respuesta.ToLower() == "si") //toLower = convertimos todo a MINUSCULA y 
                    {                                //facilitamos el manejo de la variable
                        respuestaValida = true;
                        continuar = true;
                    }
                    else if (respuesta.ToLower() == "no")
                    {
                        respuestaValida = true;
                        continuar = false;
                    }
                    else
                    {
                        throw new Exception("La respuesta debe ser 'si' o 'no'. Por favor, ingrese una respuesta válida.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return continuar;
        }

//program
    }
}

