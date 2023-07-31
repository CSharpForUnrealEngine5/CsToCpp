#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/ActorImportTestFunctions.h")]
public partial class UActorImportTestFunctions : UImportTestFunctionsBase {
	///<summary>Check whether the expected number of actors are imported</summary>
	public static FInterchangeTestFunctionResult CheckImportedActorCount(TArray<AActor> Actors,int ExpectedNumberOfImportedActors) { return default; }
	///<summary>Check whether the expected number of actors with a given class are imported</summary>
	public static FInterchangeTestFunctionResult CheckActorClassCount(TArray<AActor> Actors,UClass Class,int ExpectedNumberOfActors) { return default; }
	///<summary>Check whether the imported actor has the expected class</summary>
	public static FInterchangeTestFunctionResult CheckActorClass(AActor Actor,UClass ExpectedClass) { return default; }
	///<summary>Check whether the generic property (with a given name) in the imported actor has the expected value (or matches with it using regex)</summary>
	public static FInterchangeTestFunctionResult CheckActorPropertyValue(AActor Actor,string PropertyName,bool bUseRegexToMatchValue,string ExpectedValue) { return default; }
	///<summary>Check whether the generic property (with a given name) in the imported actor component (with the given name) has the expected value (or matches with it using regex)</summary>
	public static FInterchangeTestFunctionResult CheckComponentPropertyValue(AActor Actor,string ComponentName,string PropertyName,bool bUseRegexToMatchValue,string ExpectedValue) { return default; }
}
