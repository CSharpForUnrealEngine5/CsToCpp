#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphSettings.h")]
///<summary>Implements the settings for the ZoneGraph plugin.</summary>
public partial class UZoneGraphSettings : UDeveloperSettings {
// ZoneGraphSettings
	public TArray<FZoneLaneProfile> LaneProfiles;
	public FZoneGraphTagInfo Tags;
	public FZoneGraphTagMask VisualizedTags;
	public float ShapeMaxDrawDistance;
	public FZoneGraphBuildSettings BuildSettings;
	public bool bBuildZoneGraphWhileEditing;
}
