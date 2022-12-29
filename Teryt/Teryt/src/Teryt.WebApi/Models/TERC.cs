using Microsoft.EntityFrameworkCore;

namespace Teryt.WebApi.Models
{
    [Keyless]
    public class TERC
    {
        public int WojewodztwoId { get; set; }
        public int? PowiatId { get; set; }
        public int? GminaId { get; set; }
        public int? RodzGminaId { get; set; }
        public string Nazwa { get; set; }
        public string NazwaTerytorialna { get; set; }
        public DateTime StanNa { get; set; }
    }
}
