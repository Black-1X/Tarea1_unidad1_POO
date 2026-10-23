
namespace tarea1.Bloque1
{
    public class EstructurasControl
    {
        // 11. Determinar si un numero es positivo, negativo o cero, y si es par o impar.
        public void PositivoNegativo()
        {
            Console.WriteLine("Ingrese un numero entero:");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n > 0)
                    Console.WriteLine("El numero es positivo");
                else if (n < 0)
                    Console.WriteLine("El numero es negativo");
                else
                    Console.WriteLine("El numero es cero");

                string tipo = n % 2 == 0 ? "par" : "impar";
                Console.WriteLine($"El numero es {tipo}" );
            }
            else
            {
                Console.WriteLine("Ingrese un numero entero valido");
            }
        }

        // 12. Pedir tres numeros diferentes y mostrar el mayor y el menor.
        public void MayorMenor()
        {
            Console.WriteLine("Ingrese el primer numero:");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            Console.WriteLine("Ingrese el segundo numero:");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            Console.WriteLine("Ingrese el tercer numero:");
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            if (a == b || a == c || b == c)
            {
                Console.WriteLine("Los tres numeros deben ser diferentes");
            }
            else
            {
              if (a > b && a > c)
                Console.WriteLine($"El mayor es: {a}");
            else if (b > a && b > c)
                Console.WriteLine($"El mayor es: {b}");
            else
                Console.WriteLine($"El mayor es: {c}");

            if (a < b && a < c)
                Console.WriteLine($"El menor es: {a}");
            else if (b < a && b < c)
                Console.WriteLine($"El menor es: {b}");
            else
                Console.WriteLine($"El menor es: {c}");
            }
        }

        // 13. Mostrar el dia de la semana usando switch clasico y expresion switch.
        public void DiaSemana()
        {
            Console.WriteLine("Ingrese un numero del 1 al 7:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    default:
                        Console.WriteLine("Numero fuera de rango");
                        break;
                }

                string dia = n switch
                {
                    1 => "Lunes",
                    2 => "Martes",
                    3 => "Miercoles",
                    4 => "Jueves",
                    5 => "Viernes",
                    6 => "Sabado",
                    7 => "Domingo",
                    _ => "Numero fuera de rango"
                };

                Console.WriteLine($"Usando expresion switch: {dia} " );
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido");
            }
        }

        // 14. Crear una calculadora con suma, resta, multiplicacion, division y modulo.
        public void CalculadoraSwitch()
        {
            Console.WriteLine("Ingrese el primer numero:");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            Console.WriteLine("Ingrese el segundo numero:");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            Console.WriteLine("Seleccione una operacion: +, -, *, /, %");
            string op = Console.ReadLine();

           switch (op)
                {
                    case "+":
                        Console.WriteLine($"Resultado: {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"Resultado: {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"Resultado: {a * b}");
                        break;
                    case "/":
                        if (b != 0)
                            Console.WriteLine($"Resultado: {a / b}");
                        else
                            Console.WriteLine("Error: no se puede dividir entre cero");
                        break;
                    case "%":
                        if (b != 0)
                            Console.WriteLine($"Resultado: {a % b}");
                        else
                            Console.WriteLine("Error: no se puede calcular el modulo entre cero");
                        break;
                    default:
                        Console.WriteLine("Operacion no valida");
                        break;
                }
        }

        // 15. Determinar si una letra es vocal o consonante.
        public void VocalConsonante()
        {
            Console.WriteLine("Ingrese una letra:");
            string letra = Console.ReadLine();

            if (letra.Length == 1)
            {
                switch (letra)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                    case "A":
                    case "E":
                    case "I":
                    case "O":
                    case "U":
                        Console.WriteLine("Es una vocal");
                        break;

                    default:
                        if ((letra[0] >= 'a' && letra[0] <= 'z') ||
                            (letra[0] >= 'A' && letra[0] <= 'Z'))
                            Console.WriteLine("Es una consonante");
                        else
                            Console.WriteLine("Debe ingresar una letra");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar solamente una letra");
            }
        }

        // 16. Mostrar la letra, descripcion y resultado de una nota de la UNAH.
        public void CalificacionesUNAH()
        {
            Console.WriteLine("Ingrese la nota de 0 a 100:");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                if (nota < 0 || nota > 100)
                {
                    Console.WriteLine("La nota debe estar entre 0 y 100");
                    return;
                }

                string letra;
                string descripcion;

                if (nota >= 90)
                {
                    letra = "A";
                    descripcion = "Excelente";
                }
                else if (nota >= 80)
                {
                    letra = "B";
                    descripcion = "Muy bueno";
                }
                else if (nota >= 70)
                {
                    letra = "C";
                    descripcion = "Bueno";
                }
                else if (nota >= 60)
                {
                    letra = "D";
                    descripcion = "Necesita mejorar";
                }
                else
                {
                    letra = "F";
                    descripcion = "Reprobado";
                }

                Console.WriteLine("Letra: " + letra);
                Console.WriteLine("Descripcion: " + descripcion);

                if (nota >= 60)
                    Console.WriteLine("Aprobo");
                else
                    Console.WriteLine("Reprobo");
            }
            else
            {
                Console.WriteLine("Ingrese una nota valida");
            }
        }

        // 17. Calcular el descuento segun el monto de la compra.
        public void Descuentos()
        {
            Console.WriteLine("Ingrese el monto de la compra:");
            if (double.TryParse(Console.ReadLine(), out double monto))
            {
                if (monto < 0)
                {
                    Console.WriteLine("El monto no puede ser negativo");
                    return;
                }

                double descuento = 0;

                if (monto >= 2500)
                    descuento = monto * 0.15;
                else if (monto >= 1000)
                    descuento = monto * 0.10;
                else if (monto >= 500)
                    descuento = monto * 0.05;

                double total = monto - descuento;

                Console.WriteLine($"Precio original: L {monto:F2}");
                Console.WriteLine($"Descuento: L {descuento:F2}");
                Console.WriteLine($"Precio final: L {total:F2}");
            }
            else
            {
                Console.WriteLine("Ingrese un monto valido");
            }
        }

        // 18. Calcular el pago del estacionamiento con un maximo de L100 por dia.
        public void Estacionamiento()
        {
            Console.WriteLine("Ingrese las horas estacionado:");
            if (int.TryParse(Console.ReadLine(), out int horas))
            {
                if (horas <= 0)
                {
                    Console.WriteLine("Las horas deben ser positivas");
                    return;
                }

                double pago = 20;

                if (horas > 1)
                    pago = 20 + (horas - 1) * 10;

                if (pago > 100)
                    pago = 100;

                Console.WriteLine($"Total a pagar: L {pago:F2}");
            }
            else
            {
                Console.WriteLine("Ingrese una cantidad valida de horas");
            }
        }

        // 19. Validar un triangulo y clasificarlo por sus lados y sus angulos.
        public void ClasificacionTriangulos()
        {
            Console.WriteLine("Ingrese el primer lado:");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Lado invalido");
                return;
            }

            Console.WriteLine("Ingrese el segundo lado:");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Lado invalido");
                return;
            }

            Console.WriteLine("Ingrese el tercer lado:");
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Lado invalido");
                return;
            }

            if (a <= 0 || b <= 0 || c <= 0 ||
                a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Los lados no forman un triangulo valido");
                return;
            }

            if (a == b && b == c)
                Console.WriteLine("Triangulo equilatero");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Triangulo isosceles");
            else
                Console.WriteLine("Triangulo escaleno");

            double mayor = a;
            double menor = b;
            double medio = c;

            if (mayor < menor)
            {
                double aux = mayor;
                mayor = menor;
                menor = aux;
            }

            if (mayor < medio)
            {
                double aux = mayor;
                mayor = medio;
                medio = aux;
            }

            if (menor > medio)
            {
                double aux = menor;
                menor = medio;
                medio = aux;
            }

            if (mayor * mayor == menor * menor + medio * medio)
                Console.WriteLine("Es rectangulo");
            else if (mayor * mayor < menor * menor + medio * medio)
                Console.WriteLine("Es acutangulo");
            else
                Console.WriteLine("Es obtusangulo");
            }

        // 20. Determinar si un año es bisiesto y cuantos dias tiene un mes.
        public void AnioBisiesto()
        {
            Console.WriteLine("Ingrese el año:");
            if (!int.TryParse(Console.ReadLine(), out int anio) || anio <= 0)
            {
                Console.WriteLine("Ingrese un año valido");
                return;
            }

            Console.WriteLine("Ingrese el mes del 1 al 12:");
            if (!int.TryParse(Console.ReadLine(), out int mes))
            {
                Console.WriteLine("Mes invalido");
                return;
            }

            bool bisiesto = (anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0;

            if (bisiesto)
                Console.WriteLine("El año es bisiesto");
            else
                Console.WriteLine("El año no es bisiesto");

            int dias;

            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dias = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dias = 30;
                    break;
                case 2:
                    if (bisiesto)
                        dias = 29;
                    else
                        dias = 28;
                    break;
                default:
                    Console.WriteLine("Mes fuera de rango");
                    return;
            }

            Console.WriteLine("El mes tiene " + dias + " dias");
        }

        // 21. Validar una fecha ingresando el dia, mes y año por separado.
        public void ValidadorFecha()
        {
            Console.WriteLine("Ingrese el dia:");
            if (!int.TryParse(Console.ReadLine(), out int dia))
            {
                Console.WriteLine("Dia invalido");
                return;
            }

            Console.WriteLine("Ingrese el mes:");
            if (!int.TryParse(Console.ReadLine(), out int mes))
            {
                Console.WriteLine("Mes invalido");
                return;
            }

            Console.WriteLine("Ingrese el año:");
            if (!int.TryParse(Console.ReadLine(), out int anio) || anio <= 0)
            {
                Console.WriteLine("Año invalido");
                return;
            }

            bool bisiesto = (anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0;
            int dias = 0;

            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dias = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dias = 30;
                    break;
                case 2:
                    if (bisiesto)
                        dias = 29;
                    else
                        dias = 28;
                    break;
                default:
                    Console.WriteLine("La fecha no es valida");
                    return;
            }

            if (dia >= 1 && dia <= dias)
                Console.WriteLine("La fecha es valida");
            else
                Console.WriteLine("La fecha no es valida");
        }

        // 22. Simular un cajero automatico y mostrar los billetes entregados.
        public void CajeroAutomatico()
        {
            double saldo = 5000;

            Console.WriteLine($"Saldo disponible: L {saldo:F2}");
            Console.WriteLine("Ingrese el monto que desea retirar:");

            if (int.TryParse(Console.ReadLine(), out int monto))
            {
                if (monto <= 0)
                {
                    Console.WriteLine("El monto debe ser positivo");
                }
                else if (monto % 20 != 0)
                {
                    Console.WriteLine("El monto debe ser multiplo de 20");
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("No tiene saldo suficiente");
                }
                else
                {
                    saldo = saldo - monto;

                    int billetes500 = monto / 500;
                    monto = monto % 500;

                    int billetes100 = monto / 100;
                    monto = monto % 100;

                    int billetes20 = monto / 20;

                    Console.WriteLine($"Billetes de L500: {billetes500}");
                    Console.WriteLine($"Billetes de L100: {billetes100}");
                    Console.WriteLine($"Billetes de L20: {billetes20}");
                    Console.WriteLine("Retiro realizado correctamente");
                    Console.WriteLine($"Saldo restante: L {saldo:F2}");

                }
            }
            else
            {
                Console.WriteLine("Ingrese un monto valido");
            }
        }
    }
}