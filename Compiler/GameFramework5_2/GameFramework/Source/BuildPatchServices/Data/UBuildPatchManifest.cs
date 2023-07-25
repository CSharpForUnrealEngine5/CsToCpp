#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ManifestUObject.h")]
public partial class UBuildPatchManifest : UObject {
// BuildPatchManifest
	public byte ManifestFileVersion;
	public bool bIsFileData;
	public uint AppID;
	public string AppName;
	public string BuildVersion;
	public string LaunchExe;
	public string LaunchCommand;
	public TSet<string> PrereqIds;
	public string PrereqName;
	public string PrereqPath;
	public string PrereqArgs;
	public TArray<FFileManifestData> FileManifestList;
	public TArray<FChunkInfoData> ChunkList;
	public TArray<FCustomFieldData> CustomFields;
}
