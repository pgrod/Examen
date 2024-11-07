namespace Examen
{
    public interface IAsignatura
    {
        double CalcularNotaFinal();
        double CalcularNotafinal(double N1, double N2, double N3);
        string MensajeNotaFinal(double NotaFinal);
        public void imprimir();
    }
}
