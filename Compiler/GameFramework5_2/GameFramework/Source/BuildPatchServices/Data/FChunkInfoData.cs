namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ManifestUObject.h")]
public partial struct FChunkInfoData {
	public FGuid Guid;
	public ulong Hash;
	public FSHAHashData ShaHash;
	public long FileSize;
	public byte GroupNumber;
}
