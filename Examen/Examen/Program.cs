using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Examen
{
    
    //Clase
    class Producto
    {
        //Atributos de la clase
        public string nombreProducto,descripcionProducto;
        public float precio;
        public int cantidadStock;

        public void captura()
        {
            //Captura de datos
            Console.WriteLine("-AMAZON-");
            Console.WriteLine("-Captura de datos del producto-");
            Console.Write("\nIngrese nombre: ");
            nombreProducto = Console.ReadLine();
            Console.Write("Ingrese descripcion: ");
            descripcionProducto = Console.ReadLine();
            Console.Write("Ingrese precio: ");
            precio = float.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad en stock: ");
            cantidadStock = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();

            StreamWriter sw = new StreamWriter("Productos.txt", true);
            sw.Write(nombreProducto);
            sw.Write(descripcionProducto);
            sw.Write(precio);
            sw.Write(cantidadStock);
            sw.Close();
            Console.WriteLine("Datos escritos en el archivo.");
            Console.WriteLine("\nIngrese ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        //Clase de impresion
        public void Impresion()
        {
            Console.WriteLine("-Impresion de los datos del producto registrado-");
            Console.WriteLine("\nNombre: " + nombreProducto);
            Console.WriteLine("Descripcion: " + descripcionProducto);
            Console.WriteLine("Precio: " + precio);
            Console.WriteLine("Cantidad en stock: " + cantidadStock);
            Console.WriteLine("\nIngrese ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        ~Producto()
        {
            Console.WriteLine("Memoria liberada de objeto Producto");
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Producto pro = new Producto();
        
            int op;
            do
            {
                
                Console.Clear();
                Console.WriteLine("\n*** MENU DE REGISTRO PRODUCTOS AMAZON ***");
                Console.WriteLine("1.- Capturar producto.");
                Console.WriteLine("2.- Visualizar informacion del producto.");
                Console.WriteLine("3.- Salida del programa.");
                Console.WriteLine("\nQue opcion deseas: ");
                op = Int16.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //Bloque de escritura
                        try
                        {
                            pro.captura();
                            
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine(e.Message);
                            
                        }
                        break;
                    case 2:
                        //Bloque lectura
                       
                        try
                        {

                            pro.Impresion();

                        }
                        catch (IOException e)
                        {
                            Console.WriteLine(e.Message);
                            
                        }
                        break;
                    case 3:
                        Console.Write("\nPresione <enter> para salir del programa.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("\nOpcion no existente, presione <enter> para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (op != 3);         
        }
    }
}
