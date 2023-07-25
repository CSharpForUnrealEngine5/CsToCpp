#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_ActorsOfClass.h")]
public partial class UEnvQueryGenerator_ActorsOfClass : UEnvQueryGenerator {
// EnvQueryGenerator_ActorsOfClass
	public UClass SearchedActorClass;
	public FAIDataProviderBoolValue GenerateOnlyActorsInRadius;
	public FAIDataProviderFloatValue SearchRadius;
	public UClass SearchCenter;
}
