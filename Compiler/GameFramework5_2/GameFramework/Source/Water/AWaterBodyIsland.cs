#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyIslandActor.h")]
public partial class AWaterBodyIsland : AActor {
// WaterBodyIsland
	public UObject GetWaterSpline() { return default; }
	public FWaterCurveSettings WaterCurveSettings;
	public FWaterBodyHeightmapSettings WaterHeightmapSettings;
	public TMap<string,FWaterBodyWeightmapSettings> WaterWeightmapSettings;
	public UBillboardComponent ActorIcon;
	public UWaterSplineComponent SplineComp;
}
