namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura  { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public Asignatura(int N1, int N2, int N3)
        {
            N1 = N1;
            N2 = N2;
            N3 = N3;
        }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotafinal(double N1, double N2, double N3)
        {
            return N2 + N3 + N1;
        }


        public string MensajeNotaFinal(double NotaFinal)
        {
            if (NotaFinal >= 0 && NotaFinal <= 59)
            {
                return "Reprobado";
            }
            else if (NotaFinal >= 60 && NotaFinal <= 79)
            {
                return "Bueno";
            }
            else if(NotaFinal >= 80 && NotaFinal <= 89)
            {
                return "Muy Bueno";
            }
            else
            {
                return "Sobresaliente";
            }
        }

        public void imprimir()
        {
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Número de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electrónico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota final: {CalcularNotaFinal} - {MensajeNotaFinal}");
            Console.WriteLine($"Nota final: {CalcularNotafinal} - {MensajeNotaFinal}");
        }
    }
}
