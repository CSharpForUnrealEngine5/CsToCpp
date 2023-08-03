#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConnectionCallbackProxy.h")]
public partial class UConnectionCallbackProxy : UOnlineBlueprintCallProxyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Called when there is a successful query</summary>
	public FOnlineConnectionResult OnSuccess;
	///<summary>Called when there is an unsuccessful query</summary>
	public FOnlineConnectionResult OnFailure;
	///<summary>Connects to an online service such as Google Play</summary>
	public static UConnectionCallbackProxy ConnectToService(UObject WorldContextObject,APlayerController PlayerController) { return default; }
}
