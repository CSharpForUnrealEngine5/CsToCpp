#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>set this to something larger than 0 to profile N runs</summary>
[CppInclude("RigVMHost.h")]
public partial class URigVMHost : UObject {
	///<summary>FindRigVMHosts</summary>
	public static TArray<URigVMHost> FindRigVMHosts(UObject Outer,UClass OptionalClass) { return default; }
	///<summary>Gets the current absolute time</summary>
	public  float GetAbsoluteTime() { return default; }
	///<summary>Gets the current delta time</summary>
	public  float GetDeltaTime() { return default; }
	///<summary>Set the current delta time</summary>
	public  void SetDeltaTime(float InDeltaTime) {}
	///<summary>Set the current absolute time</summary>
	public  void SetAbsoluteTime(float InAbsoluteTime,bool InSetDeltaTimeZero/*=false*/) {}
	///<summary>Set the current absolute and delta times</summary>
	public  void SetAbsoluteAndDeltaTime(float InAbsoluteTime,float InDeltaTime) {}
	///<summary>Set the current fps</summary>
	public  void SetFramesPerSecond(float InFramesPerSecond) {}
	///<summary>Returns the current frames per second (this may change over time)</summary>
	public  float GetCurrentFramesPerSecond() { return default; }
	///<summary>Is valid for execution</summary>
	public  bool CanExecute() { return default; }
	///<summary>Returns the names of variables accessible in scripting</summary>
	public  TArray<string> GetScriptAccessibleVariables() { return default; }
	///<summary>Returns the type of a given variable</summary>
	public  string GetVariableType(string InVariableName) { return default; }
	///<summary>Returns the value of a given variable as a string</summary>
	public  string GetVariableAsString(string InVariableName) { return default; }
	///<summary>Returns the value of a given variable as a string</summary>
	public  bool SetVariableFromString(string InVariableName,string InValue) { return default; }
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>Execute</summary>
	public  bool Execute(string InEventName) { return default; }
	///<summary>SupportsEvent</summary>
	public  bool SupportsEvent(string InEventName) { return default; }
	///<summary>GetSupportedEvents</summary>
	public  TArray<string> GetSupportedEvents() { return default; }
	///<summary>Execute a user defined event</summary>
	public  bool ExecuteEvent(string InEventName) { return default; }
	///<summary>Requests to perform an init during the next execution</summary>
	public  void RequestInit() {}
	///<summary>Requests to run an event once</summary>
	public  void RequestRunOnceEvent(string InEventName,int InEventIndex/*=-1*/) {}
	///<summary>Removes an event running once</summary>
	public  bool RemoveRunOnceEvent(string InEventName) { return default; }
	///<summary>GetVM</summary>
	public  URigVM GetVM() { return default; }
	///<summary>VM</summary>
	public URigVM VM;
	///<summary>DrawContainer</summary>
	public FRigVMDrawContainer DrawContainer;
	///<summary>The event name used during an update</summary>
	public TArray<string> EventQueue;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>VMSnapshotBeforeExecution</summary>
	public URigVM VMSnapshotBeforeExecution;
	///<summary>The current execution mode</summary>
	public bool bIsInDebugMode;
}
