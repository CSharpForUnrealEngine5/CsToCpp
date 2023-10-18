namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UStruct representing a named encryption key</summary>
[CppInclude("CryptoKeysSettings.h")]
public partial struct FCryptoEncryptionKey {
	public FGuid Guid;
	public string Name;
	public string Key;
}
