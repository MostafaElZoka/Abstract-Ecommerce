
namespace Business.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string userName, string email);
    }
}
