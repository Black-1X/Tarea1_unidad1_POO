using tarea1.Bloque1;


VariablesOperadores variablesOperadores = new VariablesOperadores();
EstructurasControl estructurasControl = new EstructurasControl();
Ciclos ciclos = new Ciclos();
Arreglos arreglos = new Arreglos();
Listas listas = new Listas();



 int op =1;

        while (op != 0)
        {
            Console.WriteLine("\n===== MENU DE EJERCICIOS =====");

            Console.WriteLine("\n--- BLOQUE 1: VARIABLES Y OPERADORES ---");
            Console.WriteLine("1. Conversor de lempiras");
            Console.WriteLine("2. Calculadora IMC");
            Console.WriteLine("3. Intercambio de valores");
            Console.WriteLine("4. Areas y perimetros");
            Console.WriteLine("5. Conversion de temperatura");
            Console.WriteLine("6. Suma de digitos");
            Console.WriteLine("7. Tiempo transcurrido");
            Console.WriteLine("8. Desglose de billetes");
            Console.WriteLine("9. Salario semanal");
            Console.WriteLine("10. Prestamo simple");

            Console.WriteLine("\n--- BLOQUE 2: CONDICIONALES ---");
            Console.WriteLine("11. Positivo, negativo o cero");
            Console.WriteLine("12. Mayor y menor");
            Console.WriteLine("13. Calculadora con switch");
            Console.WriteLine("14. Dia de la semana");
            Console.WriteLine("15. Vocal o consonante");
            Console.WriteLine("16. Calificaciones UNAH");
            Console.WriteLine("17. Descuentos");
            Console.WriteLine("18. Estacionamiento");
            Console.WriteLine("19. Clasificacion de triangulos");
            Console.WriteLine("20. Año bisiesto");
            Console.WriteLine("21. Validador de fecha");
            Console.WriteLine("22. Cajero automatico");

            Console.WriteLine("\n--- BLOQUE 3: CICLOS ---");
            Console.WriteLine("23. Tabla de multiplicar");
            Console.WriteLine("24. Suma de pares e impares");
            Console.WriteLine("25. Promedio con centinela");
            Console.WriteLine("26. Potencia con ciclo");
            Console.WriteLine("27. Inversion de numero");
            Console.WriteLine("28. Decimal a binario");
            Console.WriteLine("29. Serie Fibonacci");
            Console.WriteLine("30. Factorial y combinaciones");
            Console.WriteLine("31. MCD y MCM");
            Console.WriteLine("32. Numeros primos");
            Console.WriteLine("33. Juego de adivinanza");
            Console.WriteLine("34. Validacion de contraseña");
            Console.WriteLine("35. Patrones en consola");
            Console.WriteLine("36. Calculadora con menu");

            Console.WriteLine("\n--- BLOQUE 4: ARREGLOS ---");
            Console.WriteLine("37. Registro de numeros");
            Console.WriteLine("38. Arreglo de nombres");
            Console.WriteLine("39. Estadisticas de calificaciones");
            Console.WriteLine("40. Frecuencia de elementos");
            Console.WriteLine("41. Arreglo de temperaturas");
            Console.WriteLine("42. Busqueda y ordenamiento");
            Console.WriteLine("43. Rotacion de arreglo");
            Console.WriteLine("44. Histograma de calificaciones");

            Console.WriteLine("\n--- BLOQUE 5: LISTAS ---");
            Console.WriteLine("45. Lista de tareas");
            Console.WriteLine("46. Lista de compras");
            Console.WriteLine("47. Registro de calificaciones");
            Console.WriteLine("48. Numeros unicos");
            Console.WriteLine("49. Separar pares e impares");
            Console.WriteLine("50. Registro de estudiantes");

            Console.WriteLine("\n0. Salir");
            Console.WriteLine("Seleccione una opcion:");

            if (!int.TryParse(Console.ReadLine(), out op))
            {
                Console.WriteLine("Ingrese una opcion valida");
                op = -1;
                continue;
            }

            switch (op)
            {
                case 1: variablesOperadores.ConversorDeLempiras(); break;
                case 2: variablesOperadores.Caculadora(); break;
                case 3: variablesOperadores.Intercambio(); break;
                case 4: variablesOperadores.AreasPerimetros(); break;
                case 5: variablesOperadores.ConversionTemperatura(); break;
                case 6: variablesOperadores.SumaDigitos(); break;
                case 7: variablesOperadores.TiempoTranscurrido(); break;
                case 8: variablesOperadores.DesgloseBilletes(); break;
                case 9: variablesOperadores.SalarioSemanal(); break;
                case 10: variablesOperadores.PrestamoSimple(); break;

                case 11: estructurasControl.PositivoNegativo(); break;
                case 12: estructurasControl.MayorMenor(); break;
                case 13: estructurasControl.CalculadoraSwitch(); break;
                case 14: estructurasControl.DiaSemana(); break;
                case 15: estructurasControl.VocalConsonante(); break;
                case 16: estructurasControl.CalificacionesUNAH(); break;
                case 17: estructurasControl.Descuentos(); break;
                case 18: estructurasControl.Estacionamiento(); break;
                case 19: estructurasControl.ClasificacionTriangulos(); break;
                case 20: estructurasControl.AnioBisiesto(); break;
                case 21: estructurasControl.ValidadorFecha(); break;
                case 22: estructurasControl.CajeroAutomatico(); break;

                case 23: ciclos.TablaMultiplicar(); break;
                case 24: ciclos.SumaParesImpares(); break;
                case 25: ciclos.PromedioCentinela(); break;
                case 26: ciclos.PotenciaCiclo(); break;
                case 27: ciclos.InversionNumero(); break;
                case 28: ciclos.DecimalBinario(); break;
                case 29: ciclos.SerieFibonacci(); break;
                case 30: ciclos.FactorialCombinaciones(); break;
                case 31: ciclos.MCDMCM(); break;
                case 32: ciclos.NumerosPrimos(); break;
                case 33: ciclos.JuegoAdivinanza(); break;
                case 34: ciclos.ValidacionContrasena(); break;
                case 35: ciclos.PatronesConsola(); break;
                case 36: ciclos.CalculadoraMenu(); break;

                case 37: arreglos.RegistroNumeros(); break;
                case 38: arreglos.ArregloNombres(); break;
                case 39: arreglos.EstadisticasCalificaciones(); break;
                case 40: arreglos.FrecuenciaElementos(); break;
                case 41: arreglos.ArregloTemperaturas(); break;
                case 42: arreglos.BusquedaOrdenamiento(); break;
                case 43: arreglos.RotacionArreglo(); break;
                case 44: arreglos.HistogramaCalificaciones(); break;

                case 45: listas.ListaTareas(); break;
                case 46: listas.ListaCompras(); break;
                case 47: listas.RegistroCalificaciones(); break;
                case 48: listas.NumerosUnicos(); break;
                case 49: listas.SepararParesImpares(); break;
                case 50: listas.RegistroEstudiantes(); break;

                case 0:
                    Console.WriteLine("Gracias por ver :D");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }