public class Quadrado
{   
    public double Lado { get; set; }
    public double Area { get => Lado * Lado; }
    public double Perimetro { get => Lado * 4; }
    public Quadrado(double lado) => Lado = lado;
}