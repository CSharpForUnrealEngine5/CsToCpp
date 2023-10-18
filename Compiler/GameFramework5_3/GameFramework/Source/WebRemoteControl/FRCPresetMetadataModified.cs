namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetMetadataModified {
	public string Type;
	public FName PresetName;
	public string PresetId;
	public TMap<string,string> Metadata;
}
