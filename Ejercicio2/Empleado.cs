using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Empleado
{
    private string Nombre, Apellido, direccion, descripcionProfesional;
    private DateTime fechaIngreso, fechaNace, fechaDivorcio; //La fecha del divorcio se usa solo en caso de que el empleado se haya divorciado
    private const double sueldoBasico = 51200.0;
    private const double desc = 0.15;
    //Datos adicionales
    private bool esCasado, esDivorciado, esTsitulado;
    private int cantHijos;
    private string titulo;
    private Universidades universidad;
        //private int edad;
        //private float saldo;
    private static int autonumerico;
    private int codigo;

    //Metodo constructor
    public Empleado(string nombre, string apellido, string direccion, string descripcionProfesional, DateTime ingreso, DateTime fechaNacimiento)
    {
        autonumerico++;
        this.codigo = autonumerico;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.direccion = direccion;
        this.descripcionProfesional = descripcionProfesional;
        this.fechaIngreso = ingreso;
        this.fechaNace = fechaNacimiento;
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

    //Funcion para obtener la antiguedad del empleado en la empresa tanto en dias como en anios
    public int Antiguedad()
    {
        int diferencia = (this.fechaIngreso - DateTime.Now).Days;
        return Math.Abs(diferencia);
    }

    public int aniosAntiguedad()
    {
        int cantAnios = 0;
        int dias = Antiguedad();
        while(dias >= 365)
        {
            cantAnios++;
            dias-=365;
        }
        return cantAnios;
    }

    //Funcion para obtener la edad del empleado
    public int edad()
    {
        int diasVivo =  Math.Abs((DateTime.Now - this.fechaNace).Days);
        int anios = 0;
        while(diasVivo >= 365)
        {
            anios++;
            diasVivo-=365;
        }
        return anios;
    }

    //Funcion para obtenter el salario correspondiente al empleado segun su antiguedad
    public double Salario()
    {
        return sueldoBasico + Adicional() - Descuento();
    }

    //Funcion para obtener el descuento
    public double Descuento()
    {
        return (sueldoBasico * desc) / 100;
    }

    public double Adicional()
    {
        if(aniosAntiguedad()<20)
        {
            return (sueldoBasico * aniosAntiguedad()) / 100;
        }else
        {
            return 0.25;
        }
    }

    //Funciones setter para modificar datos de la clase
    public void setCasado(bool respuesta)
    {
        this.esCasado = respuesta;
    }

    public void setDivorciado(bool respuesta)
    {
        this.esDivorciado = respuesta;
        if(respuesta == true)
        {
            Console.WriteLine("\nIngrese la fecha en la que se produjo el divorcio:");
            Console.WriteLine("Anio:");
            string anio = Console.ReadLine();
            Console.WriteLine("Mes:");
            string mes = Console.ReadLine();
            Console.WriteLine("Dia:");
            string dia = Console.ReadLine();

            DateTime fechaDivorcio = DateTime.TryParseExact(anio+"/"+mes+"/"+dia,"yy-MM-dd",null,DateTimeStyles.None, out fechaDivorcio);
            setFechaDivorcio(fechaDivorcio);
        }
    }

    //Metodo privado para asi evitar que si el empleado indico que no se divorcio no ingrese de todas formas una fecha y corromper la logica del programa 
    private void setFechaDivorcio(DateTime fecha)
    {
        this.fechaDivorcio = fecha;
    }

    public void MuestraEmpleado()
    {
        Console.WriteLine($"\nNombre y Apellido: {getNombre()}, {getApellido()}\nEdad: {edad()} anios\nDireccion: {getDireccion()}\nAnios de antiguedad en la empresa: {aniosAntiguedad()}\nAntiguedad en dias: {Antiguedad()}\nSalario: $ {Salario()}\nCodigo de empleado: {this.codigo}");
    }
}   