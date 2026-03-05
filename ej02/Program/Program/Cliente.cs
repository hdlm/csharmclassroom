using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program
{
    internal class Cliente : Usuario
    {
        int idEmpleado;
        int idCuentaBancaria;
        int fechaRegistro;

        public Cliente(string Nombre, string Apellido, int Edad, string Telefono, string Direccion, int Cedula, int IdEmpleado, int IdCuentaBancaria, int FechaRegistro) : base(Nombre, Apellido, Edad, Telefono, Direccion, Cedula)
        {
            idEmpleado = IdEmpleado;
            idCuentaBancaria = IdCuentaBancaria;
            fechaRegistro = FechaRegistro;
        }
        public override string ToString()
        {
            return $"{nombre}, " +
                $"{apellido}, " +
                $"{edad}, " +
                $"{telefono}, " +
                $"{direccion}, " +
                $"{cedula}, " +
                $"{idEmpleado}, " +
                $"{idCuentaBancaria}, " +
                $"{fechaRegistro}.";

        }
    }

}
