
namespace tarea1.Bloque1
{
    public class Ciclos
    {
        // 23. Mostrar la tabla de multiplicar de un numero del 1 al 12.
        public void TablaMultiplicar()
        {
            Console.WriteLine("Ingrese un numero:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{n,3} x {i,2} = {n * i,4}");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido");
            }
        }

        // 24. Calcular la suma y la cantidad de numeros pares e impares del 1 al N.
        public void SumaParesImpares()
        {
            Console.WriteLine("Ingrese el valor de N:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n < 1)
                {
                    Console.WriteLine("N debe ser mayor que cero");
                    return;
                }

                int sumaPares = 0;
                int sumaImpares = 0;
                int cantPares = 0;
                int cantImpares = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumaPares = sumaPares + i;
                        cantPares++;
                    }
                    else
                    {
                        sumaImpares = sumaImpares + i;
                        cantImpares++;
                    }
                }

                Console.WriteLine($"Suma de pares: {sumaPares}");
                Console.WriteLine($"Cantidad de pares: {cantPares}");
                Console.WriteLine($"Suma de impares: {sumaImpares}");
                Console.WriteLine($"Cantidad de impares: {cantImpares}");
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido");
            }
        }

        // 25. Leer numeros hasta ingresar -1 y mostrar promedio, maximo y minimo.
        public void PromedioCentinela()
        {
            double suma = 0;
            int cantidad = 0;
            double mayor = 0;
            double menor = 0;

            Console.WriteLine("Ingrese numeros. Escriba -1 para terminar:");

            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out double n))
                {
                    Console.WriteLine("Ingrese un numero valido");
                    continue;
                }

                if (n == -1)
                    break;

                if (cantidad == 0)
                {
                    mayor = n;
                    menor = n;
                }
                else
                {
                    if (n > mayor)
                        mayor = n;

                    if (n < menor)
                        menor = n;
                }

                suma = suma + n;
                cantidad++;
            }

            if (cantidad > 0)
            {
                double promedio = suma / cantidad;

                Console.WriteLine($"Promedio: {promedio:F2}");
                Console.WriteLine($"Numero mayor: {mayor}");
                Console.WriteLine($"Numero menor: {menor}");
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros");
            }
        }

        // 26. Calcular una potencia usando un ciclo, sin utilizar Math.Pow.
        public void PotenciaCiclo()
        {
            Console.WriteLine("Ingrese la base:");
            if (!double.TryParse(Console.ReadLine(), out double baseN))
            {
                Console.WriteLine("Base invalida");
                return;
            }

            Console.WriteLine("Ingrese el exponente entero:");
            if (!int.TryParse(Console.ReadLine(), out int exponente))
            {
                Console.WriteLine("Exponente invalido");
                return;
            }

            double resultado = 1;
            int veces = exponente;

            if (exponente < 0)
                veces = exponente * -1;

            for (int i = 1; i <= veces; i++)
            {
                resultado = resultado * baseN;
            }

            if (exponente < 0)
            {
                if (baseN == 0)
                {
                    Console.WriteLine("No se puede elevar cero a un exponente negativo");
                    return;
                }

                resultado = 1 / resultado;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }

        // 27. Invertir un numero entero e indicar si es capicua.
        public void InversionNumero()
        {
            Console.WriteLine("Ingrese un numero entero:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int original = n;
                int numero = n;
                long invertido = 0;

                if (numero < 0)
                    numero = numero * -1;

                while (numero > 0)
                {
                    int digito = numero % 10;
                    invertido = invertido * 10 + digito;
                    numero = numero / 10;
                }

                if (original < 0)
                    invertido = invertido * -1;

                Console.WriteLine($"Numero invertido: {invertido}");

                if (original == invertido)
                    Console.WriteLine("El numero es capicua");
                else
                    Console.WriteLine("El numero no es capicua");
            }
            else
            {
                Console.WriteLine("Ingrese un numero entero valido");
            }
        }

        // 28. Convertir un numero decimal positivo a binario mediante divisiones entre 2.
        public void DecimalBinario()
        {
            Console.WriteLine("Ingrese un numero entero positivo:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n < 0)
                {
                    Console.WriteLine("El numero debe ser positivo");
                    return;
                }

                int numero = n;
                string binario = "";

                if (numero == 0)
                {
                    binario = "0";
                }
                else
                {
                    while (numero > 0)
                    {
                        int residuo = numero % 2;
                        binario = residuo + binario;
                        numero = numero / 2;
                    }
                }

                Console.WriteLine($"Numero binario: {binario}");
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido");
            }
        }

        // 29. Mostrar los primeros N terminos de Fibonacci, su suma y su promedio.
        public void SerieFibonacci()
        {
            Console.WriteLine("Cuantos terminos desea mostrar?");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n <= 0)
                {
                    Console.WriteLine("Ingrese una cantidad mayor que cero");
                    return;
                }

                long a = 0;
                long b = 1;
                long suma = 0;

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Termino {i}: {a}");
                    suma = suma + a;

                    long siguiente = a + b;
                    a = b;
                    b = siguiente;
                }

                double promedio = (double)suma / n;

                Console.WriteLine($"Suma total: {suma}");
                Console.WriteLine($"Promedio: {promedio:F2}");
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido");
            }
        }

        // 30. Calcular el factorial de N y la combinacion C(n,r).
        public void FactorialCombinaciones()
        {
            Console.WriteLine("Ingrese el valor de n:");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Console.WriteLine("Ingrese el valor de r:");
            if (!int.TryParse(Console.ReadLine(), out int r))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            if (n < 0 || r < 0 || r > n || n > 20)
            {
                Console.WriteLine("Use valores entre 0 y 20, con r menor o igual que n");
                return;
            }

            long factorialN = 1;
            long factorialR = 1;
            long factorialDiferencia = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
            }

            for (int i = 1; i <= r; i++)
            {
                factorialR = factorialR * i;
            }

            for (int i = 1; i <= n - r; i++)
            {
                factorialDiferencia = factorialDiferencia * i;
            }

            long combinacion = factorialN / (factorialR * factorialDiferencia);

            Console.WriteLine($"Factorial de {n}: {factorialN}");
            Console.WriteLine($"Combinacion C({n},{r}): {combinacion}");
        }

        // 31. Calcular el MCD con el algoritmo de Euclides y obtener el MCM.
        public void MCDMCM()
        {
            Console.WriteLine("Ingrese el primer numero:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            Console.WriteLine("Ingrese el segundo numero:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            if (a < 0)
                a = a * -1;

            if (b < 0)
                b = b * -1;

            int originalA = a;
            int originalB = b;

            while (b != 0)
            {
                int residuo = a % b;
                a = b;
                b = residuo;
            }

            int mcd = a;
            long mcm = 0;

            if (mcd != 0)
                mcm = (long)originalA / mcd * originalB;

            Console.WriteLine($"MCD: {mcd}");
            Console.WriteLine($"MCM: {mcm}");
        }

        // 32. Mostrar y contar los numeros primos dentro de un rango.
        public void NumerosPrimos()
        {
            Console.WriteLine("Ingrese el inicio del rango:");
            if (!int.TryParse(Console.ReadLine(), out int inicio))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            Console.WriteLine("Ingrese el final del rango:");
            if (!int.TryParse(Console.ReadLine(), out int fin))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            if (inicio > fin)
            {
                Console.WriteLine("El inicio debe ser menor o igual que el final");
                return;
            }

            int cantidad = 0;

            for (int i = inicio; i <= fin; i++)
            {
                if (i >= 2)
                {
                    bool primo = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            primo = false;
                            break;
                        }
                    }

                    if (primo)
                    {
                        Console.WriteLine($"Numero primo: {i}");
                        cantidad++;
                    }
                }
            }

            Console.WriteLine($"Cantidad de numeros primos: {cantidad}");
        }

        // 33. Juego para adivinar un numero aleatorio entre 1 y 100 en siete intentos.
        public void JuegoAdivinanza()
        {
            Random azar = new Random();
            int secreto = azar.Next(1, 101);
            int intentos = 0;
            bool adivino = false;

            Console.WriteLine("Adivine el numero entre 1 y 100");
            Console.WriteLine("Tiene 7 intentos");

            while (intentos < 7)
            {
                Console.WriteLine("Ingrese su numero:");
                if (!int.TryParse(Console.ReadLine(), out int n))
                {
                    Console.WriteLine("Ingrese un numero valido");
                    continue;
                }

                intentos++;

                if (n == secreto)
                {
                    Console.WriteLine("Felicidades, adivino el numero");
                    adivino = true;
                    break;
                }
                else if (n < secreto)
                {
                    Console.WriteLine("El numero secreto es mayor");
                }
                else
                {
                    Console.WriteLine("El numero secreto es menor");
                }

                Console.WriteLine($"Intentos usados: {intentos}");
            }

            if (!adivino)
                Console.WriteLine($"Se acabaron los intentos. El numero era {secreto}");

            Console.WriteLine($"Total de intentos usados: {intentos}");
        }

        // 34. Solicitar una contraseña hasta que cumpla todos los requisitos.
        public void ValidacionContrasena()
        {
            bool correcta = false;

            while (!correcta)
            {
                Console.WriteLine("Ingrese una contraseña:");
                string clave = Console.ReadLine();

                bool mayuscula = false;
                bool minuscula = false;
                bool numero = false;
                bool especial = false;

                if (clave.Length >= 8)
                {
                    for (int i = 0; i < clave.Length; i++)
                    {
                        if (clave[i] >= 'A' && clave[i] <= 'Z')
                            mayuscula = true;
                        else if (clave[i] >= 'a' && clave[i] <= 'z')
                            minuscula = true;
                        else if (clave[i] >= '0' && clave[i] <= '9')
                            numero = true;
                        else
                            especial = true;
                    }
                }

                if (clave.Length < 8)
                    Console.WriteLine("Debe tener al menos 8 caracteres");

                if (!mayuscula)
                    Console.WriteLine("Debe tener una letra mayuscula");

                if (!minuscula)
                    Console.WriteLine("Debe tener una letra minuscula");

                if (!numero)
                    Console.WriteLine("Debe tener un numero");

                if (!especial)
                    Console.WriteLine("Debe tener un caracter especial");

                if (clave.Length >= 8 && mayuscula && minuscula && numero && especial)
                {
                    Console.WriteLine("Contraseña valida");
                    correcta = true;
                }
            }
        }

        // 35. Mostrar diferentes patrones usando un menu y el tamaño elegido por el usuario.
        public void PatronesConsola()
        {
            int opcion = 0;

            while (opcion != 6)
            {
                Console.WriteLine("1. Triangulo");
                Console.WriteLine("2. Triangulo invertido");
                Console.WriteLine("3. Rombo");
                Console.WriteLine("4. Cuadrado hueco");
                Console.WriteLine("5. Piramide numerica");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Seleccione una opcion:");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion invalida");
                    opcion = 0;
                    continue;
                }

                if (opcion == 6)
                    break;

                if (opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Seleccione una opcion del 1 al 6");
                    continue;
                }

                Console.WriteLine("Ingrese el tamaño:");
                if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0 || n > 50)
                {
                    Console.WriteLine("Ingrese un tamaño entre 1 y 50");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                                Console.Write("*");

                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        for (int i = n; i >= 1; i--)
                        {
                            for (int j = 1; j <= i; j++)
                                Console.Write("*");

                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = i; j < n; j++)
                                Console.Write(" ");

                            for (int j = 1; j <= (2 * i - 1); j++)
                                Console.Write("*");

                            Console.WriteLine();
                        }

                        for (int i = n - 1; i >= 1; i--)
                        {
                            for (int j = i; j < n; j++)
                                Console.Write(" ");

                            for (int j = 1; j <= (2 * i - 1); j++)
                                Console.Write("*");

                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= n; j++)
                            {
                                if (i == 1 || i == n || j == 1 || j == n)
                                    Console.Write("*");
                                else
                                    Console.Write(" ");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 5:
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                                Console.Write(j);

                            Console.WriteLine();
                        }
                        break;
                }
            }
        }

        // 36. Calculadora con menu que mantiene el ultimo resultado para seguir operando.
        public void CalculadoraMenu()
        {
            double resultado = 0;
            bool tieneResultado = false;
            int opcion = 0;

            while (opcion != 8)
            {
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raiz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Salir");
                Console.WriteLine("Seleccione una opcion:");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion invalida");
                    opcion = 0;
                    continue;
                }

                if (opcion == 8)
                    break;

                if (opcion < 1 || opcion > 8)
                {
                    Console.WriteLine("Seleccione una opcion valida");
                    continue;
                }

                double a;

                if (tieneResultado)
                {
                    Console.WriteLine($"Ultimo resultado: {resultado}");
                    Console.WriteLine("Desea usarlo como primer numero? (s/n)");
                    string respuesta = Console.ReadLine();

                    if (respuesta == "s" || respuesta == "S")
                        a = resultado;
                    else
                    {
                        Console.WriteLine("Ingrese el primer numero:");
                        if (!double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Numero invalido");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese el primer numero:");
                    if (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Numero invalido");
                        continue;
                    }
                }

                if (opcion == 6)
                {
                    if (a < 0)
                    {
                        Console.WriteLine("No se puede calcular la raiz de un numero negativo");
                        continue;
                    }

                    resultado = Math.Sqrt(a); //use el .sqrt porque no se como sacar raiz y esto es lo de c++ y funciono
                }
                else
                {
                    Console.WriteLine("Ingrese el segundo numero:");
                    if (!double.TryParse(Console.ReadLine(), out double b))
                    {
                        Console.WriteLine("Numero invalido");
                        continue;
                    }

                    switch (opcion)
                    {
                        case 1:
                            resultado = a + b;
                            break;
                        case 2:
                            resultado = a - b;
                            break;
                        case 3:
                            resultado = a * b;
                            break;
                        case 4:
                            if (b == 0)
                            {
                                Console.WriteLine("No se puede dividir entre cero");
                                continue;
                            }
                            resultado = a / b;
                            break;
                        case 5:
                            resultado = 1;
                            int veces = (int)b;

                            if (b != veces)
                            {
                                Console.WriteLine("El exponente debe ser entero");
                                continue;
                            }

                            if (veces < 0)
                            {
                                if (a == 0)
                                {
                                    Console.WriteLine("No se puede usar cero con exponente negativo");
                                    continue;
                                }

                                veces = veces * -1;

                                for (int i = 1; i <= veces; i++)
                                    resultado = resultado * a;

                                resultado = 1 / resultado;
                            }
                            else
                            {
                                for (int i = 1; i <= veces; i++)
                                    resultado = resultado * a;
                            }
                            break;
                        case 7:
                            resultado = a * b / 100;
                            break;
                    }
                }

                tieneResultado = true;
                Console.WriteLine($"Resultado: {resultado:F2}");
            }

            Console.WriteLine("Calculadora finalizada");
        }
    }
}