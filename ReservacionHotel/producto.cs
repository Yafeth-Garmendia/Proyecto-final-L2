public class Habitacion
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public int Existencia { get; set; }

    public Habitacion(string codigo, string descripcion, int existencia)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Existencia = existencia;
    }

}