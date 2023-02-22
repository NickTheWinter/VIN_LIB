using System.Text.RegularExpressions;

namespace VIN_LIB
{
    public class Class1
    {
        Regex vinReg = new Regex(@"^([a-z1-9-[oiq]]{3})([a-z0-9-[oiq]]{5})([0-9x]{1})([a-y1-9-[oiqu]]{1})([a-z0-9-[oiq]]{7})$");
        Dictionary<Regex, string> regions = new Dictionary<Regex, string>
        {
            {new Regex(@"[a-h]"),"Африка"},
            {new Regex(@"[j-r]"), "Азия"},
            {new Regex(@"[s-z]"), "Европа"},
            {new Regex(@"[1-5]"), "Северная Америка"},
            {new Regex(@"[6-7]"), "Океания"},
            {new Regex(@"[8-9]"), "Южная Америка"}
        };
        Dictionary<char, int> charToInt = new Dictionary<char, int>
        {
            {'a',1},
            {'b',2},
            {'c',3},
            {'d',4},
            {'e',5},
            {'f',6},
            {'g',7},
            {'h',8},
            {'j',1},
            {'k',2},
            {'l',3},
            {'m',4},
            {'n',5},
            {'p',7},
            {'r',9},
            {'s',2},
            {'t',3},
            {'u',4},
            {'v',5},
            {'w',6},
            {'x',7},
            {'y',8},
            {'z',9}
        };
        Boolean CheckVIN(String vin)
        {
            return true;
        }
        public static String GetVINCountry(String vin)
        {
            return "";
        }
    }
}