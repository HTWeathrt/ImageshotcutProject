using Image_NYInspection_TechCuli.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Image_NYInspection_TechCuli.Connect
{
    public class ParameterConnect
    {
        private string ReadFileJson(string link)
        {
            string jsonString = System.IO.File.ReadAllText(link);
            return jsonString;
        }
        public static string BeautifyJson(string json)
        {
            JsonDocument document = JsonDocument.Parse(json);
            var stream = new MemoryStream();
            var writer = new Utf8JsonWriter(stream, new JsonWriterOptions() { Indented = true });
            document.WriteTo(writer);
            writer.Flush();
            return Encoding.UTF8.GetString(stream.ToArray());
        }
        public static ParameterData ParameterValue(string link)
        {
            string jsonString = System.IO.File.ReadAllText(link);
            ParameterData inspectiona = System.Text.Json.JsonSerializer.Deserialize<ParameterData>(jsonString);
            return inspectiona;
        }
    }
}
