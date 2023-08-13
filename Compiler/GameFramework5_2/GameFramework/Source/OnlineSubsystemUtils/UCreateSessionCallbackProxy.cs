namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CreateSessionCallbackProxy.h")]
public partial class UCreateSessionCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the session was created successfully</summary>
	public FEmptyOnlineDelegate OnSuccess;
	///<summary>Called when there was an error creating the session</summary>
	public FEmptyOnlineDelegate OnFailure;
	///<summary>Creates a session with the default online subsystem</summary>
	public static UCreateSessionCallbackProxy CreateSession(UObject WorldContextObject,APlayerController PlayerController,int PublicConnections,bool bUseLAN) { return default; }
}
