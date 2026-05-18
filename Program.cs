using Materia3A.Materia;

namespace Materia3A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creamos las instancias de algunas materias");
            Materia.Materia POO = new Materia.Materia();
            Materia.Materia Calculo = new Materia.Materia("Calculo integral",10,7,8);

            Console.WriteLine(POO.ImprimeMateria());
            Console.WriteLine(Calculo.ImprimeMateria());
        }
    }
}
