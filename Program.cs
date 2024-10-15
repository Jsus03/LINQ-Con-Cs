﻿using LINQ_Con_Cs;

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
    new Producto {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now},
    new Producto {Id = 2, Nombre = "Cafe", Descripcion = "Cafe expreso", Precio = 250.0m, FechaDeAlta = DateTime.Now.AddDays(1)},
    new Producto {Id = 3, Nombre = "Coca cola", Descripcion = "Coca de 600ml", Precio = 125.0m, FechaDeAlta = DateTime.Now},
    new Producto {Id = 4, Nombre = "Azucar", Descripcion = "Azcuar blanca", Precio = 35.0m, FechaDeAlta = DateTime.Now},
    new Producto {Id = 5, Nombre = "Frijol", Descripcion = "Frijol", Precio = 25.0m, FechaDeAlta = DateTime.Now.AddDays(2)},
    new Producto {Id = 6, Nombre = "Servilletas", Descripcion = "Servilletas", Precio = 27.0m, FechaDeAlta = DateTime.Now},
    new Producto {Id = 7, Nombre = "Cafe en grano", Descripcion = "Cafe en grano tostado medio", Precio = 25.0m, FechaDeAlta = DateTime.Now.AddDays(4)},
    new Producto {Id = 8, Nombre = "Estufa", Descripcion = "Estufa marca mabe", Precio = 25000.0m, FechaDeAlta = DateTime.Now},
    new Producto {Id = 9, Nombre = "Refrigerador", Descripcion = "Refrigerador", Precio = 3425.0m, FechaDeAlta = DateTime.Now.AddDays(1)},
    new Producto {Id = 10, Nombre = "Papel higienico", Descripcion = "Papel higienico", Precio = 55.0m, FechaDeAlta = DateTime.Now.AddDays(3)},
    new Producto {Id = 11, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 45.0m, FechaDeAlta = DateTime.Now}
};

System.Console.WriteLine("Query Syntax");
var productosFiltrados = from producto in productos
                where producto.Nombre.Contains("Cafe")
                select producto;

foreach (var producto in productosFiltrados)
{
    System.Console.WriteLine($"{producto.Id} {producto.Nombre} {producto.Descripcion}");
} 

System.Console.WriteLine("\nSyntax Method");
var productosFiltrados2 = productos.Where(producto => producto.Id > 4);

foreach (var producto in productosFiltrados2)
{
    System.Console.WriteLine($"{producto.Id} {producto.Nombre} {producto.Descripcion}");
} 
