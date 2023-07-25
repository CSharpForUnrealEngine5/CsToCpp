#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ManifestUObject.h")]
public partial struct FChunkInfoData {
// ChunkInfoData
	public FGuid Guid;
	public ulong Hash;
	public FSHAHashData ShaHash;
	public long FileSize;
	public byte GroupNumber;
}
