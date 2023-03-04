namespace Laboratorio_01_ejercicio_3_y_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio no. 3: Jerarquia de operaciones");

            double a, b, c;
            double r1, r2, r3, r4;

            Console.WriteLine("Ingrese el variable a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el variable b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el variable c");
            c = Convert.ToDouble(Console.ReadLine());

            r1 = a * b + c;
            r2 = a * (b + c);
            r3 = a / (b + c);
            r4 = (3 * a + 2 * b) / (c * c);

            Console.WriteLine("El resultado del primer inciso es " + r1);
            Console.WriteLine("El resultado del segundo inciso es " + r4);
            Console.WriteLine("El resultado del tercero inciso es " + r3);
            Console.WriteLine("El resultado del cuarto inciso es " + r4);

            //ejercicio 04
            Console.WriteLine("Ejercicio no.4: Formula General");

            double determinante, raiz1, raiz2;


            determinante = (b * b) - (4 * (a) * (c));

            if (determinante <= 0)
            {
                Console.WriteLine("error determinante invalido");
            }
            else
            {
                raiz1 = (-(b) + Math.Sqrt(determinante)) / (2 * a);
                raiz2 = (-(b) - Math.Sqrt(determinante)) / (2 * a);

                Console.WriteLine("x1 = " + raiz1);
                Console.WriteLine("x2 = " + raiz2);
            }
        }
    }
}