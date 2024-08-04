namespace Decorator;

public interface IFileDataSource {
    void WriteData(string data);
    string ReadData();
}