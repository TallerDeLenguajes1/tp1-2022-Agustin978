// See https://aka.ms/new-console-template for more information
using System;

main();

int main()
{
    //int numero;
    Console.WriteLine($"El cuadrado del numero ingresado es: {numeroCuadrado()}");
    return 0;
}

int numeroCuadrado()
{
    int numero;
    int resultado;
    try
    {
        Console.WriteLine("Ingrese un numero:");
        numero = Int32.Parse(Console.ReadLine());
        resultado = numero * numero;
        return resultado;
    }catch(FormatException e)
    {
        Console.WriteLine($"{e.Data}\n{e.Message}\n{e.GetBaseException}");
        Console.WriteLine("Error de formato.");
        throw;
    }catch(OverflowException e)
    {
        Console.WriteLine("Error de overflow");
        throw;
    }catch(Exception excepcion)
    {
        Console.WriteLine($"Error no verificado: {excepcion.Data}");
        throw;
    }
}