namespace Teryt.WebApi.DTO.Response
{
    public class ULICDto
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public int GminaId { get; set; }
        public string Cecha { get; set; }
        public string Nazwa1  { get; set; }
        public string? Nazwa2  { get; set; }
        public string? NazwaSimc  { get; set; }
        public DateTime StanNa { get; set; }
    }
}
