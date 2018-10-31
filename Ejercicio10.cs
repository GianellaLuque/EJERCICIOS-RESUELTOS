using System;
using Metodos;
namespace ejerciciosArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            InicioBanco:
            string menuBanco = @"Operaciones Banco:
            0. Crear nuevo cliente..
            1. Mostrar saldo de cliente.
            3. Editar datos de cliente
            4. Eliminar nuevo cliente.
            5. Aumentar saldo a cliente";
            Console.WriteLine(menuBanco);
            Console.WriteLine("Ingrese la operacion a realizar:");
            int operacion = Convert.ToInt16(Console.ReadLine());
            UsuarioBanco cliente = new UsuarioBanco();
            int NroCliente = 0;
            switch (operacion)
            {
                case 0:
                    NroCliente++;
                    //string usuario = "usuario";
                    //usuario += Convert.ToString(cliente);
                    if(NroCliente == 1)
                    {
                        UsuarioBanco cliente1 = new UsuarioBanco();
                        Console.WriteLine("Ingrese Nombre primer usuario:");
                        cliente1.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido primer usuario:");
                        cliente1.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese DNI primer usuario:");
                        cliente1.Dni = Console.ReadLine();
                        Console.WriteLine("Ingrese Edad primer usuario:");
                        cliente1.Edad = Console.ReadLine();
                        Console.WriteLine("Ingrese Contraseña primer usuario:");
                        cliente1.Contraseña = Console.ReadLine();
                        Console.WriteLine("Ingrese Saldo inicial primer usuario:");
                        cliente1.Saldo = Double.Parse(Console.ReadLine());

                        cliente = cliente1;
                        goto InicioBanco;

                    }
                    if(NroCliente == 2)
                    {
                        UsuarioBanco cliente2 = new UsuarioBanco();
                        Console.WriteLine("Ingrese Nombre primer usuario:");
                        cliente2.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido primer usuario:");
                        cliente2.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese DNI primer usuario:");
                        cliente2.Dni = Console.ReadLine();
                        Console.WriteLine("Ingrese Edad primer usuario:");
                        cliente2.Edad = Console.ReadLine();
                        Console.WriteLine("Ingrese Contraseña primer usuario:");
                        cliente2.Contraseña = Console.ReadLine();
                        Console.WriteLine("Ingrese Saldo inicial primer usuario:");
                        cliente2.Saldo = Double.Parse(Console.ReadLine());

                        cliente = cliente2;
                        goto InicioBanco;
                    }
                    if (NroCliente == 3)
                    {
                        UsuarioBanco cliente3 = new UsuarioBanco();
                        Console.WriteLine("Ingrese Nombre primer usuario:");
                        cliente3.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido primer usuario:");
                        cliente3.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese DNI primer usuario:");
                        cliente3.Dni = Console.ReadLine();
                        Console.WriteLine("Ingrese Edad primer usuario:");
                        cliente3.Edad = Console.ReadLine();
                        Console.WriteLine("Ingrese Contraseña primer usuario:");
                        cliente3.Contraseña = Console.ReadLine();
                        Console.WriteLine("Ingrese Saldo inicial primer usuario:");
                        cliente3.Saldo = Double.Parse(Console.ReadLine());

                        cliente = cliente3;
                        goto InicioBanco;
                    }
                    break;
                case 1:
                    Console.WriteLine("Saldo del cliente:");
                    cliente.MostrarEstadoCuenta();
                    

                    goto InicioBanco;
                    break;
                case 2:

                    goto InicioBanco;
                    break;
                case 3:

                    goto InicioBanco;
                    break;
                case 5:
                    Console.WriteLine("Ingrese cantidad a aumentar:");
                    double aumentarCantidad = Convert.ToDouble(Console.ReadLine());
                    cliente.AñadirSaldo(aumentarCantidad);
                    goto InicioBanco;
                    break;
            }
        }

    }
}
