﻿static IEnumerable<string> Names()
{
    yield return "Francisco";
    yield return "Misael";
    yield return "Jesus";
    yield return "Pedro";
    yield return "Pablo";
    yield return "Javier";
}

static IEnumerable<string> LastNames()
{
    yield return "Calderon";
    yield return "Hernandez";
    yield return "Fernandez";
    yield return "Lopez";
    yield return "Cazerez";
}

int[] numeros1 = {1,2,3,4,5,6,7,8,9,10,15};
int[] numeros2 = {1,2,8,11,12,13,20,25};

System.Console.WriteLine("Query Syntax");
var personasApellidos = LastNames().Union(Names());

foreach (var persona in personasApellidos)
{
    System.Console.WriteLine($"{persona}");
} 

var numeros = (from n in numeros1
                select n).Union(numeros2);

foreach (var numero in numeros)
{
    System.Console.WriteLine(numero);          
}

System.Console.WriteLine("\nSyntax Method");
var personasApellido = (from name in Names()
                        select name).Union(LastNames());

foreach (var persona in personasApellido)
{
    System.Console.WriteLine($"{persona}");
} 

var numeros0 = numeros1.Union(numeros2);;

foreach (var num in numeros0)
{
    System.Console.WriteLine(num);
}