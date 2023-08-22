using Image_NYInspection_TechCuli.Data;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Image_NYInspection_TechCuli.Connect
{
    public class LineConnect
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
        public static LineRootData LineValue(string link)
        {
            string jsonString = System.IO.File.ReadAllText(link);
            LineRootData inspectiona = System.Text.Json.JsonSerializer.Deserialize<LineRootData>(jsonString);
            return inspectiona;
        }
        
        #region 
        /*        public JsonArray connectLine()
                {
                    string link = "";
                    Line line = jsonValue(link);
                    string jsonvalue1 = ReadFileJson(link);
                    JsonNode forecastNode = JsonNode.Parse(jsonvalue1);
                    JsonArray studentsArray = forecastNode.AsArray();
                    return studentsArray;
                }*/
        #endregion
    }
}
