using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

main();

int main()
{
    DateTime fecha1 = new DateTime(2020,05,04);
    DateTime fecha2 = new DateTime(2018,07,11);
    DateTime fecha3 = new DateTime(2010,11,07);
    DateTime fechaNacimiento1 = new DateTime(2000,05,04);
    DateTime fechaNacimiento2 = new DateTime(1995,11,13);
    DateTime fechaNacimiento3 = new DateTime(1969,03,25);
    Empleado empleado1 = new Empleado("Agustin", "Lobo", "Rojas Paz 33", "Trabaja como programador", fecha1, fechaNacimiento1);
    Empleado empleado2 = new Empleado("Esteban", "Quito", "En la concha del mono", "Trabaja como analista", fecha2, fechaNacimiento2);
    Empleado Jefe = new Empleado("Putoel", "Quelee", "Ni el sabe donde vive", "Se rasca a cuatro manos", fecha3, fechaNacimiento3);

    empleado2.setCasado(true);
    empleado1.setDivorciado(true);
    empleado1.MuestraEmpleadoModificado();
    empleado2.MuestraEmpleadoModificado();
    Jefe.setCantidadHijos(10);
    Jefe.setDivorciado(true);
    Jefe.MuestraEmpleadoModificado();
    //Modifico el empleado jefe y empleado1

    return 0;
}