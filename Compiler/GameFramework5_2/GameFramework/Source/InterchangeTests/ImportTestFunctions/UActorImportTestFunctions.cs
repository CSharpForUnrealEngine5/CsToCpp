#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/ActorImportTestFunctions.h")]
public partial class UActorImportTestFunctions : UImportTestFunctionsBase {
// ActorImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedActorCount(TArray<UObject> Actors,int ExpectedNumberOfImportedActors) { return default; }
	public FInterchangeTestFunctionResult CheckActorClassCount(TArray<UObject> Actors,UClass Class,int ExpectedNumberOfActors) { return default; }
	public FInterchangeTestFunctionResult CheckActorClass(UObject Actor,UClass ExpectedClass) { return default; }
	public FInterchangeTestFunctionResult CheckActorPropertyValue(UObject Actor,string PropertyName,bool bUseRegexToMatchValue,string ExpectedValue) { return default; }
	public FInterchangeTestFunctionResult CheckComponentPropertyValue(UObject Actor,string ComponentName,string PropertyName,bool bUseRegexToMatchValue,string ExpectedValue) { return default; }
}
