namespace LINQ_Con_Cs;

public static class FuncionesLinq
{
    public static void UnionQuerySyntax()
    {
        var personasApellido = (from p in Datos.LastNames()
                                select p).Union(Datos.Names());
        
        foreach (var person in personasApellido)
        {
            System.Console.WriteLine($"{person}");
        }
    }

    public static void UnionEjemplo()
    {
        int[]? numeros1 = {1,2,3,4,5,6,7,8,9,10,15};
        string[] numeros2 = {"1","2","8","11","12","13","20","25"};

        var numeros = (from n in numeros1
                        select n)
                        .Union(numeros2.Select(n1 => Convert.ToInt32(n1)));

        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }

    public static void InnerJoinQuerySyntax()
    {
        var productos = from Producto in Datos.GetProductos()
                            join Categoria in Datos.GetCategorias()
                            on Producto.IdCategoria equals Categoria.Id
                            where Categoria.Id > 3
                            select new {
                                Id = Producto.Id, 
                                Nombre = Producto.Nombre,
                                Nombre_categoria = Categoria.Nombre
                            };
        
        foreach (var producto in productos)
        {
            System.Console.WriteLine($"{producto.Id} {producto.Nombre} {producto.Nombre_categoria}");
        }
    }

    public static void InnerJoinSyntaxMethod()
    {
        var productos = Datos.GetProductos().Join(
                            Datos.GetCategorias(),
                            Producto => Producto.IdCategoria,
                            Categoria => Categoria.Id,
                            (Producto, Categoria) => 
                            new { 
                                Id = Producto.Id, 
                                Nombre = Producto.Nombre, 
                                Nombre_categoria = Categoria.Nombre
                            }
        );

        foreach (var producto in productos)
        {
            System.Console.WriteLine($"{producto.Id} {producto.Nombre} {producto.Nombre_categoria}");
        }
    }
}