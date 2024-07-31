namespace formula
{
    internal class formula
    {
        static void Main(string[] args)
        {
            double a, b, c, discriminante, x1, x2;

            Console.Write("Ingrese el coeficiente a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el coeficiente b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el coeficiente c: ");
            c = Convert.ToDouble(Console.ReadLine());

            discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Las raíces son reales y diferentes.");
                Console.WriteLine("x1 = {0:F2}", x1);
                Console.WriteLine("x2 = {0:F2}", x2);
            }
            else if (discriminante == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("Las raíces son reales e iguales.");
                Console.WriteLine("x1 = x2 = {0:F2}", x1);
            }
            else
            {
                double realPart = -b / (2 * a);
                double imagPart = Math.Sqrt(-discriminante) / (2 * a);
                Console.WriteLine("Las raíces son complejas y diferentes.");
                Console.WriteLine("x1 = {0:F2} + {1:F2}i", realPart, imagPart);
                Console.WriteLine("x2 = {0:F2} - {1:F2}i", realPart, imagPart);
            }
        }
    }
}