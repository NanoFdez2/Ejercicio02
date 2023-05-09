int Primernumero;
int Segundonumero;
int suma;
int resta;
int divicion;
int multiplicacion;

Console.WriteLine("Ingrese el primer numero");
Primernumero=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
Segundonumero=int.Parse(Console.ReadLine());
suma = Primernumero + Segundonumero;
Console.WriteLine($"El resultado de la suma es {suma}");
resta=Primernumero - Segundonumero;
Console.WriteLine($"El resultado de la resta es {resta}");
multiplicacion = Primernumero * Segundonumero;
Console.WriteLine($"El resultado de la multipliacion es {multiplicacion}");
divicion = Primernumero / Segundonumero;
Console.WriteLine($"El resultado de la divicion es {divicion}");
Console.ReadLine();


