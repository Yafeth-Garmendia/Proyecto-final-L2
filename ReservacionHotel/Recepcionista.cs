public  class Recepcionista : Persona
{
    public  string  CodigoRecepcionista { get ; set; }

    public  Recepcionista ( int  codigo , string  nombre , string  CodigoRecepcionista )
    {
        codigo  =  codigo ;
        Nombre  =  nombre ;
        CodigoRecepcionista  =  CodigoRecepcionista ;
    }
}