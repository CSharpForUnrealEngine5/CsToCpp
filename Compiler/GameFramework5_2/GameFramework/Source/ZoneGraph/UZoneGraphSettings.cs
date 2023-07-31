#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the ZoneGraph plugin.</summary>
[CppInclude("ZoneGraphSettings.h")]
public partial class UZoneGraphSettings : UDeveloperSettings {
	///<summary>LaneProfiles</summary>
	public TArray<FZoneLaneProfile> LaneProfiles;
	///<summary>Tags</summary>
	public FZoneGraphTagInfo Tags;
	///<summary>Tags which affect visualization (i.e. color of lanes).</summary>
	public FZoneGraphTagMask VisualizedTags;
	///<summary>Max draw distance for shapes visualization.</summary>
	public float ShapeMaxDrawDistance;
	///<summary>BuildSettings</summary>
	public FZoneGraphBuildSettings BuildSettings;
	///<summary>When set to true ZoneGraph will build as it is being edited.</summary>
	public bool bBuildZoneGraphWhileEditing;
}
