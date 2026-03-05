using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Empleado : Usuario
    {
        int id;
        int idDepartamento;
        string cargo = "";

        public Empleado(string Nombre, string Apellido, int Edad, string Telefono, string Direccion, int Cedula, int Id, int IdDepartamento, string Cargo) : base(Nombre, Apellido, Edad, Telefono, Direccion, Cedula)
        {
            id = Id;
            idDepartamento = IdDepartamento;
            cargo = Cargo;
        }

        public override string ToString()
        {
            return $"{nombre}, " +
                $"{apellido}, " +
                $"{edad}, " +
                $"{telefono}, " +
                $"{direccion}, " +
                $"{cedula}, " +
                $"{id}, " +
                $"{idDepartamento}, " +
                $"{cargo}.";
        }
    }
}
