#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperation.h")]
///<summary>Base class for all Dataprep operations</summary>
public partial class UDataprepOperation : UDataprepParameterizableObject {
// DataprepOperation
	public void Execute(TArray<UObject> InObjects) {}
	public void OnExecution(FDataprepContext InContext) {}
	public void LogInfo(string InLogText) {}
	public void LogWarning(string InLogText) {}
	public void LogError(string InLogError) {}
	public void BeginWork(string InDescription,float InAmountOfWork) {}
	public void EndWork() {}
	public void ReportProgress(float IncrementOfWork,string InMessage) {}
	public void AssetsModified(TArray<UObject> Assets) {}
	public string GetDisplayOperationName() { return default; }
	public string GetTooltip() { return default; }
	public string GetCategory() { return default; }
	public string GetAdditionalKeyword() { return default; }
}
