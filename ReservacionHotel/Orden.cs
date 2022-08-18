using System;
using System.Collections.Generic;

public class Recepcionista
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeRecepcion { get; set; }
    public Cliente Cliente { get; set; }
    public Recepcion Recepcionista { get; set; }
    public List<ReservacionDetalle> ListaReservacionDetalle { get; set; }
    public double SubTotal { get; set; }
    public double Impuesto { get; set; }
    public double Total { get; set; }

    public Recepcionista(int codigo, DateTime fecha, string numeroOrden, Cliente cliente, Recepcionista Recepcionista)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrden = NumerodeRecepcion;
        Cliente = cliente;
        Recepcionista = Recepcionista;
        ListaReservacionDetalle = new List<ReservacionDetalle>();
    }

    public void AgregarHabitacion(Habitacion Habitacion)
    {
        int nuevoCodigo = ListaReservacionDetalle.Count + 1;
        int cantidad = 1;

        ReservacionDetalle o = new ReservacionDetalle(nuevoCodigo, 1, Habitacion);
        ListaReservacionDetalle.Add(o);

        SubTotal += cantidad * Habitacion.Precio;
        Impuesto += SubTotal * 0.15;
        Total += SubTotal + Impuesto;
    }
}