//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor,
//el del medio y el menor de los números ingresados.

namespace ejercicio10
{
    // 1 definir clase y metodo

    public class program
    {
        static void Main(string[] Args)
        {
            //2 difinir variables
            double num1, num2, num3, mayor, menor, medio;

            //3 pedir datos en pantalla
            Console.WriteLine("Digite el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            // 4 calculos

            mayor = Math.Max(num1, Math.Max(num2, num3));
            menor = Math.Min(num1, Math.Min(num2, num3));
            medio = (num1 + num2 + num3) - (mayor + menor);

            // 5 mostrar datos en pantalla
            Console.WriteLine($"El numero mayor es: {mayor}");
            Console.WriteLine($"El numero menor es: {menor}");
            Console.WriteLine($"El numero de la mitad es: {medio}");





        }
    }
}