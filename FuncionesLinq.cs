namespace LINQ_Con_Cs;

public static class FuncionesLinq
{
    public static void UnionQuerySyntax()
    {
        var personasApellido = (from p in Datos.LastNames()
                                select p).Union(Datos.Names());
        
        foreach (var person in personasApellido)
        {
            Console.WriteLine($"{person}");
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
            Console.WriteLine($"{producto.Id} {producto.Nombre} {producto.Nombre_categoria}");
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
            Console.WriteLine($"{producto.Id} {producto.Nombre} {producto.Nombre_categoria}");
        }
    }

    public static void InnerJoinMultipleQuerySyntax()
    {
        var empleados = from Empleado in Datos.GetEmpleados()
                            join Departamento in Datos.GetDepartamentos()
                            on Empleado.IdDepartamento equals Departamento.Id
                            join Direccion in Datos.GetDireccions()
                            on Empleado.IdDireccion equals Direccion.Id
                            select new {
                                Id = Empleado.Id,
                                Nombre = Empleado.Nombre,
                                Nombre_departamento = Departamento.Nombre,
                                Nombre_direccion = Direccion.Descripcion
                            };
        
        foreach (var empleado in empleados)
        {
            Console.WriteLine($"{empleado.Id} {empleado.Nombre} {empleado.Nombre_departamento} {empleado.Nombre_direccion}");
        }
    }

    public static void InnerJoinMultipleSyntaxMethod()
    {
        var empleados = Datos.GetEmpleados()
                        .Join(
                            Datos.GetDepartamentos(),
                            Empleado1 => Empleado1.IdDepartamento,
                            Departamento => Departamento.Id,
                            (Empleado1, Departamento) => new {
                                Empleado1, Departamento
                            }
                        ).Join(
                            Datos.GetDireccions(),
                            Empleado2 => Empleado2.Empleado1.IdDireccion,
                            Direccion => Direccion.Id,
                            (Empleado2, Direccion) => new {
                                Empleado2, Direccion
                            }
                        ).Select(Empleado3 => new {
                                Id = Empleado3.Empleado2.Empleado1.Id,
                                Nombre = Empleado3.Empleado2.Empleado1.Nombre,
                                Nombre_Departamento = Empleado3.Empleado2.Departamento.Nombre,
                                Nombre_Direccion = Empleado3.Direccion.Descripcion
                            }
                        );

        foreach (var empleado in empleados)
        {
            Console.WriteLine($"{empleado.Id} {empleado.Nombre} {empleado.Nombre_Departamento} {empleado.Nombre_Direccion}");
        }
    }

    public static void GroupBySyntaxMethod()
    {
        var productoCategoria = Datos.GetProductos().GroupBy(p => p.IdCategoria);

        foreach (var groupProductos in productoCategoria)
        {
            Console.WriteLine($"Categoria: {groupProductos.Key}");

            foreach (var producto in groupProductos)
            {
                Console.WriteLine($"Id: {producto.Id} Nombre: {producto.Nombre} Precio {producto.Precio}");
            }
        }
    }   

    public static void GroupByMultipleKeySyntaxMethod()
    {
        var empleadosDepartamentoDireccion = Datos.GetEmpleados()
                            .GroupBy(e => new{ e.IdDepartamento, e.IdDireccion })
                            .OrderByDescending( g => g.Key.IdDepartamento )
                            .ThenBy( g => g.Key.IdDireccion )
                            .Select( g => g);
        
        foreach (var groupEmpleado in empleadosDepartamentoDireccion)
        {
            Console.WriteLine($"Departamento: {groupEmpleado.Key.IdDepartamento} Direccion: {groupEmpleado.Key.IdDireccion}");

            foreach (var empleado in groupEmpleado.Select(e => e))
            {
                Console.WriteLine($"Id: {empleado.Id} Nombre: {empleado.Nombre}");
            }
        }
    }

    public static void OrderByAscendingSyntaxMethod()
    {
        var productos = Datos.GetProductos().OrderBy(p => p.Precio);

        foreach (var producto in productos)
        {
            Console.WriteLine($"Id: {producto.Id} Nombre: {producto.Nombre} Precio: {producto.Precio}");
        }
    }

    public static void OrderByDescendingSyntaxMethod()
    {
        var empleados = Datos.GetEmpleados().OrderByDescending(p => p.IdDepartamento);

        foreach (var empleado in empleados)
        {
            Console.WriteLine($"Id: {empleado.Id} Nombre: {empleado.Nombre}");
        }
    }

    public static void SumSyntaxMethod()
    {
        var total = Datos.GetProductos().Where(p => p.Id < 3).
                        Sum(p => p.Precio);

        Console.WriteLine($"El total de los productos es: {total}");
    }

    public static void MaxSyntaxMethod()
    {
        var max = Datos.GetProductos().Where(p => p.Precio < 270).Max(p => p.Precio);

        var maxCategoria = Datos.GetCategorias().Max(c => c.Id);

        Console.WriteLine($"El precio mas alto por debajo de 270: {max}");
    }

    public static void MinSyntaxMethod()
    {
        int[] enteros = new int[]{1,22,85,74,45,215,875,52,4,-9,-485,1};
        var min_enteros = enteros.Min();
        Console.WriteLine(min_enteros);
        
        var min = Datos.GetProductos().Where(p => p.Precio > 27).Min(p => p.Precio);
    }

    public static void MaxBySyntaxMethod()
    {
        var max = Datos.GetProductos().Where(p => p.Precio < 270).MaxBy(p => p.Precio);

        Console.WriteLine($"Nombre: {max.Nombre} Descripcion: {max.Descripcion} IdCategoria: {max.IdCategoria} Precio: {max.Precio}");
    }

    public static void MinBySyntaxMethod()
    {
        var min = Datos.GetProductos().MinBy(p => p.Precio);

        Console.WriteLine($"Nombre: {min.Nombre} Descripcion: {min.Descripcion} IdCategoria: {min.IdCategoria} Precio: {min.Precio}");
    }

    public static void AverageSyntaxMethod()
    {
        int[] enteros = [1,2,3,4,5,6,7,8,9,10];
        var average = enteros.Average();

        var average2 = Datos.GetProductos().Average(p => p.Precio);

        Console.WriteLine(average2);
    }

    public static void CountSyntaxMethod()
    {
        int[] enteros = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15];
        var count = enteros.Count(e => e % 3 != 0);

        var count2 = Datos.GetProductos().Count(p => p.Precio > 50);

        Console.WriteLine(count);
    }

    public static void AllSyntaxMethod()
    {
        int[] enteros = [55,6,7,8,9,10,11,12,13,14,15];
        var all = enteros.All(x => x > 5);

        var all2 = Datos.GetProductos().All(p => p.IdCategoria == 0);

        Console.WriteLine($"Todos los elementos tienen una categoria asignada?: {all}");
    }

    public static void AnySyntaxMethod()
    {
       int[] enteros = [55,6,7,8,9,10,11,12,13,14,15];
       var any = enteros.Any(x => x == 1);
       var any2 = Datos.GetProductos().Any(p => p.Nombre.Contains("Cafe"));

       Console.WriteLine($"El arreglo tiene al menos un producto cafe? {any2}"); 
    }
}