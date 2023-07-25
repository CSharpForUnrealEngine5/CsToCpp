#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_Cone.h")]
public partial class UEnvQueryGenerator_Cone : UEnvQueryGenerator_ProjectedPoints {
// EnvQueryGenerator_Cone
	public FAIDataProviderFloatValue AlignedPointsDistance;
	public FAIDataProviderFloatValue ConeDegrees;
	public FAIDataProviderFloatValue AngleStep;
	public FAIDataProviderFloatValue Range;
	public UClass CenterActor;
	public bool bIncludeContextLocation;
}
