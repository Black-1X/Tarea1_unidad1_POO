
namespace tarea1.Bloque1
{
    public class VariablesOperadores
    {
        /*Solicitar un monto en lempiras y la tasa de cambio del día. Convertir el
monto a dólares y a euros, mostrando los resultados con dos decimales.*/
        public void ConversorDeLempiras()
        {
            Console.WriteLine("Ingrese la cantidad de lempiras:");
            double lps = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tasa de cambio del dólar:");
            double tasaDolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tasa de cambio del euro:");
            double tasaEuro = Convert.ToDouble(Console.ReadLine());

            double dolares = lps / tasaDolar;
            double euros = lps / tasaEuro;

            Console.WriteLine($"Son {dolares:F2} dólares.");
            Console.WriteLine($"Son {euros:F2} euros.");
        }
/*Calculadora de IMC - Solicitar peso (kg) y altura (m), calcular el índice de masa corporal y
mostrar en qué categoría se encuentra (bajo peso, normal, sobrepeso, obesidad).*/
        public void Caculadora()
        {
            Console.WriteLine("Ingrese su peso en kilogramos:");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su altura en metros:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"Su IMC es: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Categoría: Bajo peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Categoría: Normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Categoría: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Categoría: Obesidad");
            }
        }
        
/* Intercambio de valores - Declarar dos variables con valores iniciales,
intercambiar sus valores usando una variable temporal y mostrar el antes y el después.
Reto adicional: hacerlo sin variable temporal, usando solo operaciones aritméticas. */

        public void Intercambio()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Antes del intercambio:");
            Console.WriteLine($"A vale: {a}");
            Console.WriteLine($"B vale: {b}");

            int aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Después del intercambio:");
            Console.WriteLine($"A vale: {a}");
            Console.WriteLine($"B vale: {b}");

            //esto es lo que pide sin usa la ptra variable

            /*Console.WriteLine("Antes del intercambio:");
            Console.WriteLine($"A vale: {a}");
            Console.WriteLine($"B vale: {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Después del intercambio:");
            Console.WriteLine($"A vale: {a}");
            Console.WriteLine($"B vale: {b}");*/
        }

    }
}