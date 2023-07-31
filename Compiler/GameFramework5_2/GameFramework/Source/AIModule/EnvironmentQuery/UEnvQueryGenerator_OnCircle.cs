#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_OnCircle.h")]
public partial class UEnvQueryGenerator_OnCircle : UEnvQueryGenerator_ProjectedPoints {
	///<summary>max distance of path between point and context</summary>
	public FAIDataProviderFloatValue CircleRadius;
	///<summary>items will be generated on a circle this much apart</summary>
	public FAIDataProviderFloatValue SpaceBetween;
	///<summary>this many items will be generated on a circle</summary>
	public FAIDataProviderIntValue NumberOfPoints;
	///<summary>how we are choosing where the points are in the circle</summary>
	public EPointOnCircleSpacingMethod PointOnCircleSpacingMethod;
	///<summary>If you generate items on a piece of circle you define direction of Arc cut here</summary>
	public FEnvDirection ArcDirection;
	///<summary>If you generate items on a piece of circle you define angle of Arc cut here</summary>
	public FAIDataProviderFloatValue ArcAngle;
	///<summary>AngleRadians</summary>
	public float AngleRadians;
	///<summary>context</summary>
	public UClass CircleCenter;
	///<summary>ignore tracing into context actors when generating the circle</summary>
	public bool bIgnoreAnyContextActorsWhenGeneratingCircle;
	///<summary>context offset</summary>
	public FAIDataProviderFloatValue CircleCenterZOffset;
	///<summary>horizontal trace for nearest obstacle</summary>
	public FEnvTraceData TraceData;
	///<summary>bDefineArc</summary>
	public bool bDefineArc;
}
