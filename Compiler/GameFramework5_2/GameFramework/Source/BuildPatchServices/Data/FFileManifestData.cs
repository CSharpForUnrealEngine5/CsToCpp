#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ManifestUObject.h")]
public partial struct FFileManifestData {
// FileManifestData
	public string Filename;
	public FSHAHashData FileHash;
	public TArray<FChunkPartData> FileChunkParts;
	public TArray<string> InstallTags;
	public bool bIsUnixExecutable;
	public string SymlinkTarget;
	public bool bIsReadOnly;
	public bool bIsCompressed;
}
