using System;

Console.WriteLine("EJERCICIO 3");
Console.WriteLine("SIMULACIÓN DE CARGA DE UNA BATERÍA (12.6 V)");
Console.WriteLine();

Console.Write("Ingrese el voltaje inicial de la batería: ");
double voltajeInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el incremento de voltaje por ciclo: ");
double incremento = Convert.ToDouble(Console.ReadLine());

if (incremento <= 0)
{
    // Validación: no se ejecuta la simulación si el incremento no es válido
    Console.WriteLine("Error: el incremento debe ser mayor que 0. No se ejecutará la simulación.");
}
else
{
    double voltaje = voltajeInicial;
    int ciclo = 0;

    while (voltaje < 12.6) // Se repite hasta alcanzar el voltaje de carga completa
    {
        ciclo = ciclo + 1;
        voltaje = voltaje + incremento;
        Console.WriteLine($"Ciclo {ciclo}: voltaje actual = {voltaje:F2} V");
    }

    Console.WriteLine();
    Console.WriteLine("La batería alcanzó el voltaje de carga completa (12.6 V).");
}