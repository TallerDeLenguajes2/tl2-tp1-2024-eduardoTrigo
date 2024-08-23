namespace EspacioCliente
{
    public class Clientes
    {
        private string nombre;
        private string direccion;
        private int telefono;
        private string detalle;
        public Clientes(string nombre, string direccion, int telefono, string detalle)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.detalle = detalle;
        }

        public global::System.String Nombre { get => nombre; }
        public global::System.String Direccion { get => direccion; }
        public global::System.Int32 Telefono { get => telefono; }
        public global::System.String Detalle { get => detalle; }
    }
}