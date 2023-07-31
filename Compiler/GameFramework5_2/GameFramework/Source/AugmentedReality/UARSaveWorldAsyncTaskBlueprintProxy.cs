#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARBlueprintProxy.h")]
public partial class UARSaveWorldAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy {
	///<summary>OnSuccess</summary>
	public FARSaveWorldPin OnSuccess;
	///<summary>OnFailed</summary>
	public FARSaveWorldPin OnFailed;
	///<summary>Saves an AR world to a byte array for network replication or saving to disk</summary>
	public static UARSaveWorldAsyncTaskBlueprintProxy ARSaveWorld(UObject WorldContextObject) { return default; }
}
