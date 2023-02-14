namespace Teryt.WebApi.DTO.Response
{
    public class TERCDto
    {
        public string Nazwa { get; set; }
        public string NazwaTerytorialna { get; set; }
        public int? PowiatId { get; set; }
        public int? GminaId { get; set; }
        public int WojewodztwoId { get; set; }
        public DateTime StanNa { get; set; }
    }
}
