using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program
{
    internal class Usuario
    {
        protected string nombre = "";
        protected string apellido = "";
        protected int edad = 0;
        protected string telefono = "";
        protected string direccion = "";
        protected char sexo = '\0';
        protected int cedula;

        public Usuario(string Nombre, string Apellido, int Edad, string Telefono, string Direccion, int Cedula)
        {
            nombre = Nombre;
            apellido = Apellido;
            edad = Edad;
            telefono = Telefono;
            direccion = Direccion;
            cedula = Cedula;
        }

        public override string ToString()
        {
            return $"{nombre}, " +
                $"{apellido}, " +
                $"{edad}, " +
                $"{telefono}, " +
                $"{direccion}, " +
                $"{cedula}.";
        }
    }
}
