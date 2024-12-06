namespace CajemesfoodProyect.Data.Models
{
    public class platillos_Local
    {
        public int Id { get; set; }
        public int platilloId { get; set; }
        public platillos platillos { get; set; }
        public int LocalId { get; set; }
        public Local Local { get; set; }
    }
}
