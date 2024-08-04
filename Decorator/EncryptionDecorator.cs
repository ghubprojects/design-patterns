namespace Decorator;

public class EncryptionDecorator(IFileDataSource source) : DataSourceDecorator(source) {
    public override void WriteData(string data) {
        var encryptedData = FileHelper.Encrypt(data);
        base.WriteData(encryptedData);
    }

    public override string ReadData() {
        var data = base.ReadData();
        return FileHelper.Decrypt(data);
    }
}