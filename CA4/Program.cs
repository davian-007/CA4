using System;
using System.IO;
using System.Text;


namespace CA4
{
    class Program
    {
        static Book Libro = new Book();

        static int option = 0;
        static int size = 3;
        [Flags]
        enum BookPrice
        {
            Bajo = 500,
            MedioBajo = 2500,
            Medio = 5000,
            MedioAlto = 7500,
            Alto = 10000,
        };

        static void AddBooks()
        {
            //agregar libro
            int r = 0, i= 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < Libro.size)
                {
                    Console.WriteLine("-* Librería el Buen Lector  *-*");
                    Console.WriteLine("Ingreso de libros.             ");
                    Console.Write("Digite el ID:                  ");
                    Libro.SetBookID(int.Parse(Console.ReadLine()));
                    Console.Write("Digite el nombre del libro:    ");
                    Libro.SetBookName(Console.ReadLine());
                    /*Console.Write("Digite el autor del libro:     ");
                    Console.ReadLine();
                    Console.WriteLine("Seleccione el precio del libro:");
                    Console.Write(BookPrice.Bajo + ":" + (int)BookPrice.Bajo + "\n" +
                    BookPrice.MedioBajo + ":" + (int)BookPrice.MedioBajo + "\n" +
                    BookPrice.Medio + ":" + (int)BookPrice.Medio + "\n" +
                    BookPrice.MedioAlto + ":" + (int)BookPrice.MedioAlto + "\n" +
                    BookPrice.Alto + ":" + (int)BookPrice.Alto + "\n");
                    double.Parse(Console.ReadLine());*/
                    if (Libro.AddData(Libro) == true)
                        Console.WriteLine("Libro agregado correctamente");
                    else
                        Console.WriteLine("Libro no agregado");
                    Console.WriteLine("Desea agregar otro libro 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de libros lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void ShowBooks()
        {
            //listar libros
            int reg = 0, i;
            Console.Clear();
            Console.WriteLine("-* Librería el Buen Lector  *-*");
            Console.WriteLine("Listado de libros.             ");
            for (i = 0; i < Libro.size; i++)
            {
                Libro.PrintData(i);
                reg = i + 1;
                Console.WriteLine("Registro: " + reg);
                Console.WriteLine("ID:       " + Libro.GetBookID());
                Console.WriteLine("Nombre:   " + Libro.GetBookName());
                /*Console.WriteLine("Auto:     " + );
                Console.WriteLine("Precio:   " + );*/
            }
            Console.ReadKey();
        }

        static void SeekBooks()
        {
            //buscar libro
            int ID = 0, reg = 0, r = 0;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Librería el Buen Lector  *-*");
                Console.WriteLine("Búsquedad de libros.           ");
                Console.WriteLine("Digite el ID del libro a buscar");
                ID = int.Parse(Console.ReadLine());
                if (Libro.SeekData(ID) == true)
                {
                    reg = ID;
                    Console.WriteLine("Registro: " + reg);
                    Console.WriteLine("ID:       " + Libro.GetBookID());
                    Console.WriteLine("Nombre:   " + Libro.GetBookName());
                    /*Console.WriteLine("Auto:     " + );
                    Console.WriteLine("Precio:   " + );*/
                }
                else
                    Console.WriteLine("No se encontro ese ID");
                Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void PrintInvoice()
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            Console.WriteLine(currentPath + @"\Invoice.txt");

            StreamWriter sw = new StreamWriter(currentPath + @"\Invoice.txt");
            //Imprimiendo la factura
            sw.WriteLine("===================================================================");
            sw.WriteLine("*-*                  Librería El Buen Lector                    *-*");
            sw.WriteLine("===================================================================");
            sw.WriteLine(" Factura Proforma\t\t\t\t\t    N°0001");
            sw.Write(" Cliente : ");
            sw.WriteLine("Jorge Cordoba");
            sw.Write(" Teléfono: ");
            sw.WriteLine("88775599");
            sw.WriteLine("-------------------------------------------------------------------");
            sw.WriteLine(" Item\t\t\t\tCtd\tPrecio\t\tSubTotal");
            sw.WriteLine("-------------------------------------------------------------------");
            sw.Write(" El Señor de los anillos, las..");
            sw.Write("\t" + "1");
            sw.Write("\t¢" + "4999,99");
            sw.WriteLine("\t¢" + "4999.99");
            sw.WriteLine("-------------------------------------------------------------------");
            sw.Write(" Total Orden:    \t\t\t\t\t");
            sw.WriteLine("¢" + "4999.99");
            sw.Write(" Total Descuento:    \t\t\t\t\t");
            sw.WriteLine("¢" + "499,99");
            sw.Write(" Impuesto Venta: \t\t\t\t\t");
            sw.WriteLine("13" + "%");
            sw.Write(" Impuesto Total: \t\t\t\t\t");
            sw.WriteLine("¢" + "539.99");
            sw.Write(" Precio Neto:    \t\t\t\t\t");
            sw.WriteLine("¢" + "4999,99");
            sw.WriteLine("-------------------------------------------------------------------");
            sw.Write(" Monto Recibido:");
            sw.WriteLine("¢" + "50000");
            sw.Write(" Monto Cambio  :");
            sw.WriteLine("¢" + "1");
            sw.WriteLine("===================================================================");
            sw.Write(" Gracias por comprar con nosotros...");
            sw.Close();
        }

        static void Main()
        {
            //inicializar el objeto
            Libro.SetSize(size);
            Libro.Initdata();

            PrintInvoice();

            do
            {
                Console.Clear();
                Console.WriteLine("-* Librería el Buen Lector  *-*");
                Console.WriteLine("1. Ingreso de libros.");
                Console.WriteLine("2. Modificación de libros.");
                Console.WriteLine("3. Eliminación de libros.");
                Console.WriteLine("4. Búsquedad de libros.");
                Console.WriteLine("5. Listado de libros.");
                Console.WriteLine("6. Venta de libros.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {                            
                            AddBooks();
                            break;
                        }
                    case 2:
                        {
                            //Modificar la información
                            break;
                        }
                    case 3:
                        {
                            //Eliminar información dejando campos en 0 o vacío
                            break;
                        }
                    case 4:
                        {
                            SeekBooks();
                            break;
                        }
                    case 5:
                        {
                            ShowBooks();
                            break;
                        }
                    case 6:
                        {
                            //Venta similar a tarea1
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}
