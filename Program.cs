Quadrado q1 = new Quadrado(12.0);
Quadrado q2 = new Quadrado (10.5);
Retangulo r1 = new Retangulo(12.0, 8.0);
Retangulo r2 = new Retangulo(15.0, 6.0);

Console.WriteLine("\tQuadrado 1\n");
Console.WriteLine(q1.Lado);
Console.WriteLine(q1.Area);
Console.WriteLine(q1.Perimetro);

q1.Lado = 6.5;
Console.WriteLine("\tQuadrado 1\n");
Console.WriteLine(q1.Lado);
Console.WriteLine(q1.Area);
Console.WriteLine(q1.Perimetro);


Console.WriteLine("\tQuadrado 2\n");
Console.WriteLine(q2.Lado);
Console.WriteLine(q2.Area);
Console.WriteLine(q2.Perimetro);

q2.Lado = 8.4;

Console.WriteLine("\tQuadrado 2\n");
Console.WriteLine(q2.Lado);
Console.WriteLine(q2.Area);
Console.WriteLine(q2.Perimetro);


Console.WriteLine("\tRetângulo 1\n");
Console.WriteLine(r1.Base);
Console.WriteLine(r1.Altura);
Console.WriteLine(r1.Area);
Console.WriteLine(r1.Perimetro);

r1.Base = 6.5;
Console.WriteLine("\tRetângulo 1\n");
Console.WriteLine(r1.Base);
Console.WriteLine(r1.Altura);
Console.WriteLine(r1.Area);
Console.WriteLine(r1.Perimetro);


Console.WriteLine("\tRetângulo 2\n");
Console.WriteLine(r2.Base);
Console.WriteLine(r2.Altura);
Console.WriteLine(r2.Area);
Console.WriteLine(r2.Perimetro);

r2.Base = 8.4;

Console.WriteLine("\tRetângulo 2\n");
Console.WriteLine(r2.Base);
Console.WriteLine(r2.Altura);
Console.WriteLine(r2.Area);
Console.WriteLine(r2.Perimetro);