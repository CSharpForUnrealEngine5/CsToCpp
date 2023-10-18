namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_ActorsOfClass.h")]
public partial class UEnvQueryGenerator_ActorsOfClass : UEnvQueryGenerator {
	public static UClass StaticClass() {return default;}
	///<summary>SearchedActorClass</summary>
	public UClass SearchedActorClass;
	///<summary>If true, this will only returns actors of the specified class within the SearchRadius of the SearchCenter context.  If false, it will return ALL actors of the specified class in the world.</summary>
	public FAIDataProviderBoolValue GenerateOnlyActorsInRadius;
	///<summary>Max distance of path between point and context.  NOTE: Zero and negative values will never return any results if</summary>
	public FAIDataProviderFloatValue SearchRadius;
	///<summary>context</summary>
	public UClass SearchCenter;
}
