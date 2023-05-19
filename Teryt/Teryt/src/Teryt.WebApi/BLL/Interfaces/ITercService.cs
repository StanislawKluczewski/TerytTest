namespace Teryt.WebApi.BLL.Interfaces
{
    public interface ITercService
    {
        Task<IEnumerable<TERC>> GetTERCs();
    }
}
