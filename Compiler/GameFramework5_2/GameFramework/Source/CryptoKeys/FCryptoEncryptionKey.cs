#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CryptoKeysSettings.h")]
///<summary>UStruct representing a named encryption key</summary>
public partial struct FCryptoEncryptionKey {
// CryptoEncryptionKey
	public FGuid Guid;
	public string Name;
	public string Key;
}
