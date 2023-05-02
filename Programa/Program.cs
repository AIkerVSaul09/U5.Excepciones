 class Program
{
    private static void Main(string[] args)
    {
        uint? edad=0;
        Console.WriteLine("Captura tu edad y presiona ºEnterº");
        string? edadCaptuarada = Console.ReadLine();

        if(edadCaptuarada is not null)
        {
            try
            {
                edad = uint.Parse(edadCaptuarada);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Formato Incorrecto");
            }
             catch(System.OverflowException)
            {
                Console.WriteLine("La edad es muy grande o muy pequeña");
            }
        }
        if(edad>=0)
        {
            Console.WriteLine($"Tu edad es  {edad}");
        }
        else
        {
            Console.WriteLine("Reingrese el resultado con un numero Positivo");
        }

    }
}