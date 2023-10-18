namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyIslandActor.h")]
public partial class AWaterBodyIsland : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>GetWaterSpline</summary>
	public UWaterSplineComponent GetWaterSpline() { return default; }
	///<summary>WaterCurveSettings</summary>
	public FWaterCurveSettings WaterCurveSettings;
	///<summary>WaterHeightmapSettings</summary>
	public FWaterBodyHeightmapSettings WaterHeightmapSettings;
	///<summary>WaterWeightmapSettings</summary>
	public TMap<FName,FWaterBodyWeightmapSettings> WaterWeightmapSettings;
	///<summary>ActorIcon</summary>
	public UBillboardComponent ActorIcon;
	///<summary>The spline data attached to this water type.</summary>
	public UWaterSplineComponent SplineComp;
}
