using Microsoft.EntityFrameworkCore;

namespace Teryt.WebApi.Models
{
    [Keyless]
    public class SIMC
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public int GminaId { get; set; }
        public int RodzGminaId { get; set; }
        public int RmNumer { get; set; }
        public int MzNumer { get; set; }
        public string Nazwa { get; set; }
        public int SymNumer { get; set; }
        public int SymPod { get; set; }
        public DateTime StanNa { get; set; }

    }
}
