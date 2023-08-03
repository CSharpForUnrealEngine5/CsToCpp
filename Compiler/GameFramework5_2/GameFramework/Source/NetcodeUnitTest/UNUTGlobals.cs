#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores globals/static-variables for NetcodeUnitTest - for compatibility with hot reload</summary>
[CppInclude("NUTGlobals.h")]
public partial class UNUTGlobals : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>For NUTActor - the UNetConnection that &#39;watch&#39; events will be sent to</summary>
	public UNetConnection EventWatcher;
	///<summary>For ClientUnitTest - the (+10) incremented port number, for each server instance</summary>
	public int ServerPortOffset;
	///<summary>For MinimalClient - counter for the number of unit test net drivers created</summary>
	public int UnitTestNetDriverCount;
	///<summary>For the &#39;-DumpRPCs&#39; commandline parameter - limits DumpRPCs to RPC&#39;s (partially) matching the specified names</summary>
	public TArray<string> DumpRPCMatches;
	///<summary>List of modules recognized as containing unit tests, plus implementing FNUTModuleInterface for hot reload</summary>
	public TArray<string> UnitTestModules;
	///<summary>List of unit test modules that have been unloaded, prior to reloading for Hot Reload</summary>
	public TArray<string> UnloadedModules;
}
