namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>set this to something larger than 0 to profile N runs</summary>
[CppInclude("RigVMHost.h")]
public partial class URigVMHost : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FindRigVMHosts</summary>
	public static TArray<URigVMHost> FindRigVMHosts(UObject Outer,UClass OptionalClass) { return default; }
	///<summary>Gets the current absolute time</summary>
	public float GetAbsoluteTime() { return default; }
	///<summary>Gets the current delta time</summary>
	public float GetDeltaTime() { return default; }
	///<summary>Set the current delta time</summary>
	public void SetDeltaTime(float InDeltaTime) {}
	///<summary>Set the current absolute time</summary>
	public void SetAbsoluteTime(float InAbsoluteTime,bool InSetDeltaTimeZero/*=false*/) {}
	///<summary>Set the current absolute and delta times</summary>
	public void SetAbsoluteAndDeltaTime(float InAbsoluteTime,float InDeltaTime) {}
	///<summary>Set the current fps</summary>
	public void SetFramesPerSecond(float InFramesPerSecond) {}
	///<summary>Returns the current frames per second (this may change over time)</summary>
	public float GetCurrentFramesPerSecond() { return default; }
	///<summary>Is valid for execution</summary>
	public virtual bool CanExecute() { return default; }
	///<summary>Returns the names of variables accessible in scripting</summary>
	public TArray<FName> GetScriptAccessibleVariables() { return default; }
	///<summary>Returns the type of a given variable</summary>
	public FName GetVariableType(FName InVariableName) { return default; }
	///<summary>Returns the value of a given variable as a string</summary>
	public string GetVariableAsString(FName InVariableName) { return default; }
	///<summary>Returns the value of a given variable as a string</summary>
	public bool SetVariableFromString(FName InVariableName,string InValue) { return default; }
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>Execute</summary>
	public virtual bool Execute(FName InEventName) { return default; }
	///<summary>SupportsEvent</summary>
	public bool SupportsEvent(FName InEventName) { return default; }
	///<summary>GetSupportedEvents</summary>
	public TArray<FName> GetSupportedEvents() { return default; }
	///<summary>Execute a user defined event</summary>
	public bool ExecuteEvent(FName InEventName) { return default; }
	///<summary>Requests to perform an init during the next execution</summary>
	public virtual void RequestInit() {}
	///<summary>Requests to run an event once</summary>
	public void RequestRunOnceEvent(FName InEventName,int InEventIndex/*=-1*/) {}
	///<summary>Removes an event running once</summary>
	public bool RemoveRunOnceEvent(FName InEventName) { return default; }
	///<summary>GetVM</summary>
	public URigVM GetVM() { return default; }
	///<summary>VM</summary>
	public URigVM VM;
	///<summary>DrawContainer</summary>
	public FRigVMDrawContainer DrawContainer;
	///<summary>The event name used during an update</summary>
	public TArray<FName> EventQueue;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>VMSnapshotBeforeExecution</summary>
	public URigVM VMSnapshotBeforeExecution;
	///<summary>The current execution mode</summary>
	public bool bIsInDebugMode;
}
