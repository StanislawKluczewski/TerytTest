using System;

namespace Teryt.WebApi.DTO.Response
{
    public class SIMCDto
    {
        public string Nazwa { get; set; }
        public int WojewodztwoId { get; set; }
        public int RodzGminaId { get; set; }
        public int GminaId { get; set; }
        public int PowiatId { get; set; }
        public int RmNumer { get; set; }
        public DateTime StanNa { get; set; }
    }
}
