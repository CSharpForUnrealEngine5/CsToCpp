#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CreateSessionCallbackProxy.h")]
public partial class UCreateSessionCallbackProxy : UOnlineBlueprintCallProxyBase {
// CreateSessionCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public static UCreateSessionCallbackProxy CreateSession(UObject WorldContextObject,APlayerController PlayerController,int PublicConnections,bool bUseLAN) { return default; }
}
