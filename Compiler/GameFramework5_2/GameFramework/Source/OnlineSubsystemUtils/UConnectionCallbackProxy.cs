#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConnectionCallbackProxy.h")]
public partial class UConnectionCallbackProxy : UOnlineBlueprintCallProxyBase {
// ConnectionCallbackProxy
	public FOnlineConnectionResult OnSuccess;
	public FOnlineConnectionResult OnFailure;
	public UObject ConnectToService(UObject WorldContextObject,UObject PlayerController) { return default; }
}
