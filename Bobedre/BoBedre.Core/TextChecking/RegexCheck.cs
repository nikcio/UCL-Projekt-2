using System.Text.RegularExpressions;

namespace BoBedre.Core.TextChecking
{
    public static class RegexCheck
    {
        private static readonly string BasicTextRegex = @"^[a-z A-ZåæøÅÆØ]+$";
        private static readonly string EmailRegex = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$"; // Taken from: https://emailregex.com/
        private static readonly string BaisctalRegex = @"^[0-9]+$";

        public static bool TextCheck(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, BasicTextRegex);
        }

        public static bool EmailCheck(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, EmailRegex);
        }
        public static bool TalCheck(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, BaisctalRegex);
        }
    }
}
