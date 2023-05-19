namespace Teryt.WebApi.BLL.Interfaces
{
    public interface IUlicService
    {
        Task<IEnumerable<ULIC>> GetUlics();
    }
}
