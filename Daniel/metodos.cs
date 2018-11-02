using System;
using System.Collections.Generic;
namespace Metodos
{
    public class UsuarioBanco
    {
        private string dni = Convert.ToString(new Random().Next(99999999));
        private string passUsuario = "1234";
        private string passAdmin = "daniele";
        private string nombre = "usuario";
        private string apellido = "Cabana";
        private string edad = Convert.ToString(new Random().Next(100));
        private double saldo = Convert.ToDouble(new Random().Next(999999));

        public void RandomAp()
        {
            int x = new Random().Next(6);
            switch (x)
            {
                case 0:
                    apellido = "Serrano";
                    break;
                case 1:
                    apellido = "Medina";
                    break;
                case 2:
                    apellido = "Cabana";
                    break;
                case 3:
                    apellido = "Huayhua";
                    break;
                case 4:
                    apellido = "Gutierrez";
                    break;
                case 5:
                    apellido = "Bartra";
                    break;
            }
        }

        public string Dni
        {
            get { return dni; }
            set
            {
                if (dni.Length == 8)
                    dni = value;
            }
        }
        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value > 0)
                    saldo = value;
            }
        }

        public string Contraseña
        {
            get { return passUsuario; }
            set
            {
                if (passUsuario.Length > 0 && passUsuario.Length < 10)
                    passUsuario = value;
            }
        }
        public string PassAdmin
        {
            get { return passAdmin; }
            set
            {
                if (passAdmin.Length > 0 && passAdmin.Length < 10)
                    passAdmin = value;
            }
        }
        public string Edad
        {
            get { return edad; }
            set
            {
                if (int.Parse(edad) > 0)
                    edad = value;
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (apellido.Length > 0)
                    apellido = value;
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (nombre.Length > 0)
                    nombre = value;
            }
        }

        public void MostrarEstadoClientes(List<UsuarioBanco> clients)
        {
            Console.WriteLine("ESTADO DE CUENTA DE CLIENTES - TREBOLBANK");
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].MostrarEstadoCuenta(i);
            }
        }
        public void MostrarEstadoCuenta(int i)
        {
            Console.WriteLine("{0} \t {1} \t\t {2} \t {3} \t {4} \t {5} \t {6}","Indice", "Dni", "Contraseña", "Nombre", "Apellido", "Edad", "Saldo");
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6:C}",i , dni, "********", nombre, apellido, edad, saldo);

        }

        public void AñadirSaldo(double mount)
        {
            saldo = saldo + mount;
        }
    }
}
