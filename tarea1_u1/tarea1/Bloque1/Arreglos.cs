 
namespace tarea1.Bloque1
{
    public class Arreglos
    {
        // 37. Leer numeros en un arreglo y calcular suma, promedio, mayor y menor.
        public void RegistroNumeros()
        {
            Console.WriteLine("Cuantos numeros desea ingresar?");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Ingrese una cantidad valida");
                return;
            }

            int[] numeros = new int[n];
            int suma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese el numero {i + 1}:");
                if (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Numero invalido");
                    return;
                }

                suma = suma + numeros[i];
            }

            int mayor = numeros[0];
            int menor = numeros[0];

            foreach (int numero in numeros)
            {
                if (numero > mayor)
                    mayor = numero;

                if (numero < menor)
                    menor = numero;
            }

            double promedio = (double)suma / n;

            Console.WriteLine("Numeros ingresados usando for:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("Numeros ingresados usando foreach:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Mayor: {mayor}");
            Console.WriteLine($"Menor: {menor}");
        }

        // 38. Guardar cinco nombres, mostrarlos al reves, encontrar el mas largo y buscar uno.
        public void ArregloNombres()
        {
            string[] nombres = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre {i + 1}:");
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("Nombres en orden inverso:");

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(nombres[i]);
            }

            string largo = nombres[0];

            for (int i = 1; i < 5; i++)
            {
                if (nombres[i].Length > largo.Length)
                    largo = nombres[i];
            }

            Console.WriteLine($"Nombre mas largo: {largo}");

