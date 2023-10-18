namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HordeExecutorSettings.h")]
public partial class UHordeExecutorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The Horde server content addressable storage address.</summary>
	public string ContentAddressableStorageTarget;
	///<summary>The Horde server execution address.</summary>
	public string ExecutionTarget;
	///<summary>Extra headers required for content addressable storage requests.</summary>
	public TMap<string,string> ContentAddressableStorageHeaders;
	///<summary>Extra headers required for execution requests.</summary>
	public TMap<string,string> ExecutionHeaders;
}
