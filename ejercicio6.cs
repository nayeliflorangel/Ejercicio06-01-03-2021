using System;

namespace Arrays
{
    class Program
    {
        public static int count = 0;
        public static Image[] images = new Image[700];
        static void Main(string[] args)
        {
            //for (int i = 0; i < 700; i++) { images[i] = new Image(); }
            bool boolean = true;
            string choice;
            while (boolean)
            {
                Console.Clear();
                if (count <= 700)
                {
                    Console.WriteLine("1. Añadir ficha nueva.\n2. Ver fichas.\n3. Buscar ficha.\nX. Cerrar.\n\nElija una opción: ");
                    choice = Console.ReadLine().ToUpper();
                    switch (choice)
                    {
                        case "1":
                            AddFile();
                            break;
                        case "2":
                            ShowFile();
                            break;
                        case "3":
                            SearchFile();
                            break;
                        case "X":
                            boolean = Close();
                            break;
                        default:
                            Default();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Capacidad máxima.");
                    boolean = false;
                }
            }
        }

        static void AddFile()
        {
            Console.Clear();
            Console.WriteLine("Introduzca los siguientes datos: ");
            Console.Write("Nombre: ");
            //images[count].Name = Console.ReadLine();
            string name = Console.ReadLine();
            Console.Write("Ancho: ");
            //images[count].Witdh = double.Parse(Console.ReadLine());
            double witdh = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            //images[count].Height = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.Write("Peso: ");
            //images[count].Weight = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            images[count] = new Image(name, witdh, height, weight);
            count++;
            Console.WriteLine("\n\nArchivo guardado.");
            Console.WriteLine("\nPresione cualquier tecla para continuar.");
            Console.ReadKey();
        }

        static void ShowFile()
        {
            Console.Clear();
            Console.WriteLine("Nombre\t\tAncho\t\tAltura\t\tPeso");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{images[i].Name}\t\t{images[i].Witdh}\t\t{images[i].Height}\t\t{images[i].Weight}");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar.");
            Console.ReadKey();
        }

        static void SearchFile()
        {
            Console.Clear();
            Console.Write("Escriba el nombre del archivo: ");
            string fileName = Console.ReadLine();
            for(int i = 0; i < count; i++)
            {
                if (fileName == images[i].Name)
                {
                    Console.WriteLine($"Nombre: {images[i].Name}.\nAncho: {images[i].Witdh}.\nAltura: {images[i].Height}.\nPeso: {images[i].Weight}.");
                }
                else { Console.WriteLine("No encontrado."); }
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar.");
            Console.ReadKey();
        }

        static bool Close()
        {
            Console.Clear();
            return false;
        }

        static void Default()
        {
            Console.Clear();
            Console.WriteLine("Ha introducido una opción inexistente.");
            Console.WriteLine("\nPresione cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }

    class Image
    {
        public string Name { get; set; }
        public double Witdh { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Image(string name, double witdh, double height, double weight)
        {
            this.Name = name;
            this.Witdh = witdh;
            this.Height = height;
            this.Weight = weight;
        }
    }
}
