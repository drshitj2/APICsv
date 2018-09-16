using System.Collections.Generic;
using System.IO;
using System.Web;

namespace Sample
{
    public class Start
    {
        internal protected static Dictionary<string, string> resourceList = new Dictionary<string, string>();

        internal protected static void LoadCSV()
        {
            var reader = new StreamReader(File.OpenRead(HttpContext.Current.Server.MapPath("~\\App_Data\\Sample.csv")));
            reader.ReadLine(); // to skip header
            while (!reader.EndOfStream)
            {
                var value = reader.ReadLine().Split(',');
                if (!resourceList.ContainsKey(value[0]))
                    resourceList.Add(value[0], value[1]);
            }
        }
    }
}