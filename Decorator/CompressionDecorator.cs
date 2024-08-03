namespace Decorator;

public class CompressionDecorator(IDataHandler source) : DataSourceDecorator(source)
{
    public override void WriteData(string data)
    {
        var compressedData = FileHelper.Compress(data);
        base.WriteData(compressedData);
    }

    public override string ReadData()
    {
        var data = base.ReadData();
        return FileHelper.Decompress(data);
    }
}