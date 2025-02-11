using Newtonsoft.Json;

internal class Utilities
{
    internal static List<Video> ReadData(string fileId)
    {
        var fileName = "Data/Bookstore" + fileId + ".json";
        var cadJSON = ReadFile(fileName);
        return JsonConvert.DeserializeObject<List<Video>>(cadJSON);
    }
    //----------------------------------------------------------
    internal static string ReadFile(string filename)
    {
        return File.ReadAllText(filename);
    }
}