#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JoinSessionCallbackProxy.h")]
public partial class UJoinSessionCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful join</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when there is an unsuccessful join</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>Joins a remote session with the default online subsystem</summary>
	public static UJoinSessionCallbackProxy JoinSession(UObject WorldContextObject,APlayerController PlayerController,FBlueprintSessionResult SearchResult) { return default; }
}
