#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_Donut.h")]
public partial class UEnvQueryGenerator_Donut : UEnvQueryGenerator_ProjectedPoints {
// EnvQueryGenerator_Donut
	public FAIDataProviderFloatValue InnerRadius;
	public FAIDataProviderFloatValue OuterRadius;
	public FAIDataProviderIntValue NumberOfRings;
	public FAIDataProviderIntValue PointsPerRing;
	public FEnvDirection ArcDirection;
	public FAIDataProviderFloatValue ArcAngle;
	public bool bUseSpiralPattern;
	public UClass Center;
	public bool bDefineArc;
}
