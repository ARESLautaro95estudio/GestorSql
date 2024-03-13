using Entidades;
namespace BodaGriega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena = "hola como va ?";
            string[] chain;
            chain =cadena.Split(' ');
            if (chain[0] == "hola")
            {
                Console.WriteLine("Entro al if");
            }
        }
    }
}