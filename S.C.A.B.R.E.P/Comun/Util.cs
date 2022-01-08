using System;
using System.Configuration;
using System.Globalization;

namespace S.C.A.B.R.E.P.Comun
{
    public static class Util
    {
        public static double ObtenerParametroIVA() 
        {
            var parametroIVA = ConfigurationManager.AppSettings["IVA"].ToString();
            if (string.IsNullOrWhiteSpace(parametroIVA)) return 0;

            return Math.Round(Convert.ToDouble(parametroIVA.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                    .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)),2);
        }
    }
}
