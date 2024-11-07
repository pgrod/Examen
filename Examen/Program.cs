using Examen;
int N1 = 0;
int N2 = 0;
int N3 = 0;

Asignatura asignatura = new Asignatura(N1, N2, N3);

try
{ 
   
Console.WriteLine("Ingrese el nombre del alumno: ");
    asignatura.NombreAlumno = Console.ReadLine();

    Console.WriteLine("Ingrese el número de cuenta: ");
    asignatura.NumeroCuenta = Console.ReadLine();

    Console.WriteLine("Ingrese el correo electrónico: ");
    asignatura.Email = Console.ReadLine();

    Console.WriteLine("Ingrese el nombre de la clase: ");
    asignatura.NombreAsignatura = Console.ReadLine();

    Console.WriteLine("Ingrese el horario de la clase: ");
    asignatura.Horario = Console.ReadLine();

    Console.WriteLine("Ingrese el nombre del docente: ");
    asignatura.NombreDocente = Console.ReadLine();

    Console.WriteLine("Ingrese nota del primer parcial: ");
    asignatura.N1 = int.Parse(Console.ReadLine());
    if (asignatura.N1 > 30)
        throw new ArgumentException("La nota del primer y segundo parcial sobrepasa del 30%");

    Console.WriteLine("Ingrese nota del segundo parcial: ");
    asignatura.N2 = int.Parse(Console.ReadLine());
    if (asignatura.N2 > 30)
        throw new ArgumentException("La nota del primer y segundo parcial sobrepasa del 30%");

    Console.WriteLine("Ingrese nota del tercer parcial: ");
    asignatura.N3 = int.Parse(Console.ReadLine());
    if (asignatura.N3 > 40)
        throw new ArgumentException("La nota del tercer parcial sobrepasa del 40%");

    asignatura.imprimir();

}
catch (FormatException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
