using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fonq.Control.Data
{
    public static class UnderscoreNamingStrategy
    {
        private const string regexString = @"([A-Z][\w^[A-Z]]*)([A-Z][\w^[A-Z]]*)([A-Z][\w^[A-Z]]*)*";

        public static string FromProperty(string propertyName)
        {
            return Regex.Replace(
                Regex.Replace(
                    Regex.Replace(propertyName, @"([A-Z]+)([A-Z][a-z])", "$1_$2"), @"([a-z\d])([A-Z])",
                    "$1_$2"), @"[-\s]", "_").ToLower();

            //return Regex.Replace(propertyName, regexString, (m => (m.Index != 0 ? "_" : "") + m.Value.ToLower()));
        }
    }
}
