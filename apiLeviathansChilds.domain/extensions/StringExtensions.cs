using System.Text;

namespace apiLeviathansChilds.domain.extensions
{
    public static class StringExtensions
    {
        public static string ConvertToMD5(this string password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            var passwordWithSecret = (password += "|auy651Ag8kuSS1fw699hrt156xc-cAF5fmPfd");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(passwordWithSecret));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }
    }
}