// Contar cuántos dígitos tiene un número.
Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());

int contador = 0;

 while (num != 0)
{
    num = num / 10;
    contador++;
}

Console.WriteLine("La cantidad de digitos: "+contador);
