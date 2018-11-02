using System;
using Metodos;
using System.Collections.Generic;
namespace ejerciciosArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsuarioBanco> clientes = new List<UsuarioBanco>();
            UsuarioBanco cliente = new UsuarioBanco();
            int NroCliente = 0;

        InicioBanco:
            string menuBanco = @"TREBOLBANK - FILIAL CODITEC - CODIGO - TECSUP - TrebolTronik:
            0. Crear nuevo cliente.
            1. Eliminar cliente.
            2. Editar datos de cliente
            3. Hacer deposito a cuenta
            4. Retirar dinero de cuenta.";

            Console.WriteLine(menuBanco);
            Console.WriteLine("------------------------------------------------------");
            cliente.MostrarEstadoClientes(clientes);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese la operacion a realizar:");
            int operacion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (operacion)
            {
                case 0:
                    cliente.MostrarEstadoClientes(clientes);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("CREAR NUEVO CLIENTE - TREBOLBANK");
                    NroCliente++;
                    UsuarioBanco nuevoCliente = new UsuarioBanco();
                    nuevoCliente.RandomAp();
                    clientes.Add(nuevoCliente);
                    //Console.WriteLine($"Ingrese Nombre de cliente{NroCliente}:");
                    //cliente1.Nombre = Console.ReadLine();
                    //Console.WriteLine($"Ingrese Apellido de cliente{NroCliente}:");
                    //cliente1.Apellido = Console.ReadLine();
                    //Console.WriteLine($"Ingrese DNI de cliente{NroCliente}:");
                    //cliente1.Dni = Console.ReadLine();
                    //Console.WriteLine($"Ingrese Edad de cliente{NroCliente}");
                    //cliente1.Edad = Console.ReadLine();
                    //Console.WriteLine($"Ingrese Contraseña de cliente{NroCliente}:");
                    //cliente1.Contraseña = Console.ReadLine();
                    //Console.WriteLine($"Ingrese Saldo inicial de cliente{NroCliente}:");
                    //cliente1.Saldo = double.Parse(Console.ReadLine());
                    Console.Clear();
                    goto InicioBanco;
                    //break;
                case 1:
                    cliente.MostrarEstadoClientes(clientes);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("ELIMINAR CLIENTE - TREBOLBANK");
                    Console.WriteLine("Ingrese Dni del cliente:");
                    string busqueda = Console.ReadLine();
                    for (int i = 0; i < clientes.Count; i++)
                    {
                        if (busqueda == clientes[i].Dni)
                        {
                            Console.WriteLine("Ingrese contraseña de admin");
                            string passAdmin = Console.ReadLine();
                            if(cliente.PassAdmin == passAdmin)
                                clientes.Remove(clientes[i]);
                        }
                    }
                    Console.Clear();
                    goto InicioBanco;
                    //break;
                case 2:
                    cliente.MostrarEstadoClientes(clientes);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("EDITAR DATOS PERSONALES DE CLIENTE - TREBOLBANK");
                    Console.WriteLine("Ingrese Apellido del cliente:");
                    string busqueda2 = Console.ReadLine();
                    for (int i = 0; i < clientes.Count; i++)
                    {
                        if (busqueda2 == clientes[i].Apellido)
                        {
                            EditarCliente:
                            clientes[i].MostrarEstadoCuenta(i);
                            Console.WriteLine("------------------------------------------------------");
                            Console.WriteLine("¿Qué desea editar?");
                            Console.WriteLine("1) Nombre");
                            Console.WriteLine("2) Apellido");
                            Console.WriteLine("3) Edad");
                            Console.WriteLine("4) Contraseña");
                            Console.WriteLine("5) DNI");
                            int seleccion = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese contraseña de admin");
                            string passAdmin = Console.ReadLine();
                            if (cliente.PassAdmin == passAdmin)
                            {
                                switch (seleccion)
                                {
                                    case 1:
                                        Console.WriteLine("Ingrese nuevo nombre:");
                                        clientes[i].Nombre = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("Ingrese nuevo apellido:");
                                        clientes[i].Apellido = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.WriteLine("Ingrese nueva edad:");
                                        clientes[i].Edad = Console.ReadLine();
                                        break;
                                    case 4:
                                        Console.WriteLine("Ingrese nueva contraseña:");
                                        clientes[i].Contraseña = Console.ReadLine();
                                        break;
                                    case 5:
                                        Console.WriteLine("Ingrese nuevo DNI:");
                                        clientes[i].Dni = Console.ReadLine();
                                        break;
                                }
                                Console.WriteLine("¿Desea editar algo más? Si=1/No=0");
                                int respuesta = int.Parse(Console.ReadLine());
                                if (respuesta == 1) { goto EditarCliente; }
                            }
                        }
                    }
                    Console.Clear();
                    goto InicioBanco;
                    //break;
                case 3:
                    cliente.MostrarEstadoClientes(clientes);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("HACER DEPOSITO - TREBOLBANK");
                    Console.WriteLine("Ingrese cantidad a aumentar:");
                    double aumentarCantidad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese Apellido del cliente:");
                    string busqueda3 = Console.ReadLine();

                    for (int i = 0; i < clientes.Count; i++)
                    {
                        if (busqueda3 == clientes[i].Apellido)
                        {
                            Console.WriteLine("Ingrese contraseña de usuario");
                            string passUser = Console.ReadLine();
                            if (clientes[i].Contraseña == passUser)
                                clientes[i].AñadirSaldo(aumentarCantidad);
                        }
                    }
                    Console.Clear();
                    goto InicioBanco;
                    //break;
                case 4:
                    cliente.MostrarEstadoClientes(clientes);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("HACER RETIRO DE CUENTA - TREBOLBANK");
                    Console.WriteLine("Ingrese cantidad a retirar:");
                    double reducirCantidad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese contraseña o Apellido del cliente:");
                    string busqueda4 = Console.ReadLine();

                    for (int i = 0; i < clientes.Count; i++)
                    {
                        if (busqueda4 == clientes[i].Contraseña || busqueda4 == clientes[i].Apellido)
                        {

                            Console.WriteLine("Ingrese contraseña de usuario");
                            string passUser = Console.ReadLine();
                            if (clientes[i].Contraseña == passUser)
                                clientes[i].AñadirSaldo(reducirCantidad * -1);
                        }
                    }
                    Console.Clear();
                    goto InicioBanco;
                    //break;
            }
        }
    }
}
