#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
///<summary>Event triggered when an exposed entity struct is modified.</summary>
public partial struct FRCPresetEntitiesModifiedEvent {
// RCPresetEntitiesModifiedEvent
	public string Type;
	public string PresetName;
	public string PresetId;
	public FRCPresetModifiedEntitiesDescription ModifiedEntities;
}
