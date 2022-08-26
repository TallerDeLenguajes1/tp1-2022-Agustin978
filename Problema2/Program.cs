// See https://aka.ms/new-console-template for more information
using System;

main();

int main()
{
    Console.WriteLine($"El resultado de la division es: {divideNumeros()}");
    return 0;
}

double divideNumeros()
{
    double num1, num2;

    try
    {
        Console.WriteLine("Ingrese el dividendo:");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el divisor:");
        num2 = double.Parse(Console.ReadLine());
        return num1 / num2;
    }catch(DivideByZeroException)
    {
        Console.WriteLine("No se puede dividir en 0, vuelva a promaria >:|");
        Console.WriteLine("Maver viejo, por eso te gorrean");
        throw;
    }catch(FormatException)
    {
        Console.WriteLine("Error de formato.");
        Console.WriteLine("Maver viejo, por eso te gorrean");
        throw;
    }catch(OverflowException)
    {
        Console.WriteLine("Error de overflow");
        Console.WriteLine("Maver viejo, por eso te gorrean");
        throw;
    }catch(Exception ex)
    {
        Console.WriteLine($"Excepcion no conocida: {ex.Data}");
        throw;
    }
}