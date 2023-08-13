namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineSessionClient.h")]
public partial class UOnlineSessionClient : UOnlineSession {
	public static UClass StaticClass() {return default;}
	///<summary>Is this join from an invite</summary>
	public bool bIsFromInvite;
	///<summary>Have we started returning to main menu already</summary>
	public bool bHandlingDisconnect;
}
