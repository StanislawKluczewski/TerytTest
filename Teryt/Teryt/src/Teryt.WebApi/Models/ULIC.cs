using Microsoft.EntityFrameworkCore;

namespace Teryt.WebApi.Models
{
    [Keyless]
    public class ULIC
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public int GminaId { get; set; }
        public int RodzGminaId { get; set; }
        public int SymNumer { get; set; }
        public int SymNumerUlicy { get; set; }
        public string Cecha { get; set; }
        public string Nazwa1 { get; set; }
        public string? Nazwa2 { get; set; }
        public DateTime StanNa { get; set;}
    }
}
