namespace Valoriza.Core.Services.Security
{
    public interface ICryptographyService
    {
        public string GenerateEncryption(string code);
    }
}