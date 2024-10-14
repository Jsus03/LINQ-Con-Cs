static IEnumerable<string> Personas()
{
    yield return "Francisco";
    yield return "Misael";
    yield return "Jesus";
    yield return "Pedro";
    yield return "Pablo";
    yield return "Javier";
}

static IEnumerable<string> Apellidos()
{
    yield return "Calderon";
    yield return "Hernandez";
    yield return "Fernandez";
    yield return "Lopez";
    yield return "Cazerez";
}

List<Producto> productos = new List<Producto>()
{
    new Producto() 
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now}
}

System.Console.WriteLine("Query Syntax");
var personas1 = (from p in Personas()
                from a in Apellidos()
                select new {
                    Nombre = p, 
                    Apellido = a
                });

foreach (var persona in personas1)
{
    System.Console.WriteLine($"Nombre: {persona.Nombre} Apellido: {persona.Apellido}");
} 

System.Console.WriteLine("\nSyntax Method");
var personas = Personas().SelectMany(persona => Apellidos()
                    .Select(apellido => new {
                    Nombre = persona,
                    Apellido = apellido})
                );

foreach (var persona in personas)
{
    System.Console.WriteLine($"Nombre:{persona.Nombre} Apellido:{persona.Apellido}");
}
