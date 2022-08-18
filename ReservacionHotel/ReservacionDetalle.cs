public class ReservacionDetalle
{
    public int Codigo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public Habitacion Habitacion { get; set; }

    public ReservacionDetalle(int codigo, int cantidad, Habitacion Habitacion)
    {
        Codigo = codigo;
        Cantidad = cantidad;
        Habitacion = Habitacion;
        Precio = Habitacion.Precio;
    }
}