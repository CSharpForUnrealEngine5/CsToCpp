#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_OnCircle.h")]
public partial class UEnvQueryGenerator_OnCircle : UEnvQueryGenerator_ProjectedPoints {
// EnvQueryGenerator_OnCircle
	public FAIDataProviderFloatValue CircleRadius;
	public FAIDataProviderFloatValue SpaceBetween;
	public FAIDataProviderIntValue NumberOfPoints;
	public EPointOnCircleSpacingMethod PointOnCircleSpacingMethod;
	public FEnvDirection ArcDirection;
	public FAIDataProviderFloatValue ArcAngle;
	public float AngleRadians;
	public UClass CircleCenter;
	public bool bIgnoreAnyContextActorsWhenGeneratingCircle;
	public FAIDataProviderFloatValue CircleCenterZOffset;
	public FEnvTraceData TraceData;
	public bool bDefineArc;
}
