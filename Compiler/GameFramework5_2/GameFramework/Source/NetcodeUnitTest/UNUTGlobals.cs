#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NUTGlobals.h")]
///<summary>Stores globals/static-variables for NetcodeUnitTest - for compatibility with hot reload</summary>
public partial class UNUTGlobals : UObject {
// NUTGlobals
	public UNetConnection EventWatcher;
	public int ServerPortOffset;
	public int UnitTestNetDriverCount;
	public TArray<string> DumpRPCMatches;
	public TArray<string> UnitTestModules;
	public TArray<string> UnloadedModules;
}
