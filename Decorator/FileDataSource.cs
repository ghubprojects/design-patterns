namespace Decorator;

public class FileDataSource(string filename) : IDataHandler {
    private readonly string _filename = filename;

    public void WriteData(string data) {
        File.WriteAllText(_filename, data);
    }

    public string ReadData() {
        return File.ReadAllText(_filename);
    }
}