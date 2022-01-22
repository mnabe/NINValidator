using System.Text.RegularExpressions;

namespace NINValidator
{
    public class NINValidator
    {
        public bool ValidateDanishNIN(string NIN)
        {
            Regex rgx = new Regex(@"[0-3][0-9][0-1][1-9]\d{2}-\d{4}?[^0-9]*");
            bool validSSN = rgx.IsMatch(NIN);
            return validSSN;
        }
        public bool ValidateNorwegianNIN(string NIN)
        {
            Regex rgx = new Regex(@"^(((20)((0[0-9])|(1[0-1])))|(([1][^0-8])?\d{2}))((0[1-9])|1[0-2])((0[1-9])|(2[0-9])|(3[01]))[-]?\d{4}$");
            bool validSSN = rgx.IsMatch(NIN);
            return validSSN;
        }
        public bool ValidateSwedishNIN(string NIN)
        {
            Regex rgx = new Regex(@"(0[1-9]|[1-2][0-9]|31(?!(?:0[2469]|11))|30(?!02))(0[1-9]|1[0-2])\d{7}");
            bool validSSN = rgx.IsMatch(NIN);
            return validSSN;
        }
    }
}
