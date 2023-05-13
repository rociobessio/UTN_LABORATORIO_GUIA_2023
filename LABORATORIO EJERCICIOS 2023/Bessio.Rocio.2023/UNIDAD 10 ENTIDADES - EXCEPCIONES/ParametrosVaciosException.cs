namespace UNIDAD_10_ENTIDADES___EXCEPCIONES
{
    /// <summary>
    /// Las excepciones heredan de la clase
    /// Exception.
    /// </summary>
    public class ParametrosVaciosException : Exception
    {
 
        public ParametrosVaciosException(string mensajeExcepcion)
            :this(mensajeExcepcion,null)
        {

        }

        public ParametrosVaciosException(string mensajeExcepcion, Exception inner)
            : base(mensajeExcepcion,inner)
        {

        }
    }
}