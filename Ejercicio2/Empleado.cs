using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Empleado
    {
        private string Nombre, Apellido, direccion, descripcionProfesional;
        private DateTime fechaIngreso;
        private static int autonumerico;
        private int codigo;

        //Metodo constructor
        public Empleado(string nombre, string apellido, string direccion, string descripcionProfesional, DateTime ingreso)
        {
            autonumerico++;
            this.codigo = autonumerico;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.direccion = direccion;
            this.descripcionProfesional = descripcionProfesional;
            this.fechaIngreso = ingreso;
        }

        //Metodos getter
        public string getNombre()
        {
            return this.Nombre;
        }       
        
        public string getApellido()
        {
            return this.Apellido;
        }

        public string getDireccion()
        {
            return this.direccion;
        }

        public string getDescProfesional()
        {
            return this.descripcionProfesional;
        }

        public string DiasEnEmpresa()
        {
            
        }
    }
}