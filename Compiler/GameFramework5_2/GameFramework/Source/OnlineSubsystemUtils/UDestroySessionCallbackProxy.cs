#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestroySessionCallbackProxy.h")]
public partial class UDestroySessionCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful destroy</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when there is an unsuccessful destroy</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>Destroys a session previously created by the default online subsystem</summary>
	public static UDestroySessionCallbackProxy DestroySession(UObject WorldContextObject,APlayerController PlayerController) { return default; }
}
