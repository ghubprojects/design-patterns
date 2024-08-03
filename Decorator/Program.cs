using Decorator;

var fileDataSource = new FileDataSource("testfile.txt");

// Write plain data
fileDataSource.WriteData("Hello, world!");
Console.WriteLine("Plain: " + fileDataSource.ReadData());

// Write encrypted data
var encryptedDataSource = new EncryptionDecorator(fileDataSource);
encryptedDataSource.WriteData("Hello, world!");
Console.WriteLine("Encrypted: " + fileDataSource.ReadData());
Console.WriteLine("Decrypted: " + encryptedDataSource.ReadData());

// Write compressed data
var compressedDataSource = new CompressionDecorator(fileDataSource);
compressedDataSource.WriteData("Hello, world!");
Console.WriteLine("Compressed: " + fileDataSource.ReadData());
Console.WriteLine("Decompressed: " + compressedDataSource.ReadData());

// Write compressed and encrypted data
var compressedEncryptedDataSource = new CompressionDecorator(encryptedDataSource);
compressedEncryptedDataSource.WriteData("Hello, world!");
Console.WriteLine("Compressed & Encrypted: " + fileDataSource.ReadData());
Console.WriteLine("Decompressed & Decrypted: " + compressedEncryptedDataSource.ReadData());