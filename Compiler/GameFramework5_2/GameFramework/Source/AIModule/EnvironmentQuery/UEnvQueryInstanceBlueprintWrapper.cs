#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryInstanceBlueprintWrapper.h")]
public partial class UEnvQueryInstanceBlueprintWrapper : UObject {
// EnvQueryInstanceBlueprintWrapper
	public void FEQSQueryDoneSignature(UObject QueryInstance,EEnvQueryStatus QueryStatus) {}
	public int QueryID;
	public UClass ItemType;
	public int OptionIndex;
	public FEQSQueryDoneSignature OnQueryFinishedEvent;
	public float GetItemScore(int ItemIndex) { return default; }
	public bool GetQueryResultsAsActors(TArray<UObject> ResultActors) { return default; }
	public bool GetQueryResultsAsLocations(TArray<FVector> ResultLocations) { return default; }
	public TArray<UObject> GetResultsAsActors() { return default; }
	public TArray<FVector> GetResultsAsLocations() { return default; }
	public void SetNamedParam(string ParamName,float Value) {}
}
