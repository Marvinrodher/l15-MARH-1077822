internal class Program
{
    static void Main(string[] args)
    {
        string selec;
        Console.WriteLine("Coloque el numero de la opcion que quiere ejecutar");
        Console.WriteLine("Para la funcion de nombres y edades presionar el numero 1");
        Console.WriteLine("Para la funcion de nombres y notas presionar el numero 2");
        Console.WriteLine("Para salir presione el numero 3");
        selec = Console.ReadLine();
        switch (selec)
        {
            case "1":
                string[] nombresdelosalumnos = new string[5];
                int[] edades = new int[5];
                string[] personamayor = new string[5];


                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine("Ingrese un nombre:");
                    nombresdelosalumnos[f] = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad de esa persona");
                    edades[f] = int.Parse(Console.ReadLine());
                }



                double mayor = 0;
                int m = 0;
                string masmayor = "";
                for (int i = 0; i < 5; i++)
                {
                    if (mayor < edades[i])
                    {
                        mayor = edades[i];
                        m = i + 1;
                        masmayor = nombresdelosalumnos[i];

                    }
                }

                Console.WriteLine("La persona mayor es : " + masmayor );

                double prom = 0;
                double sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum + edades[i];
                }

                prom = sum / 5;
                Console.WriteLine("El promedio es: " + prom);

                break;

            case "2":
                int[] no = new int[5];
                string[] namea = new string[5];
               

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese el nombre :");
                    namea[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese la nota:");
                    no[i] = int.Parse(Console.ReadLine());
                }


                for (int i = 0; i < 5; i++)
                {
                    if (no[i] < 70)
                    {
                        Console.WriteLine("Estos estudiantes perdieron la clase " + namea[i]);
                    }
                    else
                    {
                        Console.WriteLine("Ganó la clase " + namea[i]);
                    }
                }

                int aa = 0;
                double may = 0;
                string alex = "";
                double men = 0;
                int sir = 0;
                string bajo = "";
                for (int i = 0; i < 5; i++)
                {
                    if (may < no[i])
                    {
                        may = no[i];
                        aa = i + 1;
                        alex = namea[i];

                    }
                    else if (no[i] < men)
                    {
                        mayor = no[i];
                        sir = i + 1;
                        bajo = namea[i];
                    }
                }

                Console.WriteLine("Los que ganaron: " + alex);
                Console.WriteLine("Los que perdieron fueron: " + bajo);


               

                double promedio = 0;
                double suma = 0;
                for (int i = 0; i < 5; i++)
                {
                    suma = suma + no[i];
                }

                promedio = suma / 5;
                Console.WriteLine("El promedio es" + promedio);
                break;

            case "3":
                Console.WriteLine("Programa finalizado");
                break;
        }
    }
}
