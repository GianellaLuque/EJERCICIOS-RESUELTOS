using System;

namespace Ejercicio9
{
    class Program
    {
        //Una tienda almacena la cantidad de piezas vendidas para cada uno de sus Productos en los tres turnos del día: 
        //mañana, tarde y noche, demás almacena en un array el precio unitario de cada uno de sus productos.
        //Realizar un algoritmo que te calcule las unidades vendidas para cada producto en todo el día y a cuánto asciende la suma total

        //Llena el array de Precio de Producto con numeros aleatorios del 5 al 30
        public static double[] LlenarPrecio()
        {
            Random rdn = new Random();
            double[] array = new double[10];
            for (int i = 0; i < array.Length; i++)
            {
                int a = rdn.Next(5, 30);
                array[i] = a;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("El producto " + i + " tiene un valor de: " + array[i] + "$");
            }
            return (array);
        }
        //Ingresa el numero de piezas vendidas por cada producto en todos los TURNOS
        public static double[] Ingreso(double [] array)
        {
            double[] arrayT = new double[10];
            string resM, resT, resN = "";
            int NroPm, NroM, NroPt, NroMt, NroPn, NroMn = 0;

            //TURNO MAÑANA
            Console.WriteLine("\n****Ingrese la venta del Turno Mañana****\n");
            do{
                Console.WriteLine("Ingrese el numero del producto 0 a 10");
                NroPm = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de piezas vendidas");
                NroM = int.Parse(Console.ReadLine());
                for (int i = 0; i < array.Length; i++)
                {
                    if (NroPm == i){
                        arrayT[i] = arrayT[i] + (NroM * array[i]);
                    }
                }
                Console.WriteLine("Desea ingresar mas? S/N");
                resM = Console.ReadLine();
            } while (resM == "S");

            //TURNO TARDE
            Console.WriteLine("\n****Ingrese la venta del Turno Tarde****\n");
            do{
                Console.WriteLine("Ingrese el numero del producto 0 a 10");
                NroPt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de piezas vendidas");
                NroMt = int.Parse(Console.ReadLine());
                for (int i = 0; i < array.Length; i++)
                {
                    if (NroPt == i){
                        arrayT[i] = arrayT[i] + (NroMt * array[i]);
                    }
                }
                Console.WriteLine("Desea ingresar mas? S/N");
                resT = Console.ReadLine();
            } while (resT == "S");

            //TURNO NOCHE
            Console.WriteLine("\n****Ingrese la venta del Turno NOCHE****\n");
            do{
                Console.WriteLine("Ingrese el numero del producto 0 a 10");
                NroPn = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de piezas vendidas");
                NroMn = int.Parse(Console.ReadLine());
                for (int i = 0; i < array.Length; i++)
                {
                    if (NroPn == i){
                        arrayT[i] = arrayT[i] + (NroMn * array[i]);
                    }
                }
                Console.WriteLine("Desea ingresar mas? S/N");
                resN = Console.ReadLine();
            } while (resN == "S");
            return (arrayT);
        }
        //Realiza la suma de todos los productos vendidos en todo el dia
        public static double Suma(double[] array)
        {
            double suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma = suma + array[i];
            };
            return(suma);
        }
        //Imprime la ganancia por cada producto y la suma total del dia
        public static void Imprimir(double[] array , double sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("El producto " + i + " tuvo una ganancia de: " + array[i]+"$");
            }
            Console.WriteLine("La ganancia del dia es: " + sum);
        }
        static void Main(string[] args)
        {
            double[] arra;
            double suma;
            arra = LlenarPrecio();
            arra = Ingreso(arra);
            suma = Suma(arra);
            Imprimir(arra, suma);
        }
    }
}
