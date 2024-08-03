namespace Decorator;

public abstract class DataSourceDecorator(IDataHandler source) : IDataHandler
{
    protected IDataHandler _source = source;

    public virtual void WriteData(string data)
    {
        _source.WriteData(data);
    }

    public virtual string ReadData()
    {
        return _source.ReadData();
    }
}