#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JoinSessionCallbackProxy.h")]
public partial class UJoinSessionCallbackProxy : UOnlineBlueprintCallProxyBase {
// JoinSessionCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public static UJoinSessionCallbackProxy JoinSession(UObject WorldContextObject,APlayerController PlayerController,FBlueprintSessionResult SearchResult) { return default; }
}
