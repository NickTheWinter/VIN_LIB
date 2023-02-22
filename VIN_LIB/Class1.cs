using System.Text.RegularExpressions;

namespace VIN_LIB
{
    public class Class1
    {
        static Regex vinReg = new Regex(@"^([a-z1-9-[oiq]]{3})([a-z0-9-[oiq]]{5})([0-9x]{1})([a-y1-9-[oiqu]]{1})([a-z0-9-[oiq]]{7})$",RegexOptions.IgnoreCase);
        static Dictionary<Regex, String> regions = new Dictionary<Regex, string>
        {
            {new Regex(@"[a-h]"),"Африка"},
            {new Regex(@"[j-r]"), "Азия"},
            {new Regex(@"[s-z]"), "Европа"},
            {new Regex(@"[1-5]"), "Северная Америка"},
            {new Regex(@"[6-7]"), "Океания"},
            {new Regex(@"[8-9]"), "Южная Америка"}
        };
        static Dictionary<char, int> charToInt = new Dictionary<char, int>
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
        static int[] weight = { 8, 7, 6, 5, 4, 3, 2, 10, 0, 9, 8, 7, 6, 5, 4, 3, 2 };
        public static Boolean CheckVIN(String vin)
        {
            if (vinReg.Match(vin).Success)
            {
                vin = vin.ToLower();
                char[] vinArray = vin.ToCharArray();
                double contrSum = 0;
                for (int i = 0; i < vinArray.Length; i++)
                {
                    if (new Regex(@"[a-z]").Match(vinArray[i].ToString()).Success)
                    {
                        foreach (var item in charToInt)
                        {
                            if (item.Key == vinArray[i])
                                vinArray[i] = char.Parse(item.Value.ToString());

                        }
                    }
                    contrSum += int.Parse(vinArray[i].ToString()) * weight[i];
                }
                double sum = contrSum;
                contrSum = Math.Floor(contrSum / 11);
                contrSum = contrSum * 11;
                contrSum = sum - contrSum;
                if (contrSum == int.Parse(vinArray[8].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static String GetVINCountry(String vin)
        {
            vin = vin.ToLower();
            foreach (var region in regions)
            {
                if (region.Key.Match(vin[0].ToString()).Success)
                    return region.Value;
            }
            return "";
        }
    }
}