#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMHost.h")]
///<summary>set this to something larger than 0 to profile N runs</summary>
public partial class URigVMHost : UObject {
// RigVMHost
	public TArray<UObject> FindRigVMHosts(UObject Outer,UClass OptionalClass) { return default; }
	public float GetAbsoluteTime() { return default; }
	public float GetDeltaTime() { return default; }
	public void SetDeltaTime(float InDeltaTime) {}
	public void SetAbsoluteTime(float InAbsoluteTime,bool InSetDeltaTimeZero/*=false*/) {}
	public void SetAbsoluteAndDeltaTime(float InAbsoluteTime,float InDeltaTime) {}
	public void SetFramesPerSecond(float InFramesPerSecond) {}
	public float GetCurrentFramesPerSecond() { return default; }
	public bool CanExecute() { return default; }
	public TArray<string> GetScriptAccessibleVariables() { return default; }
	public string GetVariableType(string InVariableName) { return default; }
	public string GetVariableAsString(string InVariableName) { return default; }
	public bool SetVariableFromString(string InVariableName,string InValue) { return default; }
	public FRigVMRuntimeSettings VMRuntimeSettings;
	public bool Execute(string InEventName) { return default; }
	public bool SupportsEvent(string InEventName) { return default; }
	public TArray<string> GetSupportedEvents() { return default; }
	public bool ExecuteEvent(string InEventName) { return default; }
	public void RequestInit() {}
	public void RequestRunOnceEvent(string InEventName,int InEventIndex/*=-1*/) {}
	public bool RemoveRunOnceEvent(string InEventName) { return default; }
	public UObject GetVM() { return default; }
	public URigVM VM;
	public FRigVMDrawContainer DrawContainer;
	public TArray<string> EventQueue;
	public TArray<UAssetUserData> AssetUserData;
	public URigVM VMSnapshotBeforeExecution;
	public bool bIsInDebugMode;
}
