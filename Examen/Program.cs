using Examen;
try
{
    
    Console.WriteLine();

    Console.WriteLine("Ingrese nota del primer parcial: ");
    int N1 = Convert.ToInt32(Console.ReadLine());
    if (N1 > 30)
        throw new ArgumentException("La nota del primer y segundo parcial sobrepasa del 30%");

    Console.WriteLine("Ingrese nota del segundo parcial: ");
    double N2 = Convert.ToInt32(Console.ReadLine());
    if (N2 > 30)
        throw new ArgumentException("La nota del primer y segundo parcial sobrepasa del 30%");

    Console.WriteLine("Ingrese nota del tercer parcial: ");
    double N3 = Convert.ToInt32(Console.ReadLine());
    if (N3 > 30)
        throw new ArgumentException("La nota del tercer parcial sobrepasa del 40%");

    Asignatura asignatura = new Asignatura(N1, (int)N2, (int)N3);
    asignatura.imprimir();

}
catch (FormatException e)
{
    Console.WriteLine("Error: Porfavor, ingrese un número.");
}
