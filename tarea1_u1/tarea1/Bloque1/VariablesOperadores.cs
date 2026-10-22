
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
/*Área y perímetro - Menú para calcular área y perímetro de: círculo, triángulo, rectángulo y
trapecio. Validar que los valores ingresados sean positivos.*/
        public void AreasPerimetros()
        {
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Rectangulo");
            Console.WriteLine("4. Trapecio");

            int.TryParse(Console.ReadLine(), out int op);

            double a, b, c, d, h, area, per;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Ingrese el radio:");
                    a = Convert.ToDouble(Console.ReadLine());

                    if (a > 0)
                    {
                        area = Math.PI * a * a;
                        per = 2 * Math.PI * a;

                        Console.WriteLine($"Area: {area:F2}");
                        Console.WriteLine($"Perimetro: {per:F2}");
                    }
                    else
                        Console.WriteLine("El radio debe ser positivo.");
                    break;

                case 2:
                    Console.WriteLine("Ingrese la base:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura:");
                    h = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el lado 1:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el lado 2:");
                    c = Convert.ToDouble(Console.ReadLine());

                    if (a > 0 && h > 0 && b > 0 && c > 0
                        && a < b + c && b < a + c && c < a + b)
                    {
                        area = a * h / 2;
                        per = a + b + c;

                        Console.WriteLine($"Area: {area:F2}");
                        Console.WriteLine($"Perimetro: {per:F2}");
                    }
                    else
                        Console.WriteLine("Medidas no validas.");
                    break;

                case 3:
                    Console.WriteLine("Ingrese la base:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura:");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (a > 0 && b > 0)
                    {
                        area = a * b;
                        per = 2 * (a + b);

                        Console.WriteLine($"Area: {area:F2}");
                        Console.WriteLine($"Perimetro: {per:F2}");
                    }
                    else
                        Console.WriteLine("Las medidas deben ser positivas.");
                    break;

                case 4:
                    Console.WriteLine("Ingrese la base mayor:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese la base menor:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura:");
                    h = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el lado 1:");
                    c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el lado 2:");
                    d = Convert.ToDouble(Console.ReadLine());

                    if (a > 0 && b > 0 && h > 0 && c > 0 && d > 0
                        && a != b && c + d > Math.Abs(a - b)
                        && c + d < a + b)
                    {
                        area = (a + b) * h / 2;
                        per = a + b + c + d;

                        Console.WriteLine($"Area: {area:F2}");
                        Console.WriteLine($"Perimetro: {per:F2}");
                    }
                    else
                        Console.WriteLine("Medidas no validas.");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        }
    /*Conversión de temperatura - Crear un menú que permita convertir entre Celsius, Fahrenheit y
Kelvin. El usuario elige la conversión deseada.*/
        public void ConversionTemperatura()
        {
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.WriteLine("4. Kelvin a Celsius");
            Console.WriteLine("5. Fahrenheit a Kelvin");
            Console.WriteLine("6. Kelvin a Fahrenheit");

            int.TryParse(Console.ReadLine(), out int op);

            Console.WriteLine("Ingrese la temperatura:");
            double t = Convert.ToDouble(Console.ReadLine());
            double r = 0;

            switch (op)
            {
                case 1:
                    r = t * 9 / 5 + 32;
                    break;
                case 2:
                    r = (t - 32) * 5 / 9;
                    break;
                case 3:
                    r = t + 273.15;
                    break;
                case 4:
                    r = t - 273.15;
                    break;
                case 5:
                    r = (t - 32) * 5 / 9 + 273.15;
                    break;
                case 6:
                    r = (t - 273.15) * 9 / 5 + 32;
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    return;
            }

            if ((op == 3 && t < -273.15) ||
                (op == 4 && t < 0) ||
                (op == 5 && t < -459.67) ||
                (op == 6 && t < 0) ||
                (op == 1 && t < -273.15) ||
                (op == 2 && t < -459.67))
            {
                Console.WriteLine("Temperatura no valida.");
            }
            else
            {
                Console.WriteLine($"Resultado: {r:F2}");
            }
        }

/*Suma de dígitos - Dado un número entero positivo de tres dígitos, calcular la suma de sus
dígitos usando únicamente división entera y módulo (sin ciclos ni conversión a texto).*/
        public void SumaDigitos()
        {
            Console.WriteLine("Ingrese un numero de tres digitos:");
            int.TryParse(Console.ReadLine(), out int n);

            if (n >= 100 && n <= 999)
            {
                int a = n / 100;
                int b = (n / 10) % 10;
                int c = n % 10;

                Console.WriteLine($"Suma: {a + b + c}");
            }
            else
            {
                Console.WriteLine("Debe ingresar un numero de tres digitos.");
            }
        }

