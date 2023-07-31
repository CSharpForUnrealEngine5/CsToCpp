#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event triggered when an exposed entity struct is modified.</summary>
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetEntitiesModifiedEvent {
	public string Type;
	public string PresetName;
	public string PresetId;
	public FRCPresetModifiedEntitiesDescription ModifiedEntities;
}
