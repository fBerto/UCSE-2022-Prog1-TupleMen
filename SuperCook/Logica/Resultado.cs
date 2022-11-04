namespace Logica
{
    public class Resultado
    {
        public bool Ok { get; set; }
        public string Mensaje { get; set; }

        public Resultado() { }

        public Resultado(bool ok, string mensaje)
        {
            this.Ok = ok;
            this.Mensaje = mensaje;
        }
    }
}
