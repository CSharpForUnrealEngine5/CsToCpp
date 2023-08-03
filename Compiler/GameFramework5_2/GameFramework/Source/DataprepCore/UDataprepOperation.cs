#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all Dataprep operations</summary>
[CppInclude("DataprepOperation.h")]
public partial class UDataprepOperation : UDataprepParameterizableObject {
	public static UClass StaticClass() {return default;}
	///<summary>Execute the operation</summary>
	public  void Execute(TArray<UObject> InObjects) {}
	///<summary>This function is called when the operation is executed.</summary>
	public  void OnExecution(FDataprepContext InContext) {}
	///<summary>Add an info to the log</summary>
	public  void LogInfo(string InLogText) {}
	///<summary>Add a warning to the log</summary>
	public  void LogWarning(string InLogText) {}
	///<summary>Add Error to the log</summary>
	public  void LogError(string InLogError) {}
	///<summary>Indicates the beginning of a new work to report on</summary>
	public  void BeginWork(string InDescription,float InAmountOfWork) {}
	///<summary>Indicates the end of the work</summary>
	public  void EndWork() {}
	///<summary>Report foreseen progress on the current work</summary>
	public  void ReportProgress(float IncrementOfWork,string InMessage) {}
	///<summary>Indicates an array of assets has changed during the operation. It is important to use this function</summary>
	public  void AssetsModified(TArray<UObject> Assets) {}
	///<summary>Allows to change the name of the fetcher for the ui if needed.</summary>
	public  string GetDisplayOperationName() { return default; }
	///<summary>Allows to change the tooltip of the fetcher for the ui if needed.</summary>
	public  string GetTooltip() { return default; }
	///<summary>Allows to change the tooltip of the fetcher for the ui if needed.</summary>
	public  string GetCategory() { return default; }
	///<summary>Allows to add more keywords for when a user is searching for the fetcher in the ui.</summary>
	public  string GetAdditionalKeyword() { return default; }
}