            Console.WriteLine("Ingrese el nombre que desea buscar:");
            string buscar = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < 5; i++)
            {
                if (nombres[i].ToLower() == buscar.ToLower())
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                Console.WriteLine("El nombre si esta en el arreglo");
            else
                Console.WriteLine("El nombre no esta en el arreglo");
        }

        // 39. Calcular estadisticas de calificaciones y su desviacion estandar.
        public void EstadisticasCalificaciones()
        {
            Console.WriteLine("Cuantas calificaciones va a ingresar?");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Ingrese una cantidad valida");
                return;
            }

            double[] notas = new double[n];
            double suma = 0;
            double mayor = 0;
            double menor = 100;
            int aprobados = 0;
            int reprobados = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese la calificacion {i + 1}:");

                if (!double.TryParse(Console.ReadLine(), out notas[i]) ||
                    notas[i] < 0 || notas[i] > 100)
                {
                    Console.WriteLine("La nota debe estar entre 0 y 100");
                    return;
                }

                suma = suma + notas[i];

                if (notas[i] > mayor)
                    mayor = notas[i];

                if (notas[i] < menor)
                    menor = notas[i];

                if (notas[i] >= 60)
                    aprobados++;
                else
                    reprobados++;
            }

            double promedio = suma / n;
            double sumaDiferencias = 0;

            for (int i = 0; i < n; i++)
            {
                double diferencia = notas[i] - promedio;
                sumaDiferencias = sumaDiferencias + diferencia * diferencia;
            }

            double desviacion = Math.Sqrt(sumaDiferencias / n);

            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Nota maxima: {mayor:F2}");
            Console.WriteLine($"Nota minima: {menor:F2}");
            Console.WriteLine($"Aprobados: {aprobados}");
            Console.WriteLine($"Reprobados: {reprobados}");
            Console.WriteLine($"Desviacion estandar: {desviacion:F2}");
        }

        // 40. Generar 20 numeros aleatorios y mostrar la frecuencia de cada uno.
        public void FrecuenciaElementos()
        {
            int[] numeros = new int[20];
            int[] frecuencia = new int[11];
            Random azar = new Random();

            for (int i = 0; i < 20; i++)
            {
                numeros[i] = azar.Next(1, 11);
                frecuencia[numeros[i]]++;
            }

            Console.WriteLine("Numeros generados:");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{numeros[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Frecuencia de cada numero:");

            int mayor = frecuencia[1];
            int menor = frecuencia[1];

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Numero {i}: {frecuencia[i]} veces");

                if (frecuencia[i] > mayor)
                    mayor = frecuencia[i];

                if (frecuencia[i] < menor)
                    menor = frecuencia[i];
            }

            Console.WriteLine($"Mayor frecuencia: {mayor}");
            Console.WriteLine($"Numeros con mayor frecuencia:");

            for (int i = 1; i <= 10; i++)
            {
                if (frecuencia[i] == mayor)
                    Console.WriteLine(i);
            }

            Console.WriteLine($"Menor frecuencia: {menor}");
            Console.WriteLine("Numeros con menor frecuencia:");

            for (int i = 1; i <= 10; i++)
            {
                if (frecuencia[i] == menor)
                    Console.WriteLine(i);
            }
        }

        // 41. Registrar temperaturas de siete dias y calcular estadisticas semanales.
        public void ArregloTemperaturas()
        {
            double[] temperaturas = new double[7];
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves",
                              "Viernes", "Sabado", "Domingo" };

            double suma = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Ingrese la temperatura del {dias[i]}:");

                if (!double.TryParse(Console.ReadLine(), out temperaturas[i]))
                {
                    Console.WriteLine("Temperatura invalida");
                    return;
                }

                suma = suma + temperaturas[i];
            }

            double promedio = suma / 7;
            int diaCaluroso = 0;
            int diaFrio = 0;

            for (int i = 1; i < 7; i++)
            {
                if (temperaturas[i] > temperaturas[diaCaluroso])
                    diaCaluroso = i;

                if (temperaturas[i] < temperaturas[diaFrio])
                    diaFrio = i;
            }

            Console.WriteLine($"Promedio semanal: {promedio:F2}");
            Console.WriteLine($"Dia mas caluroso: {dias[diaCaluroso]} ({temperaturas[diaCaluroso]} grados)");
            Console.WriteLine($"Dia mas frio: {dias[diaFrio]} ({temperaturas[diaFrio]} grados)");

            Console.WriteLine("Dias con temperatura sobre el promedio:");

            for (int i = 0; i < 7; i++)
            {
                if (temperaturas[i] > promedio)
                    Console.WriteLine($"{dias[i]}: {temperaturas[i]} grados");
            }

            Console.WriteLine("Variacion entre dias consecutivos:");

            for (int i = 0; i < 6; i++)
            {
                double variacion = temperaturas[i + 1] - temperaturas[i];
                Console.WriteLine($"De {dias[i]} a {dias[i + 1]}: {variacion:F2} grados");
            }
        }

        // 42. Buscar, encontrar el segundo mayor, ordenar y mostrar posiciones pares.
        public void BusquedaOrdenamiento()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el numero {i + 1}:");

                if (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Numero invalido");
                    return;
                }
            }

            Console.WriteLine("Ingrese el numero que desea buscar:");
            if (!int.TryParse(Console.ReadLine(), out int buscar))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            bool encontrado = false;

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] == buscar)
                {
                    Console.WriteLine($"Numero encontrado en la posicion {i}");
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("Numero no encontrado");

            int mayor = numeros[0];
            int segundo = 0;
            bool tieneSegundo = false;

            for (int i = 1; i < 10; i++)
            {
                if (numeros[i] > mayor)
                {
                    segundo = mayor;
                    mayor = numeros[i];
                    tieneSegundo = true;
                }
                else if (numeros[i] < mayor)
                {
                    if (!tieneSegundo || numeros[i] > segundo)
                    {
                        segundo = numeros[i];
                        tieneSegundo = true;
                    }
                }
            }

            if (tieneSegundo)
                Console.WriteLine($"Segundo mayor diferente: {segundo}");
            else
                Console.WriteLine("No hay un segundo valor diferente");

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9 - i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Arreglo ordenado de menor a mayor:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{numeros[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Elementos en posiciones pares (2, 4, 6, 8, 10):");

            for (int i = 1; i < 10; i = i + 2)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        // 43. Rotar el arreglo a la izquierda, a la derecha o invertirlo.
        public void RotacionArreglo()
        {
            Console.WriteLine("Cuantos elementos tendra el arreglo?");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Ingrese una cantidad valida");
                return;
            }

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese el elemento {i + 1}:");

                if (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Numero invalido");
                    return;
                }
            }

            int opcion = 0;

            while (opcion != 4)
            {
                Console.WriteLine("1. Rotar a la izquierda");
                Console.WriteLine("2. Rotar a la derecha");
                Console.WriteLine("3. Invertir arreglo");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opcion:");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion invalida");
                    opcion = 0;
                    continue;
                }

                if (opcion == 4)
                    break;

                if (opcion == 1 || opcion == 2)
                {
                    Console.WriteLine("Cuantas posiciones desea rotar?");

                    if (!int.TryParse(Console.ReadLine(), out int k) || k < 0)
                    {
                        Console.WriteLine("Ingrese una cantidad valida");
                        continue;
                    }

                    k = k % n;

                    for (int vuelta = 1; vuelta <= k; vuelta++)
                    {
                        if (opcion == 1)
                        {
                            int primero = numeros[0];

                            for (int i = 0; i < n - 1; i++)
                                numeros[i] = numeros[i + 1];

                            numeros[n - 1] = primero;
                        }
                        else
                        {
                            int ultimo = numeros[n - 1];

                            for (int i = n - 1; i > 0; i--)
                                numeros[i] = numeros[i - 1];

                            numeros[0] = ultimo;
                        }
                    }
                }
                else if (opcion == 3)
                {
                    for (int i = 0; i < n / 2; i++)
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[n - 1 - i];
                        numeros[n - 1 - i] = aux;
                    }
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                    continue;
                }

                Console.WriteLine("Arreglo actual:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{numeros[i]} ");
                }

                Console.WriteLine();
            }
        }

        // 44. Contar las calificaciones por rango y dibujar un histograma.
        public void HistogramaCalificaciones()
        {
            Console.WriteLine("Cuantas calificaciones desea ingresar?");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Ingrese una cantidad valida");
                return;
            }

            int[] notas = new int[n];
            int rango1 = 0;
            int rango2 = 0;
            int rango3 = 0;
            int rango4 = 0;
            int rango5 = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese la calificacion {i + 1}:");

                if (!int.TryParse(Console.ReadLine(), out notas[i]) ||
                    notas[i] < 0 || notas[i] > 100)
                {
                    Console.WriteLine("La nota debe estar entre 0 y 100");
                    return;
                }

                if (notas[i] <= 59)
                    rango1++;
                else if (notas[i] <= 69)
                    rango2++;
                else if (notas[i] <= 79)
                    rango3++;
                else if (notas[i] <= 89)
                    rango4++;
                else
                    rango5++;
            }

            Console.WriteLine("Histograma de calificaciones");
            Console.WriteLine($"0-59:   {new string('*', rango1)} ({rango1})");
            Console.WriteLine($"60-69:  {new string('*', rango2)} ({rango2})");
            Console.WriteLine($"70-79:  {new string('*', rango3)} ({rango3})");
            Console.WriteLine($"80-89:  {new string('*', rango4)} ({rango4})");
            Console.WriteLine($"90-100: {new string('*', rango5)} ({rango5})");
        }
    }
}