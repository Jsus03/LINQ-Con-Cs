namespace LINQ_Con_Cs;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public DateTime FechaDeAlta { get; set; }
    public int IdCategoria { get; set; }
}