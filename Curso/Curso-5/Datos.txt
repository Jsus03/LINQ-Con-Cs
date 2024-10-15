namespace LINQ_Con_Cs;

public class Datos
{
    public static IEnumerable<string> Names()
    {
        yield return "Francisco";
        yield return "Misael";
        yield return "Jesus";
        yield return "Pedro";
        yield return "Pablo";
        yield return "Javier";
    }

    public static IEnumerable<string> LastNames()
    {
        yield return "Calderon";
        yield return "Hernandez";
        yield return "Fernandez";
        yield return "Lopez";
        yield return "Cazerez";
    }

    public static List<Producto> GetProductos()
    {
        List<Producto> Productos = new List<Producto>()
        {
            new Producto {Id = 1, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 25.0m, FechaDeAlta = DateTime.Now, IdCategoria = 1},
            new Producto {Id = 2, Nombre = "Cafe", Descripcion = "Cafe expreso", Precio = 250.0m, FechaDeAlta = DateTime.Now.AddDays(1), IdCategoria = 3},
            new Producto {Id = 3, Nombre = "Coca cola", Descripcion = "Coca de 600ml", Precio = 125.0m, FechaDeAlta = DateTime.Now, IdCategoria = 4},
            new Producto {Id = 4, Nombre = "Azucar", Descripcion = "Azcuar blanca", Precio = 35.0m, FechaDeAlta = DateTime.Now, IdCategoria = 2},
            new Producto {Id = 5, Nombre = "Frijol", Descripcion = "Frijol", Precio = 25.0m, FechaDeAlta = DateTime.Now.AddDays(2), IdCategoria = 5},
            new Producto {Id = 6, Nombre = "Servilletas", Descripcion = "Servilletas", Precio = 27.0m, FechaDeAlta = DateTime.Now, IdCategoria = 2},
            new Producto {Id = 7, Nombre = "Cafe en grano", Descripcion = "Cafe en grano tostado medio", Precio = 25.0m, FechaDeAlta = DateTime.Now.AddDays(4), IdCategoria = 5},
            new Producto {Id = 8, Nombre = "Estufa", Descripcion = "Estufa marca mabe", Precio = 25000.0m, FechaDeAlta = DateTime.Now, IdCategoria = 4},
            new Producto {Id = 9, Nombre = "Refrigerador", Descripcion = "Refrigerador", Precio = 3425.0m, FechaDeAlta = DateTime.Now.AddDays(1), IdCategoria = 1},
            new Producto {Id = 10, Nombre = "Papel higienico", Descripcion = "Papel higienico", Precio = 55.0m, FechaDeAlta = DateTime.Now.AddDays(3), IdCategoria = 3},
            new Producto {Id = 11, Nombre = "Leche", Descripcion = "Leche Entera", Precio = 45.0m, FechaDeAlta = DateTime.Now, IdCategoria = 0}
        };
        return Productos;
    }

    public static List<Departamento> GetDepartamentos()
    {
        List<Departamento> Departamentos = new List<Departamento>
        {
            new Departamento {Id = 1, Nombre = "Recursos humanos"},
            new Departamento {Id = 2, Nombre = "Finanzas"},
            new Departamento {Id = 3, Nombre = "Operaciones"},
            new Departamento {Id = 4, Nombre = "Contabilidad"},
            new Departamento {Id = 5, Nombre = "Sistemas"}
        }; 
        return Departamentos;
    }

    public static List<Direccion> GetDireccions()
    {
        List<Direccion> Direcciones = new List<Direccion>()
        {
            new Direccion {Id = 1, Descripcion = "Direccion 1"},
            new Direccion {Id = 2, Descripcion = "Direccion 2"},
            new Direccion {Id = 3, Descripcion = "Direccion 3"},
            new Direccion {Id = 4, Descripcion = "Direccion 4"},
            new Direccion {Id = 5, Descripcion = "Direccion 5"}
        };
        return Direcciones;
    }

    public static List<Categoria> GetCategorias()
    {
        List<Categoria> Categorias= new List<Categoria>
        {
            new Categoria {Id = 1, Nombre = "Categoria 1", Descripcion = "Categoria 1", },
            new Categoria {Id = 2, Nombre = "Categoria 2", Descripcion = "Categoria 2", },
            new Categoria {Id = 3, Nombre = "Categoria 3", Descripcion = "Categoria 3", },
            new Categoria {Id = 4, Nombre = "Categoria 4", Descripcion = "Categoria 4", },
            new Categoria {Id = 5, Nombre = "Categoria 5", Descripcion = "Categoria 5", },
        };
        return Categorias;
    }

    public static List<Empleado> GetEmpleados()
    {
        List<Empleado> Empleados = new List<Empleado>
        {
            new Empleado{Id = 1, Nombre = "Misael Cazarez", IdDepartamento = 1, IdDireccion = 1},
            new Empleado{Id = 2, Nombre = "Fermin Gonzalez", IdDepartamento = 3, IdDireccion = 1},
            new Empleado{Id = 3, Nombre = "Yazmin Hernandez", IdDepartamento = 1, IdDireccion = 1},
            new Empleado{Id = 4, Nombre = "Pablo Fernandez", IdDepartamento = 5, IdDireccion = 1},
            new Empleado{Id = 5, Nombre = "Roberto Lopez", IdDepartamento = 2, IdDireccion = 1},
            new Empleado{Id = 6, Nombre = "Fernando Fernandez", IdDepartamento = 4, IdDireccion = 1},
            new Empleado{Id = 7, Nombre = "Maria Castillo", IdDepartamento = 2, IdDireccion = 1},
        };
        return Empleados;
    }
}