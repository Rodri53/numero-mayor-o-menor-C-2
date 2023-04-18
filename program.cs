Console.WriteLine("Introduzca un número");
String primerNumero;
primerNumero = Console.ReadLine();
Console.WriteLine("Introduzca otro número");
string segundoNumero;
segundoNumero = Console.ReadLine();
int primerNumeroEntero = Int32.Parse(primerNumero);
int segundoNumeroEntero = Int32.Parse(segundoNumero);
if (primerNumeroEntero > segundoNumeroEntero)
{
    Console.WriteLine(primerNumero + " es mayor que " + segundoNumero);
}
else if (primerNumeroEntero < segundoNumeroEntero)
{
    Console.WriteLine(primerNumero + " es menor que " + segundoNumero);
}
else
{
    Console.WriteLine(primerNumero + " es igual que " + segundoNumero);
}

if (segundoNumeroEntero % 2 == 0)
{
    Console.WriteLine("El número " + segundoNumero + " es un número par");
}
else
{
    Console.WriteLine("El número " + segundoNumero + " es un número impar");
}