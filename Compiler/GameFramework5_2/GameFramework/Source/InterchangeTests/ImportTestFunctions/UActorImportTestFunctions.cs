#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/ActorImportTestFunctions.h")]
public partial class UActorImportTestFunctions : UImportTestFunctionsBase {
// ActorImportTestFunctions
	public static FInterchangeTestFunctionResult CheckImportedActorCount(TArray<AActor> Actors,int ExpectedNumberOfImportedActors) { return default; }
	public static FInterchangeTestFunctionResult CheckActorClassCount(TArray<AActor> Actors,UClass Class,int ExpectedNumberOfActors) { return default; }
	public static FInterchangeTestFunctionResult CheckActorClass(AActor Actor,UClass ExpectedClass) { return default; }
	public static FInterchangeTestFunctionResult CheckActorPropertyValue(AActor Actor,string PropertyName,bool bUseRegexToMatchValue,string ExpectedValue) { return default; }
	public static FInterchangeTestFunctionResult CheckComponentPropertyValue(AActor Actor,string ComponentName,string PropertyName,bool bUseRegexToMatchValue,string ExpectedValue) { return default; }
}
