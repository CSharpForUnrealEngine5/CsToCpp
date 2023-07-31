#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>WaterBodyExclusionVolume allows players not enter surface swimming when touching a water volume</summary>
[CppInclude("WaterBodyExclusionVolume.h")]
public partial class AWaterBodyExclusionVolume : APhysicsVolume {
	///<summary>If checked, all water bodies overlapping with this exclusion volumes will be affected.</summary>
	public bool bExcludeAllOverlappingWaterBodies;
	///<summary>List of water bodies that will be affected by this exclusion volume</summary>
	public TArray<AWaterBody> WaterBodiesToExclude;
	///<summary>bIgnoreAllOverlappingWaterBodies_DEPRECATED</summary>
	public bool bIgnoreAllOverlappingWaterBodies_DEPRECATED;
	///<summary>WaterBodiesToIgnore_DEPRECATED</summary>
	public TArray<AWaterBody> WaterBodiesToIgnore_DEPRECATED;
	///<summary>WaterBodyToIgnore_DEPRECATED</summary>
	public AWaterBody WaterBodyToIgnore_DEPRECATED;
	///<summary>ActorIcon</summary>
	public UBillboardComponent ActorIcon;
}
