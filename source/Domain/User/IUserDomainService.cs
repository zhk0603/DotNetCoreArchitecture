using DotNetCoreArchitecture.Model;

namespace DotNetCoreArchitecture.Domain
{
    public interface IUserDomainService
    {
        string GenerateHash(string text);

        string GenerateToken(SignedInModel signedInModel);
    }
}
