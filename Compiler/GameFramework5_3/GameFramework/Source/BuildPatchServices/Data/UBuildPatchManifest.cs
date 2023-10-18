namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ManifestUObject.h")]
public partial class UBuildPatchManifest : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ManifestFileVersion</summary>
	public byte ManifestFileVersion;
	///<summary>bIsFileData</summary>
	public bool bIsFileData;
	///<summary>AppID</summary>
	public uint AppID;
	///<summary>AppName</summary>
	public string AppName;
	///<summary>BuildVersion</summary>
	public string BuildVersion;
	///<summary>LaunchExe</summary>
	public string LaunchExe;
	///<summary>LaunchCommand</summary>
	public string LaunchCommand;
	///<summary>PrereqIds</summary>
	public TSet<string> PrereqIds;
	///<summary>PrereqName</summary>
	public string PrereqName;
	///<summary>PrereqPath</summary>
	public string PrereqPath;
	///<summary>PrereqArgs</summary>
	public string PrereqArgs;
	///<summary>FileManifestList</summary>
	public TArray<FFileManifestData> FileManifestList;
	///<summary>ChunkList</summary>
	public TArray<FChunkInfoData> ChunkList;
	///<summary>CustomFields</summary>
	public TArray<FCustomFieldData> CustomFields;
}
