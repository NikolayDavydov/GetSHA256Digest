using System.Security.Cryptography;
using System.Text;

namespace OrderDigest
{
    public static class OrderDigest
    {
        public static string ComputeHash(string value)
        {
            var newVal = Encoding.ASCII.GetBytes(value);
            SHA256Managed sha256m = new SHA256Managed();
            return Encoding.ASCII.GetString(sha256m.ComputeHash(newVal));
        }
    }
}
