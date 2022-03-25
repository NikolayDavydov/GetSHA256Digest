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
            var res = sha256m.ComputeHash(newVal);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in res) { stringBuilder.AppendFormat("{0:X2}", b); }
            return stringBuilder.ToString();
        }
    }
}
