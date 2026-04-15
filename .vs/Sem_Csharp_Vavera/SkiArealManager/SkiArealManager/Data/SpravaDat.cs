using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using SkiArealManager.Modely;
using System.IO;

namespace SkiArealManager.Data
{
    public class SpravaDat
    {
        private string soubor = "sjezdovky.json";

        public void Uloz(List<Sjezdovka> sjezdovky)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() },
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string json = JsonSerializer.Serialize(sjezdovky, options);
            File.WriteAllText(soubor, json);
        }

        public List<Sjezdovka> Nacti()
        {
            if (!File.Exists(soubor))
            {
                return new List<Sjezdovka>();
            }

            var options = new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter() }
            };

            string json = File.ReadAllText(soubor);
            return JsonSerializer.Deserialize<List<Sjezdovka>>(json, options);

        }
    }
}
