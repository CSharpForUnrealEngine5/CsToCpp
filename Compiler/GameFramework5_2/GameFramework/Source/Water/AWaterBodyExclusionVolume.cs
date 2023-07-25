#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyExclusionVolume.h")]
///<summary>WaterBodyExclusionVolume allows players not enter surface swimming when touching a water volume</summary>
public partial class AWaterBodyExclusionVolume : APhysicsVolume {
// WaterBodyExclusionVolume
	public bool bExcludeAllOverlappingWaterBodies;
	public TArray<AWaterBody> WaterBodiesToExclude;
	public bool bIgnoreAllOverlappingWaterBodies_DEPRECATED;
	public TArray<AWaterBody> WaterBodiesToIgnore_DEPRECATED;
	public AWaterBody WaterBodyToIgnore_DEPRECATED;
	public UBillboardComponent ActorIcon;
}
