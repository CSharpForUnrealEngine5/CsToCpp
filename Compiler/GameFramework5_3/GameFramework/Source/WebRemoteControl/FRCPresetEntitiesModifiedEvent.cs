namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event triggered when an exposed entity struct is modified.</summary>
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetEntitiesModifiedEvent {
	public string Type;
	public FName PresetName;
	public string PresetId;
	public FRCPresetModifiedEntitiesDescription ModifiedEntities;
}