/*Tiempo transcurrido - Dadas dos horas en formato 24h (hora:minuto:segundo), calcular la
diferencia en horas, minutos y segundos.*/
        public void TiempoTranscurrido()
        {
            Console.WriteLine("Hora inicial (0-23):");
            int.TryParse(Console.ReadLine(), out int h1);

            Console.WriteLine("Minuto inicial (0-59):");
            int.TryParse(Console.ReadLine(), out int m1);

            Console.WriteLine("Segundo inicial (0-59):");
            int.TryParse(Console.ReadLine(), out int s1);

            Console.WriteLine("Hora final (0-23):");
            int.TryParse(Console.ReadLine(), out int h2);

            Console.WriteLine("Minuto final (0-59):");
            int.TryParse(Console.ReadLine(), out int m2);

            Console.WriteLine("Segundo final (0-59):");
            int.TryParse(Console.ReadLine(), out int s2);
/*inge en este punto no se si siquiera esta es la mejor opcion pero asi se me ocurrio -=-*/
            if (h1<0 || h1>23 || h2<0 || h2>23 ||m1<0 || m1>59 || m2<0 || m2>59 || s1<0 || s1>59 || s2<0 || s2>59)
            {
                Console.WriteLine("Hora no valida.");
                return;
            }

            int ini = h1 * 3600 + m1 * 60 + s1;
            int fin = h2 * 3600 + m2 * 60 + s2;

            int dif = fin - ini;

            if (dif < 0)
                dif = dif + 86400;

            int h = dif / 3600;
            int m = (dif % 3600) / 60;
            int s = dif % 60;

            Console.WriteLine($"Tiempo: {h} horas, {m} minutos y {s} segundos.");
        }


/*Desglose de billetes - Dado un monto en lempiras, mostrar la menor cantidad de billetes (500,
100, 50, 20, 10, 5, 2, 1) necesarios.*/
         public void DesgloseBilletes()
        {
            Console.WriteLine("Ingrese el monto en lempiras:");
            int.TryParse(Console.ReadLine(), out int n);

            if (n < 0)
            {
                Console.WriteLine("Monto no valido.");
                return;
            }

            int b = n / 500;
            n = n % 500;
            Console.WriteLine($"Billetes de 500: {b}");

            b = n / 100;
            n = n % 100;
            Console.WriteLine($"Billetes de 100: {b}");

            b = n / 50;
            n = n % 50;
            Console.WriteLine($"Billetes de 50: {b}");

            b = n / 20;
            n = n % 20;
            Console.WriteLine($"Billetes de 20: {b}");

            b = n / 10;
            n = n % 10;
            Console.WriteLine($"Billetes de 10: {b}");

            b = n / 5;
            n = n % 5;
            Console.WriteLine($"Billetes de 5: {b}");

            b = n / 2;
            n = n % 2;
            Console.WriteLine($"Billetes de 2: {b}");

            Console.WriteLine($"Billetes de 1: {n}");
        }

/*Cálculo de salario semanal - Ingresar horas trabajadas y tarifa por hora. Las horas extras (más
de 44) se pagan al 150%. Mostrar desglose y total.*/
        public void SalarioSemanal()
        {
            Console.WriteLine("Ingrese las horas trabajadas:");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el pago por hora:");
            double t = Convert.ToDouble(Console.ReadLine());

            if (h >= 0 && t > 0)
            {
                double reg, extra, total;

                if (h > 44)
                {
                    reg = 44 * t;
                    extra = (h - 44) * t * 1.5;
                }
                else
                {
                    reg = h * t;
                    extra = 0;
                }

                total = reg + extra;

                Console.WriteLine($"Pago normal: L {reg:F2}");
                Console.WriteLine($"Pago extra: L {extra:F2}");
                Console.WriteLine($"Total: L {total:F2}");
            }
            else
                Console.WriteLine("Datos no validos.");
        }

/*Calculadora de préstamo simple - Solicitar monto, tasa de interés anual y plazo en meses.
Calcular el interés total y la cuota mensual fija.*/
         public void PrestamoSimple()
        {
            Console.WriteLine("Ingrese el monto del prestamo:");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tasa anual (%):");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el plazo en meses:");
            int.TryParse(Console.ReadLine(), out int n);

            if (m > 0 && t >= 0 && n > 0)
            {
                double i = m * (t / 100) * n / 12;
                double total = m + i;
                double cuota = total / n;

                Console.WriteLine($"Interes total: L {i:F2}");
                Console.WriteLine($"Total a pagar: L {total:F2}");
                Console.WriteLine($"Cuota mensual: L {cuota:F2}");
            }
            else
                Console.WriteLine("Datos no validos.");
        }
    }
}