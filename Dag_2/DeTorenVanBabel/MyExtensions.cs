using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTorenVanBabel
{
    static class MyExtensions
    {
        public static string SponsoredBy(this string orig, string merk)
        {
            return $"{orig} is sponsored by {merk}";
        }
    }
}
