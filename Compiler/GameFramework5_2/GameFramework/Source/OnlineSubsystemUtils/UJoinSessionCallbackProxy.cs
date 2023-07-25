#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JoinSessionCallbackProxy.h")]
public partial class UJoinSessionCallbackProxy : UOnlineBlueprintCallProxyBase {
// JoinSessionCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public UObject JoinSession(UObject WorldContextObject,UObject PlayerController,FBlueprintSessionResult SearchResult) { return default; }
}
