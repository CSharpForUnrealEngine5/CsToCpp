#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LeaderboardFlushCallbackProxy.h")]
public partial class ULeaderboardFlushCallbackProxy : UObject {
// LeaderboardFlushCallbackProxy
	public FOnLeaderboardFlushed OnSuccess;
	public FOnLeaderboardFlushed OnFailure;
	public UObject CreateProxyObjectForFlush(UObject PlayerController,string SessionName) { return default; }
}
