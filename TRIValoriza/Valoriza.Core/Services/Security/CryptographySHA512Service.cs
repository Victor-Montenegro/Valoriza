using System.Security.Cryptography;
using System.Text;

namespace Valoriza.Core.Services.Security
{
    public class CryptographySHA512Service : ICryptographyService
    {
        public string GenerateEncryption(string code)
        {
            HashAlgorithm hash = SHA512.Create();

            var sb = new StringBuilder();
            var encodedValue = Encoding.UTF8.GetBytes(code);
            var encrytedCode = hash.ComputeHash(encodedValue);

            foreach (var caracterer in encrytedCode)
                sb.Append(caracterer.ToString("X2"));

            return sb.ToString();
        }
    }
}