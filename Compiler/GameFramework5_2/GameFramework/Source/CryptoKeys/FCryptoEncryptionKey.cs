#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UStruct representing a named encryption key</summary>
[CppInclude("CryptoKeysSettings.h")]
public partial struct FCryptoEncryptionKey {
	public FGuid Guid;
	public string Name;
	public string Key;
}
