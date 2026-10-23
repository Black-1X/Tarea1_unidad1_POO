
namespace tarea1.Bloque1
{
    public class Listas
    {
        // 45. Administrar una lista de tareas pendientes.
        public void ListaTareas()
        {
            List<string> tareas = new List<string>();
            int opcion = 0;

            while (opcion != 4)
            {
                Console.WriteLine("\n1. Agregar tarea");
                Console.WriteLine("2. Mostrar tareas");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opcion:");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion invalida");
                    opcion = 0;
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la tarea:");
                        string tarea = Console.ReadLine();

                        tareas.Add(tarea);
                        Console.WriteLine("Tarea agregada");
                        break;

                    case 2:
                        if (tareas.Count == 0)
                        {
                            Console.WriteLine("No hay tareas pendientes");
                        }
                        else
                        {
                            for (int i = 0; i < tareas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tareas[i]}");
                            }
                        }

                        Console.WriteLine($"Total de tareas: {tareas.Count}");
                        break;

                    case 3:
                        if (tareas.Count == 0)
                        {
                            Console.WriteLine("No hay tareas para eliminar");
                            break;
                        }

                        Console.WriteLine("Ingrese el numero de la tarea que desea eliminar:");

                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            if (numero >= 1 && numero <= tareas.Count)
                            {
                                tareas.RemoveAt(numero - 1);
                                Console.WriteLine("Tarea eliminada");
                            }
                            else
                            {
                                Console.WriteLine("Numero de tarea invalido");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un numero valido");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo de la lista de tareas");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }

        // 46. Administrar una lista de compras sin productos duplicados.
        public void ListaCompras()
        {
            List<string> productos = new List<string>();
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("\n1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Mostrar lista ordenada");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Seleccione una opcion:");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion invalida");
                    opcion = 0;
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el producto:");
                        string producto = Console.ReadLine();

                        if (productos.Contains(producto))
                        {
                            Console.WriteLine("El producto ya existe en la lista");
                        }
                        else
                        {
                            productos.Add(producto);
                            Console.WriteLine("Producto agregado");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el producto que desea eliminar:");
                        string eliminar = Console.ReadLine();

                        if (productos.Remove(eliminar))
                            Console.WriteLine("Producto eliminado");
                        else
                            Console.WriteLine("El producto no esta en la lista");
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el producto que desea buscar:");
                        string buscar = Console.ReadLine();

                        if (productos.Contains(buscar))
                            Console.WriteLine("El producto si esta en la lista");
                        else
                            Console.WriteLine("El producto no esta en la lista");
                        break;

                    case 4:
                        if (productos.Count == 0)
                        {
                            Console.WriteLine("La lista esta vacia");
                        }
                        else
                        {
                            productos.Sort();

                            Console.WriteLine("Lista de compras ordenada:");

                            foreach (string p in productos)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo de la lista de compras");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }

        // 47. Registrar calificaciones, calcular estadisticas y eliminar la nota mas baja.
        public void RegistroCalificaciones()
        {
            List<double> notas = new List<double>();
            string respuesta = "s";

            while (respuesta == "s" || respuesta == "S")
            {
                Console.WriteLine("Ingrese una calificacion de 0 a 100:");

                if (double.TryParse(Console.ReadLine(), out double nota))
                {
                    if (nota >= 0 && nota <= 100)
                    {
                        notas.Add(nota);
                    }
                    else
                    {
                        Console.WriteLine("La nota debe estar entre 0 y 100");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una nota valida");
                }

                Console.WriteLine("Desea ingresar otra nota? (s/n)");
                respuesta = Console.ReadLine();
            }

            if (notas.Count == 0)
            {
                Console.WriteLine("No se ingresaron calificaciones");
                return;
            }

            double suma = 0;
            double mayor = notas[0];
            double menor = notas[0];

            foreach (double n in notas)
            {
                suma = suma + n;

                if (n > mayor)
                    mayor = n;

                if (n < menor)
                    menor = n;
            }

            double promedio = suma / notas.Count;

            Console.WriteLine($"Promedio inicial: {promedio:F2}");
            Console.WriteLine($"Nota maxima: {mayor:F2}");
            Console.WriteLine($"Nota minima: {menor:F2}");

            notas.Remove(menor);

            if (notas.Count > 0)
            {
                suma = 0;

                foreach (double n in notas)
                {
                    suma = suma + n;
                }

                promedio = suma / notas.Count;

                Console.WriteLine("Se elimino una nota minima");
                Console.WriteLine($"Nuevo promedio: {promedio:F2}");
            }
            else
            {
                Console.WriteLine("La lista quedo vacia al eliminar la unica nota");
            }
        }

        // 48. Guardar numeros sin repetir y contar cuantos duplicados se descartaron.
        public void NumerosUnicos()
        {
            Console.WriteLine("Cuantos numeros desea ingresar?");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Ingrese una cantidad valida");
                return;
            }

            List<int> numeros = new List<int>();
            int duplicados = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese el numero {i + 1}:");

                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (!numeros.Contains(numero))
                    {
                        numeros.Add(numero);
                    }
                    else
                    {
                        duplicados++;
                        Console.WriteLine("Ese numero ya existe");
                    }
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                    i--;
                }
            }

            Console.WriteLine("Lista de numeros unicos:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine($"Cantidad de numeros unicos: {numeros.Count}");
            Console.WriteLine($"Duplicados descartados: {duplicados}");
        }

        // 49. Separar 15 numeros en una lista de pares y otra de impares.
        public void SepararParesImpares()
        {
            List<int> numeros = new List<int>();
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingrese el numero {i + 1}:");

                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numeros.Add(numero);

                    if (numero % 2 == 0)
                        pares.Add(numero);
                    else
                        impares.Add(numero);
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                    i--;
                }
            }

