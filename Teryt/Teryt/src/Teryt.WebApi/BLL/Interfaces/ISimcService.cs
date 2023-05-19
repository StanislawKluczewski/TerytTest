namespace Teryt.WebApi.BLL.Interfaces
{
    public interface ISimcService
    {
        Task<IEnumerable<SIMC>> GetSimcs();
    }
}
