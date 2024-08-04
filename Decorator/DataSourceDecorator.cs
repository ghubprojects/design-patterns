namespace Decorator;

public abstract class DataSourceDecorator(IFileDataSource source) : IFileDataSource {
    protected IFileDataSource _source = source;

    public virtual void WriteData(string data) {
        _source.WriteData(data);
    }

    public virtual string ReadData() {
        return _source.ReadData();
    }
}