            pares.Sort();
            impares.Sort();

            Console.WriteLine("Numeros pares ordenados:");

            foreach (int numero in pares)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Numeros impares ordenados:");

            foreach (int numero in impares)
            {
                Console.WriteLine(numero);
            }
        }

        // 50. Registrar estudiantes con sus promedios usando dos listas relacionadas.
        public void RegistroEstudiantes()
        {
            List<string> nombres = new List<string>();
            List<double> promedios = new List<double>();
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("\n1. Agregar estudiante");
                Console.WriteLine("2. Buscar estudiante");
                Console.WriteLine("3. Mostrar mejor promedio");
                Console.WriteLine("4. Mostrar todos los estudiantes");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Seleccione una opcion:");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion invalida");
                    opcion = 0;
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del estudiante:");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese su promedio:");

                        if (double.TryParse(Console.ReadLine(), out double promedio))
                        {
                            if (promedio >= 0 && promedio <= 100)
                            {
                                nombres.Add(nombre);
                                promedios.Add(promedio);
                                Console.WriteLine("Estudiante agregado");
                            }
                            else
                            {
                                Console.WriteLine("El promedio debe estar entre 0 y 100");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Promedio invalido");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el nombre que desea buscar:");
                        string buscar = Console.ReadLine();
                        bool encontrado = false;

                        for (int i = 0; i < nombres.Count; i++)
                        {
                            if (nombres[i].ToLower() == buscar.ToLower())
                            {
                                Console.WriteLine($"Nombre: {nombres[i]}");
                                Console.WriteLine($"Promedio: {promedios[i]:F2}");
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                            Console.WriteLine("Estudiante no encontrado");
                        break;

                    case 3:
                        if (nombres.Count == 0)
                        {
                            Console.WriteLine("No hay estudiantes registrados");
                            break;
                        }

                        int mejor = 0;

                        for (int i = 1; i < promedios.Count; i++)
                        {
                            if (promedios[i] > promedios[mejor])
                                mejor = i;
                        }

                        Console.WriteLine($"Mejor estudiante: {nombres[mejor]}");
                        Console.WriteLine($"Promedio: {promedios[mejor]:F2}");
                        break;

                    case 4:
                        if (nombres.Count == 0)
                        {
                            Console.WriteLine("No hay estudiantes registrados");
                        }
                        else
                        {
                            Console.WriteLine("Listado de estudiantes:");

                            for (int i = 0; i < nombres.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {nombres[i]} - Promedio: {promedios[i]:F2}");
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del registro");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}